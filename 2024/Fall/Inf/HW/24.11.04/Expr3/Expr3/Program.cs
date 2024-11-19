using System.Diagnostics;

namespace Expr3
{
    class TaskExecutor
    {
        static void Main()
        {
            Console.Write("enter the hour: ");
            int time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"the angle is: {GetResult(time)} degrees");

        }

        static int GetResult(int time)
        {
            int angle = 180 - Math.Abs(180 - ((time % 12) * 30));
            return angle;
        }
    }
}
