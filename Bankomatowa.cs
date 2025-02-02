﻿namespace CardsCenter;

public class Bankomatowa:Karta
{
    protected double saldoKarty, limit;
    public Bankomatowa(String nrkarty, double saldokarty) : base(nrKarty)
    {
        saldoKarty = saldokarty;
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
        return saldoKarty;
    }

    public override void WyplacZKarty(double kwota)
    {
        if (kwota <= limit)
        {
            Console.WriteLine("Kwota "+kwota+" zostala wyplacona.");
            saldoKarty -= kwota;
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

    public override void WplacNaKarte(double kwota)
    {
        if (kwota > 0)
        {
            saldoKarty += kwota;
            Console.WriteLine("Kwota " + kwota + " zostala wplacona, saldo karty wynosi " + saldoKarty);
        }
        else
        {
            Console.WriteLine("Niepoprawna kwota!");
        }
    }
}
