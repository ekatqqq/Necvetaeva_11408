using System.Reflection;

namespace cw2;

class Graph<T>
{
    private Dictionary<Type, List<Type>> graph;

    public void BuildGraph(Assembly assembly)
    {
        foreach (var type in assembly.GetTypes())
        {
            var plugAttr = type.GetCustomAttributes(typeof(ClassAttribute<T>), false);

            if (plugAttr.Length > 0)
            {
                graph[type] = new List<Type>();

                var attr = (ClassAttribute<Type>)plugAttr[0];
                FieldInfo plugsField = attr.GetType().GetField("plugs");
                var requiredPlugins = (Type[])plugsField.GetValue(attr);

                foreach (var pluginType in requiredPlugins)
                {
                    graph[type].Add(pluginType);
                }
            }
        }
    }
    public bool CheckCycles()
    {
        foreach (var pluginType in graph.Keys)
        {
            var visited = new HashSet<Type>();
            var stack = new Stack<Type>();

            stack.Push(pluginType);

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                if (visited.Contains(current)) continue;
                visited.Add(current);

                if (graph.ContainsKey(current))
                {
                    IEnumerable<Type> dependencies = graph[current];
                    foreach (var e in dependencies)
                    {
                        if (e == pluginType) return true;
                        if (!visited.Contains(e)) stack.Push(e);
                    }
                }
            }
        }
        return false;
    }
}