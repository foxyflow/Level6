using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbleSort
{
    public class Program
    {
      //  Create an application which has an array to hold 1,000,000 numbers and include the following 3 methods:

   // Populate - This method accepts an array as a parameter and populates it with random numbers
   // StandardBubbleSort - This method accepts the populated array and implements the standard bubble sort algorithm to sort it into ascending order
   // ImprovedBubbleSort - This method accepts the populated array and implement the modified / improved bubble sort algorithm

//Once you have implemented the necessary methods, add the diagnostics timer into your code and time how long it takes to sort the data using both of your sorting methods.Which was faster?
//Note: Remember to make copies of your data before you sort it.

        public static void Main()
        {
            // int[] nums = { 10, 5, 32, 7, 47, 9, 56, 6, 22, 8};
            int max = 1000000;

            // this declares an integer array with 5 elements
            // and initializes all of them to their default value
            // which is zero
            int[] million = new int[max];

            Random randNum = new Random();
            for (int i = 0; i < million.Length; i++)
            {
                million[i] = randNum.Next(100);
            }
            Display(million);

            million = BubbleSort(million);
            Console.WriteLine("*********** Bubble Sort Numbers***********");
            Display(million);

            

            Console.ReadLine();
        }

        /*Basic bubble sort algorithm*/
        static int[] BubbleSort(int[] arr)
        {
            /*External loop makes sure we check all of array*/
            for (int i = 0; i < arr.Length - 1; i++)
            {
                /*Internal loop goes through the elements and checks each one*/
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    /*If the current element is larger than the next element, swap them*/
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;

        }

        /*Display the array*/
        static void Display<T>(T[] arr)
        {
            foreach (T x in arr)
            {
                Console.Write(x + "  ");
            }
        }
        
    }
}
