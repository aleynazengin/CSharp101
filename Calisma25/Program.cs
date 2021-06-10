using System;

namespace Calisma25
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            //dikdortgen.KisaKenar=3;
            //dikdortgen.UzunKenar=4;
            Console.WriteLine("Class Alan Hesabı :{0}",dikdortgen.AlanHesapla());

            Dikdortgen_Struct dikdortgen_Struct;
            dikdortgen_Struct.KisaKenar=3;
            dikdortgen_Struct.UzunKenar=4;
            Console.WriteLine("Class Alan Hesabı :{0}",dikdortgen_Struct.AlanHesapla());
        }
    }

    class Dikdortgen{
        public int KisaKenar;
        public int UzunKenar;
        //public Dikdortgen(){
        //    KisaKenar=3;
        //    UzunKenar=4;
        //}
        public long AlanHesapla(){
            return this.KisaKenar*this.UzunKenar;
        }
    }
    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;
        public Dikdortgen_Struct(int kisakenar,int uzunkenar)
        {
            KisaKenar= kisakenar;
            UzunKenar= uzunkenar;
        }
        public long AlanHesapla(){
            return this.KisaKenar*this.UzunKenar;
        }

    }
}
