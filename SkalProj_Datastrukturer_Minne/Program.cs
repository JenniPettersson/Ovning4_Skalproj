using System;
using System.Collections.Generic;
using System.Linq;


namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        /// 
        /// Question 1.
        /// The stack is like loading a ferry with vehicles. Some spots are for trucks, some for motor bikes, some for cars, etcetera. You can't unload a truck that
        /// is third in line unless you first unload the first and the second truck, in that order
        /// Question 2.
        /// Reference types belong to System.Object (object, string, class, ...) and are always stored in the heap. Value Types are values like integers, floats and structs (15 in total).
        /// They are stored depending on how they are used. If they are used in a method, they are stores in the stack. If they are used in a class, they are stored in the heap.
        /// Question 3.
        /// ReturnValue() returns 3 becase return x means the result is gathered from x = 3;. y = x will point y to x, i.e. 3. But then we say that y points to 4. x is never affected.
        /// Everything is stored in the stack and are purged when done
        /// ReturnValue2() returns 4 because of y = x. y instance points to x instance and when we tell y to put value 4 in MyValue it overwrites the old x.MyValue. Hence x.MyValue = 4
        /// Everything is stored in the stack and are purged when done


        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}

            //Task 1 done
            //Question 2: When Count is equal to Capacity, the internal array reallocates. For example when capacity is 4 and a fifth item is added, the first four items are copied
            //to a new array with capacity 8 and then the fifth item is added
            //Question 3: The array is doubling every time it increases, at 4, 9, 16, 32...
            //Question 4: Because if we would reallocate for every (Capacity + 1), we would have hundreds of thousands of abandoned arrays in memory if we filled a list with one million items
            //Question 5: No, the array does not reallocate to a new array with capacity 4 when we remove the fifth item. We are still in the internal array with Capacity 8
            //Question 6: When you have a large number of items and you want to use as little memory as possible. You can remove Capacity with TrimExcess method and you can decide the size of
            //the internal array by setting the Capacity from the start, that way less reallocation is necessary


            List<string> ourList = new List<string>()
            {
                "Example",
                "Example2",
                "Example3",
                "Example4",
                "Example5",
                "Example6",
                "Example7"
            };

            while (true)
            {
                Console.WriteLine("Please enter data into an existing list. Any other input will retake you back to the main menu"
                + "\n+. Plus operator in front of input adds it to the list (Example: +Anna)"
                + "\n-. Minus operator in front of input adds it to the list (Example: -Johan)");

                //char input = ' '; //Creates the character input to be used with the switch-case below.

                /* try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                */

                string input = Console.ReadLine();
                char nav = input[0];

                switch (nav)
                {
                    case '+':
                        AddInputToListAndViewIt(input, ourList);
                        break;
                    case '-':
                        RemoveInputFromListAndViewIt(input, ourList);
                        break;
                    default:
                        Console.WriteLine("Please use only + or -");
                        break;
                }
            }

        }

        private static void AddInputToListAndViewIt(string input, List<string> ourList)
        {
            string value = input.Substring(1);
            ourList.Add(value);
            Console.WriteLine($"List contains {ourList.Count} items as follows:");
            ourList.ForEach(item => Console.WriteLine(item));
            Console.WriteLine($"List capacity is: {ourList.Capacity}");
        }

        private static void RemoveInputFromListAndViewIt(string input, List<string> ourList)
        {
            //string value = input.Substring(1);
            ourList.Remove(input.Substring(1));
            Console.WriteLine($"List contains {ourList.Count} items as follows:");
            ourList.ForEach(item => Console.WriteLine(item));
            Console.WriteLine($"List capacity is: {ourList.Capacity}");
        }


        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            TestQueue();

        }


            /// <summary>
            /// Examines the datastructure Stack
            /// </summary>
            static void ExamineStack()
            {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            /*while (true)
            {
                Console.WriteLine("Please queu and dequeu people waiting in line at the Ica cash register"
                + "\nQ. Queue (push) a person last in line"
                + "\nD. Dequeue (pop) the person first in line when they have payed and leave the queue");

                string input = Console.ReadLine();
                char nav = input[0];

                switch (nav)
                {
                    case 'Q':
                        Method();
                        break;
                    case 'D':
                        Method();
                        break;
                    default:
                        Console.WriteLine("Please queue or dequeu people");
                        break;
                }
            }*/

        }

        static void CheckParanthesis()
            {
                /*
                 * Use this method to check if the paranthesis in a string is Correct or incorrect.
                 * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
                 * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
                 */

            }

        }
    }

