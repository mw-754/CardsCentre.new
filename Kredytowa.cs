namespace CardsCenter;

public class Kredytowa:Karta
{
    protected double dlug, limit;

    public Kredytowa(String nrkarty) : base(nrKarty)
    {
        dlug = 0;
    }

    public override String GetNrKarty()
    {
        return nrKarty;
    }

    public override double GetLimit()
    {
        return limit;
    }

    public override void WyplacZKarty(double kwota)
    {
        if (kwota <= limit)
        {
            Console.WriteLine("Kwota "+kwota+" zostala wyplacona, dlug wynosi "+dlug);
            dlug -= kwota;
        }
        else if (kwota > limit)
        {
            Console.WriteLine("Limit został przekroczony mozesz wyplacic max : "+limit);
        }
        else
        {
            Console.WriteLine("Niepoprawna kwota!");
        }
    }

    public override void WplacNaKarte(double kwota){}
}