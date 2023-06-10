namespace CardsCenter;
public class Osoba : KlientBanku
{
    protected string imie, nazwisko, PESEL;

    public Osoba(string imie1, string nazwisko1, string PESEL1)
    {
        imie = imie1;
        nazwisko = nazwisko1;
        PESEL = PESEL1;
    }
    
}