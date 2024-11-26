namespace Homework
{
    class Expr12
    {
        static void Main()
        {
            double h = Convert.ToDouble(Console.ReadLine());
            double t = Convert.ToDouble(Console.ReadLine());
            double v = Convert.ToDouble(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            double minT = (h - x * t) / (v - x);
            double maxT = h / x - t;
            Console.WriteLine($"{minT} {maxT}");
        }
    }
}