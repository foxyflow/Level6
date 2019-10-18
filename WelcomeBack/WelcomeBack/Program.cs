using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeBack
{
    class Program
    {

        //Question 1
        static string Question1(string name)
        {
            return $"hello " + name;
        }

        //Question2
        static int Question2(int a, int b)
        {         
           return a + b;
        }

        //Question3
        static float Question3(float answer)
        {
            return 50 / 3;
        }
        //Question3: using an int
        static int Question3b(int answer2)
        {
            return  50 / 3  ;

        }
        static void Main(string[] args)
        {
            int a = 74;
            int b = 36;
            float c = 3.6f;
            int d = 0;
            Console.WriteLine(Question1("luike"));

           Console.WriteLine( Question2(a, b));

            Console.WriteLine(Question3(c));

            Console.WriteLine(Question3b(d));



            Console.ReadLine();
        }

       
       
    
    }
        

        

        
    
}
