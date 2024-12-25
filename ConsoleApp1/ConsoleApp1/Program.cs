using System.Text;

namespace CW
{
    class ex3
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();
        }

        public static void Check(string text, StringBuilder stringBuilder)
        {
            for (int i = 0; i < text.Length; i++)
            {
                
                if (text[i] != ' ' || text[i] != '.' || text[i] != ',')
                {
                    stringBuilder.Append(text[i]);
                }
            }

            for (int i = 0; i < stringBuilder.Length; i++)
            {
                if (text.StartsWith(text.ToLower())
            }
        }

        public static bool Result(StringBuilder stringBuilder, string text)
        {
            for (int i = 0; i < stringBuilder.Length; i++)
            {
                if ()
            }
        }


    }
}