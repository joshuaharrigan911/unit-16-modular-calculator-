using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U16_modular_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator MyCalc = new Calculator();

            Console.WriteLine("####################################");
            Console.WriteLine("######## C# CALCULATOR   )##########");
            Console.WriteLine("####################################");

            bool calcLoop = true;
            while (calcLoop == true)
            {
                Console.Write("\nEnter Your First Number: ");
                double inputOne = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Your Second Number");
                double inputTwo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nMenu");
                Console.WriteLine("Enter 1 For Additon");
                Console.WriteLine("Enter 2 For Subtraction");
                Console.WriteLine("Enter 3 For Multiplication");
                Console.WriteLine("Enter 4 For Division");
                Console.WriteLine("");


                int opChioce = Convert.ToInt32(Console.ReadLine());
                switch (opChioce)

                {
                    case 1:
                        Console.WriteLine("\nYour Answer is: " + MyCalc.Add(inputOne, inputTwo).ToString());
                        break;
                    case 2:
                        Console.WriteLine("\nYour Answer is: " + MyCalc.Subtract(inputOne, inputTwo).ToString());
                        break;
                    case 3:
                        Console.WriteLine("\nYour Answer is: " + MyCalc.Multiply(inputOne, inputTwo).ToString());
                        break;
                    case 4:
                        Console.WriteLine("\nYour Answer is: " + MyCalc.Divide(inputOne, inputTwo).ToString());
                        break;
                    default:
                        Console.WriteLine("\nYou should Enter A number From The Menu.");
                        break;
                }
                Console.WriteLine("");
                Console.Write("\nDo You Want To Try Another Sum? Y/N: ");
                string restartChoice = Console.ReadLine().ToUpper();

                if (restartChoice == "Y")
                {
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Press any key to exit");
                    calcLoop = false;

                }
            }
            Console.ReadKey();

        }
    }
}

