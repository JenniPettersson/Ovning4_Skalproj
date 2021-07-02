using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SkalProj_Datastrukturer_Minne
{
    public class Queue
    {
        public static void TestQueue()
        {
            Queue<string> icaQueue = new Queue<string>();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Please queue and dequeue people waiting in line at the Ica cash register"
                + "\nQ. Queue (push) a customer last in line"
                + "\nD. Dequeue (pop) customer first in line as thwy have payed and leave queue"
                + "\nE. Exit and go back to main menu");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "Q":
                    case "q":
                        NewCustomerLastIn(icaQueue);
                        break;
                    case "D":
                    case "d":
                        FirstCustomerLeaves(icaQueue);
                        break;
                    case "E":
                    case "e":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\n");
                        break;
                }
            }
        }

        public static void NewCustomerLastIn(Queue<string> icaQueue)
        {
            Console.WriteLine("Name of new customer?");
            string newCustomer = Console.ReadLine();
            icaQueue.Enqueue(newCustomer);
            Console.Write($"{icaQueue.Count} customers in queue: \n");
            //icaQueue.ForEach(item => Console.WriteLine(item));
            foreach (var customer in icaQueue)
            {
                //int queueNumber = customer.ElementAt((customer.Count) - 1);
                Console.WriteLine(customer);
            }
        }


        public static void FirstCustomerLeaves(Queue<string> icaQueue)
        {
            Console.Write($"{icaQueue.Count} customers in queue: \n");
            //icaQueue.ForEach(item => Console.WriteLine(item));
            foreach (var customer in icaQueue)
            {
                Console.WriteLine(customer);
            }
            
            Console.WriteLine("Remove customer first in line (Y/N)?");

            string answer = Console.ReadLine();

            //if (answer = "Y") => icaQueue?.Dequeue() ?? Console.WriteLine("Queue is empty, please add customer(s) first");
            //else(answer = "N") => break;
        }
    }
}