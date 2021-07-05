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
                        Console.WriteLine("Choose your action in the menu\n");
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
                int queueNumber = (1 + icaQueue.ToArray().ToList().IndexOf(customer));
                Console.WriteLine($"Customer number {queueNumber}: {customer}");
            }
        }


        public static void FirstCustomerLeaves(Queue<string> icaQueue)
        {
            Console.Write($"{icaQueue.Count} customers in queue: \n");
            //icaQueue.ForEach(item => Console.WriteLine(item));
            foreach (var customer in icaQueue)
            {
                int queueNumber = (1 + icaQueue.ToArray().ToList().IndexOf(customer));
                Console.WriteLine($"Customer number {queueNumber}: {customer}");
            }

            if (icaQueue.Count > 0)
            {
                icaQueue.Dequeue();
                Console.Write($"{icaQueue.Count} customers in queue: \n");
                //icaQueue.ForEach(item => Console.WriteLine(item));
                foreach (var customer in icaQueue)
                {
                    int queueNumber = (1 + icaQueue.ToArray().ToList().IndexOf(customer));
                    Console.WriteLine($"Customer number {queueNumber}: {customer}");
                }
            }
            else if (icaQueue.Count == 0)
            {
                Console.WriteLine("Queue is empty!");
            }
        }
    }
}
