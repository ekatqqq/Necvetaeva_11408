namespace Expr2
{
    class TaskExecutor
    {
        static void Main(string[] args)
        {
            Console.Write("enter a three digit number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetResult(number));
        }

        static string GetResult(int number)
        {
            int num1 = number / 100 % 1000;
            int num2 = number / 10 % 10;
            int num3 = number % 10;

            return ($"{num3}{num2}{num1}").ToString();
        }
    }
}