using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Vali sõiduk: auto, jalgratas või buss");
        string tüüp = Console.ReadLine().ToLower();

        if (tüüp == "auto")
        {
            Console.Write("Sisesta kütusekulu: ");
            double kulu = double.Parse(Console.ReadLine());
            Console.Write("Sisesta läbitud kilomeetrid: ");
            double km = double.Parse(Console.ReadLine());

            Auto auto = new Auto(kulu, km);
            Console.WriteLine("Auto:");
            Console.WriteLine("Kulu = " + auto.ArvutaKulu());
            Console.WriteLine("Läbitud km = " + auto.ArvutaVahemaa());
        }
        else if (tüüp == "jalgratas")
        {
            Console.Write("Sisesta läbitud kilomeetrid: ");
            double km = double.Parse(Console.ReadLine());

            Jalgratas jalgratas = new Jalgratas(km);
            Console.WriteLine("Jalgratas:");
            Console.WriteLine("Kulu = " + jalgratas.ArvutaKulu());
            Console.WriteLine("Läbitud km = " + jalgratas.ArvutaVahemaa());
        }
        else if (tüüp == "buss")
        {
            Console.Write("Sisesta kütusekulu: ");
            double kulu = double.Parse(Console.ReadLine());
            Console.Write("Sisesta läbitud kilomeetrid: ");
            double km = double.Parse(Console.ReadLine());
            Console.Write("Sisesta reisijate arv: ");
            int reisijad = int.Parse(Console.ReadLine());
            Buss buss = new Buss(kulu, km, reisijad);
            Console.WriteLine("Buss:");
            Console.WriteLine("Kulu inimese kohta = " + buss.ArvutaKulu());
            Console.WriteLine("Läbitud km = " + buss.ArvutaVahemaa());
        }
        else
        {
            Console.WriteLine("Tundmatu sõidukitüüp.");
        }
    }
}

