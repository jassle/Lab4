using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int num2;
            int num3;
            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine("Please enter an integer:");
                bool check = int.TryParse(Console.ReadLine(), out num);
                if (check == false)
                {
                    Console.WriteLine("invalid entry");
                    continue;
                }
                Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-10}", "Number", "Squared", "Cubed"));
                Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-10}", "========", "========", "========"));

                for (int i = 1; i <= num; i++)
                {   //num = i;
                    //num2 = i * i;
                    //num3 = i * i * i;
                    Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-10}", i, i * i, i * i * i));
                }
                while (true)
                {
                    Console.WriteLine("Would you like to continue?");
                    string input = Console.ReadLine().ToUpper();
                    if (input == "N")
                    {
                        repeat = false;
                        break;
                    }
                    else if (input == "Y")
                    {
                        repeat = true;
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Invalid input, try again");

                    }
                }
            }
            Console.WriteLine("Goodbye!!");
        }
    }
}
