using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progam
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int operate;
            var operation1 = new calculator();
            Console.WriteLine("Enter first number");
            var num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            var num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1 is addition");
            Console.WriteLine("2 substraction");
            Console.WriteLine("3 is multiplication");
            Console.WriteLine("4 division");


            Console.WriteLine("enter your operation");
            operate =Convert.ToInt32( Console.ReadLine());

           
            {
               

                if (operate == 1)
                {

                    Console.WriteLine( "the sum is {0},", operation1.Add(num1,num2));
                    Console.ReadKey();
                }
                else if (operate == 2)
                {
                 Console.WriteLine("substraction is {0} ", operation1.Subtract(num1, num2));
                    Console.ReadKey();

                }
                else if (operate == 3)
                {
                    Console.WriteLine("multiplication is {0} ", operation1.Multiply(num1, num2));
                    Console.ReadKey();
                }
                else if (operate == 4)
                {
                    Console.WriteLine( "division is {0}",operation1.Divide(num1, num2));
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("invalid choice");
                    Console.ReadLine();
                }
            }
        }

    }
}

            

   
