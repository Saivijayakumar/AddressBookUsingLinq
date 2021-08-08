using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address Book System using linq");
            ContactDataManager manager = new ContactDataManager();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("1.Create Data and Display Data Table");
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("Enter Your Choice:");
            switch (Console.ReadLine())
            {
                case "1":
                    manager.AddValues();
                    manager.Display();
                    break;
                default:
                    Console.WriteLine("Enter Valid Option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
