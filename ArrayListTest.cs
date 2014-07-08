using System;
using System.Collections;
using System.Collections.Generic;

namespace MyCLIApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList();
            arraylist.Add("One");
            arraylist.Add("Two");
            arraylist.Add("Three");
            arraylist[0] = "Zero";
            foreach(Object obj in arraylist){
                Console.WriteLine(obj);
            }
            Console.ReadKey(true);

            List<string> list = new List<string>();
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            list[0] = "Zero";
            foreach(String str in list){
                Console.WriteLine(str);
            }
            Console.ReadKey(true);
        }
    }
}