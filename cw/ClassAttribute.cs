using System;
using System.Collections.Generic;

namespace cw2;

public class ClassAttribute<T> : Attribute
{
    private T[] plugs { get; set; }
    public ClassAttribute(params T[] plugins)
    {
        plugs = plugins;
    }
}

public class Dependencies<T> where T : class
{
    public bool CheckDependencies(T[] values)
    {
        if (values == null) return false;

        foreach (var plugin in values)
        {
            var foundAttributes = plugin.GetType().GetCustomAttributes(typeof(ClassAttribute<T>), false);

            if (foundAttributes != null && foundAttributes.Length > 0)
            {
                var dependencyInfo = foundAttributes[0] as ClassAttribute<T>;

                foreach (var e in dependencyInfo) //извините, я не знаю, как тут сделать, мне надо перебрать из dependencyInfo
                {
                    bool exists = false;

                    foreach (var t in values)
                    {
                        if (t.GetType() == e as Type)
                        {
                            exists = true;
                            break;
                        }
                    }

                    if (!exists) return false;
                }
            }
        }
        return true;
    }
}
