namespace CalismaOOP
{
    public class Civic: IOtomobil{
        public Marka HangiMarkanınAracı()
        {
            return Marka.Honda;
        }
        public Renk StandartRengiNe(){
            return Renk.Gri;
        }
        public int KacTekerlektenOlusur(){
            return 4;
        }

    }
}