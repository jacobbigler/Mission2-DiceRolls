
using Mission2_DiceRolls;
using System.ComponentModel.Design;

public class Program
{
    private static void Main(string[] args)
    {
        //Create variable for asking for the num of rolls
        int num = 0;

        System.Console.WriteLine("Welcome to the dice throwing simulator!");//Welcome :)

        System.Console.WriteLine("How many dice rolls would you like to simulate?");//Ask for number of rolls

        while (true)
        {
            int userInput = int.Parse(System.Console.ReadLine());

            if (userInput > 0 && userInput <= 2147483647)
            {
                num = userInput; // Store the number of rolls input into the num variable
                break; // Exit the loop if the input is greater than 0
            }
            else
            {
                System.Console.WriteLine("Please enter a number greater than 0 and less than 2,147,483,647");
            }
        }

        //Bring in the other class
        DiceRoll dr = new DiceRoll();

        //Call method to simulate the rollsintint
        int[] results = dr.SimulateRolls(num);

        //Call Print method and pass parameters
        PrintHistogram(results, num);

    }

    private static void PrintHistogram(int[] results, int num)
    {
        //print header
        System.Console.WriteLine("\nHistogram");

        //go through possible dice combinations
        for (int i = 2; i <= 12; i++)
        {
            //calculate percentage of times the combination was rolled
            double percentage = results[i] * 100 / num;
            percentage = (int)Math.Round(percentage, 0);

            //print combination and its corresponding percentage using "*"
            System.Console.Write($"{i,2}: ");

            for (int j = 0; j < percentage; j++)
            {
                System.Console.Write("*");
            }

            //Add the percentage for better readability
            System.Console.WriteLine($" ({percentage}%)");
        }
    }
}