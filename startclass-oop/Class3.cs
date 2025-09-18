using System;

namespace TARpv24_Ckeel
{
    public class Töötaja : Inimene
    {
        public string Ametikoht = "Keevitaja";

        public void Töötan()
        {
            Console.WriteLine($"{Nimi} töötab ametikohal {Ametikoht}.");
        }
        public override void Mida_teeb()
        {
            Console.WriteLine("Töötaja töötab.");
        }
    }
}