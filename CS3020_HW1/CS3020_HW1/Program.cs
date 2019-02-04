using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3020_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuChoice = 0;
            while (menuChoice != 5)
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Enter the following to perform an action.");
                Console.WriteLine("1. Convert Farenheit to Celsius.");
                Console.WriteLine("2. Calculate volume of a sphere.");
                Console.WriteLine("3. Prints all values <= n that are multiples of 3 or 5.");
                Console.WriteLine("4. Check to see if string is palindrome.");
                Console.WriteLine("5. Exit the program.");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("\nPlease enter an input:");
                menuChoice = int.Parse(Console.ReadLine());
                switch (menuChoice)
                {
                    case 1:
                        FahrenheitToCelsius();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 2:
                        SphereVolume();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 3:
                        MultiplesOf3And5();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 4:
                        IsPalindrome();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Thank you for using this program. Exiting...");
        }

        static void FahrenheitToCelsius()
        {
            float celsius;
            Console.Write("Please enter a value (float) for fahrenheit:\n");
            float fahrenheit = float.Parse(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("{0} degrees fahrenheit is {1} degress celsius.", fahrenheit, celsius);
        }

        static void SphereVolume()
        {
            double r, volume;
            double PI = 3.14159265359;
            Console.WriteLine("Please enter the radius (float) of your sphere:");
            r = Convert.ToDouble(Console.ReadLine());
            volume = (4.0 / 3) * PI * r * r * r;
            Console.WriteLine("Your sphere's volume is {0}", volume);
        }

        static void MultiplesOf3And5()
        {
            int num = 0;
            Console.WriteLine("Please enter a maximum value (integer) to check for multiples:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Printing multiples of 3 or 5:");
            for (int i = 0; i <= num; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    Console.WriteLine("{0}", i);
            }
            Console.WriteLine("Printing completed...");
        }

        static void IsPalindrome()
        {
            String str;
            int i = 0;
            Console.WriteLine("Please enter a string to check if it is a palindrome or not:");
            str = Console.ReadLine();
            int j = str.Length - 1;
            while (i < j)
            {
                if (str[i] != str[j])
                {
                    Console.WriteLine("{0} is not a palindrome.", str);
                    return;
                }
                i++;
                j--;
            }
            Console.WriteLine("{0} is a palindrome.", str);
        }
    }
}
