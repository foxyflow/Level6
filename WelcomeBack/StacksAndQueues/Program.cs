using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();

            myStack.Push("Bottom");
            myStack.Push("This is my");
            myStack.Push("stringy");
            myStack.Push("Top");

            Console.WriteLine(myStack.Count);
            Console.WriteLine($"Popping off the top (return and remove(): Output: {myStack.Pop()}");
            Console.WriteLine($"having a peek at the top: OutPut: {myStack.Peek()}");
            Console.WriteLine($"count property = {myStack.Count}");

            PrintValues(myStack);

            Console.WriteLine("**************Stack^***************Queue (below)*************");

            Queue myQ = new Queue();
            myQ.Enqueue(1);
            myQ.Enqueue("anotherStringy");
            myQ.Enqueue(true);

            PrintValues(myQ);
            myQ.Dequeue();
            Console.WriteLine(myQ.Peek());

            //Queue Q1: Create an application that uses a loop to populate a queue with names, then display those names back to the user.
            Queue queue2 = new Queue();
            while (true)
            {


               

                Console.WriteLine("Please enter a name to add to the queue");
                queue2.Enqueue(Console.ReadLine());
                Console.WriteLine("Would you like to add another name (y/n):");
                if (Console.ReadLine().ToLower() == "n")

                    break;

            }
            queue2.Enqueue("Abbi");
            queue2.Enqueue("Ben");
            queue2.Enqueue("ChocolateMan");

            Console.WriteLine($"{queue2.Count}");

            int counter = queue2.Count; //displaying the names
            
            for (int i = 0; i < counter; i++)         
            {
                Console.WriteLine($"Name: {queue2.Dequeue()}");
            }


            //Question2
           // use. contains (it's a boolean)

            //use sort method.

            // Question2 Extend the previous application to provide the functionality to search if a user input name is contained in the queue.

            // if (string tryParse.Console.ReadLine())








            /* Extend your app so that the queue is organised in alphabetical order. 
             * Prove this by making a copy of the queue and dequeueing the entire copy using a loop and displaying it to the screen.
               Hint: Think about the methods and other collections methods.*/




            Console.ReadLine();
        }
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }

        //Do the execises:

       //List l1 = new List() -- way longer (time it) becaseu no arrow breackets to narrow it down to eg <string>
        //hash table is a dictionary -- contains key value pairs
       // anything in the arrow brackets <string> has to be that data type ;-- oppisite to enum which takes all data types like var

        //uses key
        


    }
}
