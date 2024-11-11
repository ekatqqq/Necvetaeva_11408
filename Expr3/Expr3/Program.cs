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
            if ((time > 0 && time <= 6) || (time > 12 && time <= 18))
            {
                int angle = time * 30;
                return angle;
            }
            else if (time >= 7 && time < 12)
            {
                int angle = 360 - (time * 30);
                return angle;
            }
            else if (time >= 19 && time <= 23)
            {
                int angle = 720 - (time * 30);
                return angle;
            }
            return 0;
        }
    }
}
