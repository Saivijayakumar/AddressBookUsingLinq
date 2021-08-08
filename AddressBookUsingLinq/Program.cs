﻿using System;
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
            Console.WriteLine("1.Create Data and Display Data Table\n2.Edit Contact\n3.Delete Contact Using Name");
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("Enter Your Choice:");
            switch (Console.ReadLine())
            {
                case "1":
                    manager.AddValues();
                    manager.Display();
                    break;
                case "2":
                    string name = Console.ReadLine();
                    string columName = Console.ReadLine();
                    string value = Console.ReadLine();
                    if(manager.EditDataTableUsingName(name,columName,value))
                        Console.WriteLine("------------Update---------------");
                    else
                        Console.WriteLine("------------Not Update check the inputs---------------");
                    break;
                case "3":
                    Console.Write("Enter First Name To Delete:");
                    if (manager.DeleteContactUsingName(Console.ReadLine()))
                        Console.WriteLine("------------Deleted---------------");
                    else
                        Console.WriteLine("------------Not Deleted check the inputs---------------");
                    break;
                default:
                    Console.WriteLine("Enter Valid Option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
