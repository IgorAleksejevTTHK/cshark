public class Buss : ISõiduk
{
    double fuelPer100km;
    double distance;
    int passengers;

    public Buss(double fuel, double km, int p)
    {
        fuelPer100km = fuel;
        distance = km;
        passengers = p;
    }

    // Tagastame kulu ühest reisijast
    public double ArvutaKulu()
    {
        double total = fuelPer100km / 100 * distance;
        if (passengers > 0)
        {
            return total / passengers;
        }
        return total; // kui reisijaid pole, tagastame kogu kulu
    }



    public double ArvutaVahemaa()
    {
        return distance;
    }
}