using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the To Do List Program");
            List<string> taskList = new List<string>();
            string option = "";

            while (option != "e")
            {
                Console.WriteLine("Enter a to Add to the list");
                Console.WriteLine("Enter r to Remove from the list");
                Console.WriteLine("Enter v to View the list ");
                Console.WriteLine("Enter e to Exit  the program");

                option = Console.ReadLine();

                if (option == "a")
                {
                    Console.WriteLine("Please enter the name of the task you want to do");
                    string tast = Console.ReadLine();
                    taskList.Add(tast);
                    Console.WriteLine("Task added to the list");

                }

                else if (option == "r")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + ":" + taskList[i]);
                    }
                    Console.WriteLine("Please enter the letter  your task remove the list");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(taskNumber);
                }

                else if (option == "v")
                {
                    Console.WriteLine("Current task in this list:");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(taskList[i]);
                    }
                }

                else if (option == "e")
                {
                    Console.WriteLine("Exiting program");
                }

                else 
                {
                    Console.WriteLine("Invalid letter try again.");
                }
                
            }
            Console.WriteLine("Thank you for using the program!");

        }

    }
}
