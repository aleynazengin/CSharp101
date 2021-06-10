namespace CalismaOOP
{
    public class Corolla: IOtomobil{
        public Marka HangiMarkanınAracı()
        {
            return Marka.Toyota;
        }
        public Renk StandartRengiNe(){
            return Renk.Beyaz;
        }
        public int KacTekerlektenOlusur(){
            return 4;
        }

    }
}