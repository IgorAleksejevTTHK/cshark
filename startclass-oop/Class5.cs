using System;

namespace TARpv24_Ckeel
{
    public class Gender : Inimene
    {
        public string GenderSex;

        public void GenderReveal()
        {
            Console.WriteLine($"Ma olen {GenderSex}");
        }
        public override void Mida_teeb()
        {
            // Provide an implementation for the abstract method
            Console.WriteLine("Gender class is doing something.");
        }
    }
}