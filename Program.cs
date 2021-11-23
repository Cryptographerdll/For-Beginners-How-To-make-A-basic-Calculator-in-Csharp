using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claculator.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the action to be performed");
            Console.Write("\npress 1 for Addition");
            Console.Write("\npress 2 for Substraction");
            Console.Write("\npress 3 for Multiplication");
            Console.Write("\npress 4 for Division");

            int action = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the first number ");
                int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the seconde number ");
                int input_2 = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            // switching the operations signs confirmed by the user . 
            switch (action)
            {
                case 1:
                    {
                        result = Addition(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = Substraction(input_1, input_2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(input_1, input_2);
                        break;
                    }
                case 4:
                    {
                        result = Division(input_1, input_2);
                        break;
                    }
              
                default:
                    Console.WriteLine("WRONG ! try again");
                    break;
            }
            Console.Write("the result {0}", result);
            Console.ReadKey();
        }
        // the operation functions . 

     // Addition 
      public static int Addition (int input_1 , int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
    // Substraction 
      public static int Substraction (int input_1 , int input_2)
        {
            int result = input_1 - input_2;
            return result;
        }
    // Multiplication 
      public static int Multiplication (int input_1 , int input_2)
        {
            int result = input_1 * input_2;
            return result;
        }
    // Division 
      public static int Division (int input_1 , int input_2)
        {
            int result = input_1 - input_2;
            return result;
        }
    }
}
