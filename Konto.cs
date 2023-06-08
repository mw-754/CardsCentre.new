namespace CardsCenter;

public class Konto
{
    private String nrKonta;
    private double saldo;
    private Random rnk = new Random();

    public Konto()
    {
        nrKonta = rnk.Next().ToString();
    }

    public Konto(String nrkonta)
    {
        nrKonta = nrkonta;
    }

    public double GetSaldo()
    {
        return saldo;
    }

    public String GetNrKonta()
    {
        return nrKonta;
    }

    void Wyplac(double kwota)
    {
        if (kwota <= saldo)
        {
            Console.WriteLine("Kwota "+kwota+" zostala wyplacona.");
            saldo -= kwota;
        }
        else if (kwota > saldo)
        {
            Console.WriteLine("Na koncie nie ma takiej kwoty, saldo wynisi "+saldo);
        }
        else
        {
            Console.WriteLine("Niepoprawna kwota!");
        }
    }

    public void Wplac(double kwota)
    {
        if (kwota >= 0)
        {
            saldo += kwota;
            Console.WriteLine("Kwota "+kwota+" zostala wplacona, saldo konta wynosi "+saldo);
        }
        else
        {
            Console.WriteLine("Niepoprawna kwota!");
        }
    }
}