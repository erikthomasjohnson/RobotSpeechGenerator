using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class RobotPositive : RobotMother
    {
        WordGenerator wordGenerator;
        public RobotPositive()
        {
            wordGenerator = new WordGenerator();
        }
        public override void Talk(int i)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine("Skipper the Robot: " + wordGenerator.generateInterjection() + "..., you're a " + wordGenerator.generateAdjectivePositive() + ", " + wordGenerator.generateAdverb() + " " + wordGenerator.generateAdjectivePositiveTwo() + " " + wordGenerator.generateInsultNoun() + "!");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Skipper the Robot: " + wordGenerator.generateActionPositive());
            }
            else if (i % 2 == 0)
            {
                if ((i + 3) % 3 == 0)
                {
                    Console.WriteLine("Skipper the Robot: " + " This " + wordGenerator.generateAdjectivePositive() + " " + wordGenerator.generateNoun() + " is " + wordGenerator.generateAdjectivePositiveTwo() + "!");
                }
                else
                {
                    Console.WriteLine("Skipper the Robot: " + wordGenerator.generateInterjection() + ".....");
                }
            }
            else
            {
                if ((i + 2) % 3 == 0)
                {
                    Console.WriteLine("Skipper the Robot: " + wordGenerator.generateInterjection() + ", " + wordGenerator.generateInquiry());
                }
                else
                {
                    Console.WriteLine("Skipper the Robot: " + wordGenerator.generateReaction());
                }
            }
        }
    }
}
