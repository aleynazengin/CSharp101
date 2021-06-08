using System;

namespace Calisma15
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "dersimiz CSharp, Hoşgeldiniz!";

            //Length
            Console.WriteLine(degisken.Length);

            //ToUpper , ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degisken," Merhaba!"));

            //Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); //0,1,-1
            Console.WriteLine(String.Compare(degisken,degisken2,true)); //büyük küçük harf duyarsız
            Console.WriteLine(String.Compare(degisken,degisken2,false)); //büyük küçük harf duyarlı
            
            //Contains : true false döndürür
            Console.WriteLine(degisken.Contains(degisken2)); 
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Hoşgeldiniz!"));
       
            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS")); //C harfinin indexini verir
            Console.WriteLine(degisken.IndexOf("Aleyna")); //-1 gelir
            Console.WriteLine(degisken.LastIndexOf("i")); // son i nin indexini verir

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba! ")); // 0.indexe ekler

            //PadLeft, PadRight
            Console.WriteLine(degisken+ degisken2.PadLeft(30)); //2.değişkenin solundan 30 boşluk bırakır.
            Console.WriteLine(degisken+ degisken2.PadLeft(30,'*')); 
            Console.WriteLine(degisken.PadRight(50,'-')+ degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));

            
            
        }
    }
}
