using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class RobotNegative : RobotMother
    {
        WordGenerator wordGenerator;
        public RobotNegative()
        {
            wordGenerator = new WordGenerator();
        }
        public override void Talk(int i)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine("Gilligan the Robot: " + wordGenerator.generateReaction());
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Gilligan the Robot: " + wordGenerator.generateInterjection() + "..., you're being a " + wordGenerator.generateAdjectiveNegative() + ", " + wordGenerator.generateAdverb() + " " + wordGenerator.generateAdjectiveNegativeTwo() + " " + wordGenerator.generateInsultNoun() + "!");
            }
            else if (i % 2 == 0)
            {
                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine("Gilligan the Robot: " + " That there " + wordGenerator.generateAdjectiveNegative() + " " + wordGenerator.generateNoun() + " is " + wordGenerator.generateAdjectiveNegativeTwo() + "!");
                }
                else
                {
                    Console.WriteLine("Gilligan the Robot: " + wordGenerator.generateInterjection() + ".....");
                }
            }
            else
            {
                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine("Gilligan the Robot: " + wordGenerator.generateInterjection() + ", " + wordGenerator.generateInquiry());
                }
                else
                {
                    Console.WriteLine("Gilligan the Robot: " + wordGenerator.generateActionNegative());
                }
            }
        }
    }
}
