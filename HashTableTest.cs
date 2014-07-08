using System;
using System.Collections;
using System.Collections.Generic;

namespace MyCLIApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            table.Add("taro","taro@yamada.com");
            table.Add("hanako","hanako@flower.com");
            table.Add("tuyano","tuyano@syoda.com");
            table["tuyano"] = "syoda@tuyao.com";
            Console.WriteLine(table["tuyano"]);
            Console.WriteLine(table["hanako"]);
            Console.ReadKey(true);

            Dictionary<string,string> dict = new Dictionary<string,string>();
            dict.Add("taro","taro@yamada.com");
            dict.Add("hanako","hanako@flower.com");
            dict.Add("tuyano","tuyano@syoda.com");
            dict["tuyano"] = "syoda@tuyao.com";
            Console.WriteLine(dict["tuyano"]);
            Console.WriteLine(dict["hanako"]);
            Console.ReadKey(true);

        }
    }
}