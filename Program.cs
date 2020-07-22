using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to math? y/n");
            string answer = Console.ReadLine();

            while (answer == "y")
            {
                Console.WriteLine("plz enter a number");
                string input = Console.ReadLine();
                int num; //blank int variable to check against user input
                bool numCheck = int.TryParse(input, out num); //checking to see if user put in a number

                if (numCheck) //if user put in a number then:
                {
                    //the number table/array/thing math
                    int maxValue = int.Parse(input);
                    int counter;
                    int square = 1;
                    int cube = 1;


                    Console.WriteLine("Number  Square    Cube");
                    Console.WriteLine("-----------------------");

                    for (counter = 1; counter <= maxValue; counter++)
                    {
                        square = counter * counter;
                        cube = counter * counter * counter;
                        Console.WriteLine("{0}        {1}         {2}", counter, square, cube);
                    }
                    Console.Write("Continue? (y/n)");
                    answer = Console.ReadLine();
                }


                else //if user put in text or something not a number
                {
                    Console.WriteLine("a NUMBER you doof");
                }
            };
            while (answer == "n")
            {
                Console.WriteLine("Ok, see you later!");
                break; //ending
            };
        }
    }
}
