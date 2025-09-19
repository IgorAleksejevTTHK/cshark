public class Jalgratas : ISõiduk
{
    double km;

    public Jalgratas(double läbitudKm)
    {
        km = läbitudKm;
    }

    public double ArvutaKulu()
    {
        return 0;
    }

    public double ArvutaVahemaa()
    {
        return km;
    }
}

