using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2_DiceRolls
{
    internal class DiceRoll //dope class for rolling two dice
    {
        private Random random;//call random class to generate random numbers

        //constructor to initialize random num generator
        public DiceRoll() { 
            random = new Random();
        }

        //Simulate dice rolls for the requested number of rolls
        public int[] SimulateRolls(int numRolls)
        {
            //array to store the count of each dice combination
            int[] results = new int[13];//Because 0 is not used, 2 represents 2, 3 represents 3, and so on

            //loop through specified number of rolls
            for (int i = 0; i < numRolls; i++)
            {
                //Two dice are assignemd random values between 1 and 6
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                //The results are added up
                int sum = dice1 + dice2;

                //Results stored in an array
                results[sum]++;
            }

            return results;
        }
    }
}
