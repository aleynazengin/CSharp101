using System;
using System.Collections.Generic;

namespace Calisma19
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanılar = new Dictionary<int, string>();

            kullanılar.Add(10,"Ayşe Yılmaz");
            kullanılar.Add(12,"Ahmet Yılmaz");
            kullanılar.Add(18,"Deniz Arda");
            kullanılar.Add(20,"Özcan Coşar");

            //Dizinin elemanlarına erişim
            Console.WriteLine("***** Elemanlara Erişim ******");
            Console.WriteLine(kullanılar[12]);
            foreach (var item in kullanılar)
                Console.WriteLine(item);
            
            //Count;
            Console.WriteLine("***** Count *****");
            Console.WriteLine(kullanılar.Count);

            //Contains
            Console.WriteLine("***** Contains *****");
            Console.WriteLine(kullanılar.ContainsKey(12));
            Console.WriteLine(kullanılar.ContainsValue("Aleyna Zengin"));
            
            //Remove
            Console.WriteLine("***** Remove *****");
            kullanılar.Remove(12);

            foreach (var item in kullanılar)
                Console.WriteLine(item);

            //Keys
            Console.WriteLine("***** Keys *****");
              foreach (var item in kullanılar.Keys)
                Console.WriteLine(item);

            //Values
            Console.WriteLine("***** Keys *****");
              foreach (var item in kullanılar.Values)
                Console.WriteLine(item);

            
        }
    }
}
