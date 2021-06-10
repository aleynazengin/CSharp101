namespace CalismaOOP
{
    public class Focus: IOtomobil{
        public Marka HangiMarkanınAracı()
        {
            return Marka.Ford;
        }
        public Renk StandartRengiNe(){
            return Renk.Beyaz;
        }
        public int KacTekerlektenOlusur(){
            return 4;
        }

    }
}