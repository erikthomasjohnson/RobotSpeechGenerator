using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class RobotMother
    {
        WordGenerator wordGenerator;
        public RobotMother()
        {
            wordGenerator = new WordGenerator();
        }
        public virtual void Talk(int i)
        {

            if ((i + 2) % 5 == 0) {
                Console.WriteLine("**********Mother Robot: " + " My dearest " + wordGenerator.generateInsultNoun() + "s please be " + wordGenerator.generateAdjectivePositive() + " and stop acting so " + wordGenerator.generateAdjectiveNegative() + "!!!*********");
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine("**********Mother Robot: " + wordGenerator.generateInterjection().ToUpper() + "... I CAN'T STAND YOU " + wordGenerator.generateInsultNoun().ToUpper() + "S!!!!!*********");
            }
            else
            {
                if (i % 9 == 0)
                {
                    Console.WriteLine("**********Mother Robot: " + wordGenerator.generateAdjectiveNegative().ToUpper() + " CHILDREN!!!! Please Stop Fighting!!!!!*********");
                }
                else
                {
                    Console.WriteLine("**********Mother Robot: " + wordGenerator.generateAdjectiveNegative().ToUpper() + ", I'VE HAD ENOUGH YOU " + wordGenerator.generateAdjectiveNegativeTwo().ToUpper() + " " + wordGenerator.generateInsultNoun().ToUpper() + "S!!!!!!!!!*********");
                }
            }
        }
    }
}
