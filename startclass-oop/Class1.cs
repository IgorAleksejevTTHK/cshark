using System;

namespace TARpv24_Ckeel
{
    public abstract class Inimene
    {
        public string Nimi;
        public int Vanus;
        public Inimene()
        {

        }


        public Inimene(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }
        
          
        public void Tervita()
        {
            Console.WriteLine($"Tere, minu nimi on {Nimi} ja ma olen {Vanus} aastat vana.");
        }
        public abstract void Mida_teeb();
    }
}