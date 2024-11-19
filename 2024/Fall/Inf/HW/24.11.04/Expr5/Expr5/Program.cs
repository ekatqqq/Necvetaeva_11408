namespace Classwork
{
    class Expr5
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int b);

            Console.WriteLine(CheckLeapYear(a, b));
        }

        static int CheckLeapYear(int a, int b)
        {
            int result = (b / 4 - (a - 1) / 4) - (b / 100 - (a - 1) / 100) + (b / 400 - (a - 1) / 400);
            return result;
        }
    }
}