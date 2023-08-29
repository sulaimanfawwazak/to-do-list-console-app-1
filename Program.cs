using System;
using System.Runtime.InteropServices;

namespace toToList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make an array of string
            List<string> taskList = new List<string>();

            // Option
            string option = "";

            // Opening
            Console.WriteLine("[+] Hey, traveler!");

            while(option != "d")
            {
                Console.WriteLine("\n[+] What favor can I do for you?");

                // Options
                Console.WriteLine("\tA. Add a task");
                Console.WriteLine("\tB. See current tasks");
                Console.WriteLine("\tC. Delete a task");
                Console.WriteLine("\tD. Exit");

                // Prompts for option
                Console.Write("\n> ");
                option = Console.ReadLine().ToLower(); // Turn into lowercase

                // Option A
                if (option == "a")
                {
                    Console.WriteLine("\n[+] What task do you want to conquer today?");

                    // Prompts for the task
                    Console.Write("> ");
                    string task = Console.ReadLine();

                    // Adding to the array
                    taskList.Add(task);
                    Console.WriteLine("Task added to the list!");
                }

                // Option B
                else if (option == "b")
                {
                    Console.WriteLine("\n=== Tasks to conquer ===");

                    // Displays the current tasks
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + taskList[i]);
                    }
                }

                // Option C
                else if (option == "c")
                {
                    Console.WriteLine("=== Select a task to delete ===");

                    // Displays the current tasks first
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine((i + 1 + ". " + taskList[i]));
                    }

                    // Prompts for the number of the task to be deleted
                    Console.Write("> ");
                    int taskNumber = Convert.ToInt32(Console.ReadLine()) - 1;

                    // Removing the task at a specific index
                    taskList.RemoveAt(taskNumber);
                }

                // Option D
                else if (option == "d")
                {
                    Console.WriteLine("Untill we meet again, traveler!");
                }

                // Unpredicted input
                else
                {
                    Console.WriteLine("You're talking nonsense, would you mind repeat it for me?");
                }
            }
        }
    }
}