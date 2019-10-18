using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;
using System.Diagnostics;


namespace projectJson //Using a web API
{
    class Program
    {
        static void Main(string[] args)
        {
            //Execise 1
            // string json = new WebClient().DownloadString("https://uinames.com/api/?amount=2");
            // Console.WriteLine(json);



            //using a web API
            Stopwatch st = new Stopwatch();
            st.Start();

            string json = new WebClient().DownloadString("http://uinames.com/api/?amount=50");

            List<CustomObject> data = new JavaScriptSerializer().Deserialize<List<CustomObject>>(json);

            st.Stop();

            Console.WriteLine($"Timer: {st.ElapsedMilliseconds}");



            foreach (CustomObject x in data)
            {
                Console.WriteLine("Name: {0} {1}\nGender: {2}\nRegion: {3}\n", x.name, x.surname, x.gender, x.region);
            }
            Console.WriteLine("Time to populate the list: {0}ms\n", st.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
    class CustomObject
    {
        public string name
        {
            get; set;
        }
        public string surname { get; set; }
        public string gender { get; set; }
        public string region { get; set; }
    }


    public class Rootobject
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string gender { get; set; }
        public string region { get; set; }
        public int age { get; set; }
        public string title { get; set; }
        public string phone { get; set; }
        public Birthday birthday { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Credit_Card credit_card { get; set; }
        public string photo { get; set; }
    }

    public class Birthday
    {
        public string dmy { get; set; }
        public string mdy { get; set; }
        public int raw { get; set; }
    }

    public class Credit_Card
    {
        public string expiration { get; set; }
        public string number { get; set; }
        public int pin { get; set; }
        public int security { get; set; }
    }


    //Execise 2







    public class MyMain
    {

        //step 1: pull json strings down
        string json = new WebClient().DownloadString("https://uinames.com/api/?amount=2");
        Console.WriteLine(json);
          //step2: make a list

          //make a class/s with all of the properties ^

         //for each loop


         //look at array.sort and list.sort

         //list dot.sort ... use a for each loop to filter what to sort.
         //eg male, female.
    }
}