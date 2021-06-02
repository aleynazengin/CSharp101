using System;

namespace Calisma12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //erisim_belirteci geri_donustipi metot_Adi(parametreListesi/arguman)
            //{
                //komutlar 
                //return;
            //}
            int a =2;
            int b=3;
            Console.WriteLine(a+b);

            int sonuc = Topla(ref a,ref b); // ref yazdığımızda orjinal yerinde,bellekte değişiklik yapıyor
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttırveTopla(a,b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));
        }
        static int Topla( ref int deger1, ref int deger2){
            return (deger1+deger2);
        }
    }
    class Metotlar {

        public void EkranaYazdir(string veri){
            Console.WriteLine(veri);
        }
        public int ArttırveTopla(int deger1,int deger2){
            deger1+=1;
            deger2+=1;
            return (deger1+deger2);
        }
    }
}
