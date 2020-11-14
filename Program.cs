using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            //This is asking the user for a number between 1 and 12
            Console.WriteLine("Please enter a number between 1 - 12");

            int number = Convert.ToInt32( Console.ReadLine());
             
            if (number >= 1 && number <= 12)
            {
                switch (number)
                {

                    case 1:
                        Console.WriteLine("January");
                        break;
                    case 2:
                        Console.WriteLine("Febuary");
                        break;
                    case 3:
                        Console.WriteLine("March");
                        break;
                    case 4:
                        Console.WriteLine("April");
                        break;
                    case 5:
                        Console.WriteLine("May");
                        break;
                    case 6:
                        Console.WriteLine("June");
                        break;
                    case 7:
                        Console.WriteLine("July");
                        break;
                    case 8:
                        Console.WriteLine("August");
                        break;
                    case 9:
                        Console.WriteLine("September");
                        break;
                    case 10:
                        Console.WriteLine("October");
                        break;
                    case 11:
                        Console.WriteLine("November");
                        break;
                    case 12:
                        Console.WriteLine("December");
                        break;

                }

            }

            else
            {
                Console.WriteLine("Sorry please pick a number between 1 - 12.");
            }





            Console.ReadLine();
        }
    }
}
