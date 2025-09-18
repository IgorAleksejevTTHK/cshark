using System;

namespace TARpv24_Ckeel
{
    public class StartClassOOP
    {
        public void Main(string[] args)
        {
           Inimene inimene1 = new Inimene();
            inimene1.Nimi="Juku";
            inimene1.Vanus= 12;
            inimene1.Tervita();

            Inimene inimene2 = new Inimene("Mari", 30);

            Töötaja töötaja1 = new Töötaja();
            töötaja1.Nimi = "mati";
            töötaja1.Vanus = 45;
            töötaja1.Ametikoht = "arhitekt";
            töötaja1.Tervita();
            töötaja1.Töötan();

            Gender gender1 = new Gender();
            gender1.GenderSex = "mees";
            gender1.Nimi = "Juku";
            gender1.Vanus = 12;
            gender1.Tervita();
            gender1.GenderReveal();
        }






    }


}