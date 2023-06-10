namespace CardsCenter;

public class Kredytowa:Karta
{
    protected double dlug, limit;

    public Kredytowa(String nrkarty, double lim) : base(nrKarty)
    {
        dlug = 0;
        limit = lim;
    }

    public override String GetNrKarty()
    {
        return nrKarty;
    }

    public override double GetLimit()
    {
        return limit;
    }
    
    public override double GetSaldoKarty()
    {
        return dlug;
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