using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SkalProj_Datastrukturer_Minne
{
    class Queue
    {
        public void TestQueue()
        {
            Queue<string> icaQueue = new Queue<string>();

            var exit = false;

            while (!exit)
            {
                Console.WriteLine("Please queue and dequeue people waiting in line at the Ica cash register"
                + "\nQ. Queue (push) a customer last in line"
                + "\nD. Dequeue (pop) customer first in line as thwy have payed and leave queue"
                + "\nE. Exit and go back to main menu");

                char input = Convert.ToChar(Console.Read());

                switch (input)
                {
                    case 'Q':
                        NewCustomerLastIn(icaQueue);
                        break;
                    case 'D':
                        FirstCustomerLeaves(icaQueue);
                        break;
                    case 'E':
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\n");
                        break;
                }
            }
        }

        public void NewCustomerLastIn(Queue<string> icaQueue)
        {
            Console.WriteLine("Name of new customer?");
            string newCustomer = Console.ReadLine();
            icaQueue.Enqueue(newCustomer);
            Console.Write($"{icaQueue.Count} customers in queue: ");
            //icaQueue.ForEach(item => Console.WriteLine(item));
            foreach (var customer in icaQueue)
            {
                Console.WriteLine(customer);
            }
        }


        public void FirstCustomerLeaves(Queue<string> icaQueue)
        {
            Console.Write($"{icaQueue.Count} customers in queue: ");
            //icaQueue.ForEach(item => Console.WriteLine(item));
            foreach (var customer in icaQueue)
            {
                Console.WriteLine(customer);
            }
            Console.WriteLine("Remove customer first in line (Y/N)?");
            string answer = Console.ReadLine();
            //if(Console.ReadLine = "Y") => icaQueue.Dequeue(); 
        }
    }
}