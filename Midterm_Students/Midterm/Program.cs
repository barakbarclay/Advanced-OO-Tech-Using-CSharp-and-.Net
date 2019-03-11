using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuSelection = 0;
            VendingMachine machine = new VendingMachine();
            do
            {
                Start:
                Console.WriteLine("Please enter an integer for the option you want to select:");
                Console.WriteLine("1. Print vending machine.");
                Console.WriteLine("2. List only healthy food and drink.");
                Console.WriteLine("3. List toy options for kids under 7.");
                Console.WriteLine("4. Exit Program");

                try
                {
                    menuSelection = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("You have entered an invalid input. Try Again.");
                    goto Start;
                }
                if (menuSelection < 1 || menuSelection > 4)
                {
                    Console.WriteLine("You have entered an invalid input. Try Again.");
                    goto Start;
                }

                List<VendingMachineOption> exclusions = new List<VendingMachineOption>();

                switch (menuSelection)
                {
                    case 1:
                        machine.PrintVendingMachine(new List<VendingMachineOption>());
                        break;
                    case 2:
                        exclusions = machine.Where(t => t is Consumable && t.CalorieCount > 100).ToList();
                        //foreach(VendingMachineOption o in machine)
                        //{
                        //    if (o is Food || o is Drink)
                        //    {
                        //        if ((o as Food)?.CalorieCount > 100 || (o as Drink)?.CalorieCount > 100)
                        //        {
                        //            exclusions.Add(o);
                        //        }
                        //    }
                        //    else
                        //    {
                        //        exclusions.Add(o);
                        //    }
                        //}
                        machine.PrintVendingMachine(exclusions);
                        break;
                    case 3:
                        exclusions = machine.Where(t => t is Toy && t.AgeRequirement >= 7).ToList();
                        //foreach (VendingMachineOption o in machine)
                        //{
                        //    if (o is NonElectronic || o is Electronic)
                        //    {
                        //        if ((o as NonElectronic)?.AgeRequirement >= 7 || (o as Electronic)?.AgeRequirement >= 7)
                        //        {
                        //            exclusions.Add(o);
                        //        }
                        //    }
                        //    else
                        //    {
                        //        exclusions.Add(o);
                        //    }
                        //}
                        machine.PrintVendingMachine(exclusions);
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using this program!");
                        break;
                }
            } while (menuSelection != 4);
        }

        static void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
