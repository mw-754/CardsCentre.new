namespace CardsCenter;

public abstract class Karta
{
    protected static String nrKarty;
    protected Random nk = new Random();

    public Karta()
    {
        nrKarty = nk.Next().ToString();
    }

    public Karta(String nrk)
    {
        nrKarty = nrk;
    }

    public abstract String GetNrKarty();

    public abstract double GetLimit();

    public abstract void WyplacZKarty(double kwota);

    public abstract void WplacNaKarte(double kwota);
}    