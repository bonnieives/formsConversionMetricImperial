using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Code made by Bonnie Ives de Castro Nunes
// College LaSalle - 2023-02-28

namespace OOP20230228_section2
{
    // declaring the class
    internal class ConvertArea
    {
        // declaring the internal variables
        private double number1;
        private double result;

        // starting the properties
        public double Number1
        {
            get { return number1; }
            set { number1 = value; }
        }
        public double Result
        {
            get { return result; }
            set { result = value; }
        }

        // setting the constructors
        public ConvertArea()
        {
            this.Number1 = number1;
            this.Result = result;
        }
        public ConvertArea(double number1)
        {
            this.Number1 = 0;
        }
        // Creating the methods
        public double ToSquareInches ()
        {
            result = Number1 * 0.1550;
            return result;
        }
        public double ToSquareYards () 
        {
            result = Number1 * 1.960;
            return result;
        }
        public double ToAcre ()
        {
            result = Number1 * 2.4711;
            return result;
        }
        public double ToSquareMiles () 
        {
            result = Number1 * 0.3861;
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring the object
            ConvertArea number;
            // Instantiating the object
            number = new ConvertArea();
            // Declaring the option as a character
            char option;
            // Starting the loop
            do
            {
                // Showing the options
                Console.WriteLine("\n---------- Area Conversion ----------");
                Console.WriteLine("\t(1) From square cm to square in. ");
                Console.WriteLine("\t(2) From square m to square yd. ");
                Console.WriteLine("\t(3) From ha cm to acres. ");
                Console.WriteLine("\t(4) From square km to square mi. ");
                Console.WriteLine("\t(5) Quit.");
                here1:
                // First try catch to check the conversion of the character of option
                try
                {
                    Console.WriteLine("\nInform the option: ");
                    option = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception exp1)
                {
                    Console.WriteLine(exp1.Message);
                    Console.WriteLine("Please try again using onle one character.\n");
                    goto here1;
                }
                // Using the switch case to execute the options
                switch (option)
                {
                    // Converting to square inches
                    case '1':
                        {
                            Console.WriteLine("\nPlease inform the number to convert:");
                            here2:
                            try
                            {
                                number.Number1 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("{0} sq cm -> {1} sq in.", number.Number1, number.ToSquareInches());

                            }
                            catch (Exception exp2)
                            {
                                Console.WriteLine(exp2.Message);
                                Console.WriteLine("Please use the apropriate format.");
                                goto here2;
                            }
                            break;
                        }
                    case '2':
                        {
                            here3:
                            Console.WriteLine("\nPlease inform the number to convert:");
                            try
                            {
                                number.Number1 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("{0} sq m -> {1} sq yd.", number.Number1, number.ToSquareYards());

                            }
                            catch (Exception exp2)
                            {
                                Console.WriteLine(exp2.Message);
                                Console.WriteLine("Please use the apropriate format.");
                                goto here3;
                            }
                            break;
                        }
                    case '3':
                        {
                        here4:
                            Console.WriteLine("\nPlease inform the number to convert:");
                            try
                            {
                                number.Number1 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("{0} hectare -> {1} acre.", number.Number1, number.ToAcre());

                            }
                            catch (Exception exp2)
                            {
                                Console.WriteLine(exp2.Message);
                                Console.WriteLine("Please use the apropriate format.");
                                goto here4;
                            }
                            break;
                        }
                    case '4':
                        {
                        here5:
                            Console.WriteLine("\nPlease inform the number to convert:");
                            try
                            {
                                number.Number1 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("{0} sq km -> {1} sq mi.", number.Number1, number.ToSquareMiles());

                            }
                            catch (Exception exp2)
                            {
                                Console.WriteLine(exp2.Message);
                                Console.WriteLine("Please use the apropriate format.");
                                goto here5;
                            }
                            break;
                        }
                    case '5':
                        {
                            Console.WriteLine("\nYou exited the application.");
                            break;
                        }
                }                
            }
            while (option != '5');
            Console.WriteLine("\nThank you for using the application.");
            Console.WriteLine("Press enter to terminate.");
            Console.ReadKey();
        }
    }
    /*
---------- Area Conversion ----------
        (1) From square cm to square in.
        (2) From square m to square yd.
        (3) From ha cm to acres.
        (4) From square km to square mi.
        (5) Quit.

Inform the option:
1

Please inform the number to convert:
10
10 sq cm -> 1.55 sq in.

---------- Area Conversion ----------
        (1) From square cm to square in.
        (2) From square m to square yd.
        (3) From ha cm to acres.
        (4) From square km to square mi.
        (5) Quit.

Inform the option:
2

Please inform the number to convert:
20
20 sq m -> 39.2 sq yd.

---------- Area Conversion ----------
        (1) From square cm to square in.
        (2) From square m to square yd.
        (3) From ha cm to acres.
        (4) From square km to square mi.
        (5) Quit.

Inform the option:
3

Please inform the number to convert:
30
30 hectare -> 74.133 acre.

---------- Area Conversion ----------
        (1) From square cm to square in.
        (2) From square m to square yd.
        (3) From ha cm to acres.
        (4) From square km to square mi.
        (5) Quit.

Inform the option:
4

Please inform the number to convert:
40
40 sq km -> 15.444 sq mi.

---------- Area Conversion ----------
        (1) From square cm to square in.
        (2) From square m to square yd.
        (3) From ha cm to acres.
        (4) From square km to square mi.
        (5) Quit.

Inform the option:
5

You exited the application.

Thank you for using the application.
Press enter to terminate. */

}
