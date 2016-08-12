using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------Enter Robot Home--------------------");
            while (Console.ReadLine().ToLower() != "exit")
            {
                for (int i = 1; i < 20; i++)
                {
                    RobotPositive talkPositive = new RobotPositive();
                    talkPositive.Talk(i);

                    System.Threading.Thread.Sleep(3000);

                    RobotNegative talkNegative = new RobotNegative();
                    talkNegative.Talk(i);
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(3000);

                    for (int ii = (i%3); ii == 0; ii++)
                    {
                        RobotMother talkMother = new RobotMother();
                        talkMother.Talk(i);
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(4000);
                    }
                    System.Threading.Thread.Sleep(2000);
                }
            }
        }
    }
}
