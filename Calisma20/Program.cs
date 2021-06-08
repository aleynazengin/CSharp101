using System;

namespace Calisma20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
           // class  SinifAdi
           // {
                // [Erişim Belirleyici] [Veri Tipi] ÖzellikAdi;
                // [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
                //    {
                        // Metot Komutları
                //    }

           // }

           // Erişim Belirleyiciler
           // *Public
           // *Private
           // *Internal
           // *Protected

           Calisan calisan1= new Calisan();
           calisan1.Ad= "Ayşe";
           calisan1.Soyad= "Kara";
           calisan1.No= 23435634;
           calisan1.Departman= "İnsan Kaynakları";
           calisan1.CalisanBilgileri();
           Console.WriteLine("**************");

           Calisan calisan2= new Calisan();
           calisan2.Ad= "Deniz";
           calisan2.Soyad= "Arda";
           calisan2.No= 25646789;
           calisan2.Departman= "Satın Alma";
           calisan2.CalisanBilgileri();
          
        }
    }

    class Calisan{
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri(){
            Console.WriteLine("Çalışanın Adı:{0}", Ad);
            Console.WriteLine("Çalışanın Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışanın Numarası:{0}", No);
            Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
        }
        
    }
}
