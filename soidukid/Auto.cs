public class Auto : ISõiduk
{
    double kulu100km;
    double km;

    public Auto(double kulu, double läbitudKm)
    {
        kulu100km = kulu;
        km = läbitudKm;
    }

    public double ArvutaKulu()
    {
        return (kulu100km / 100.0) * km; //kulu 100km/l
    }

    public double ArvutaVahemaa()
    {
        return km;
    }
}