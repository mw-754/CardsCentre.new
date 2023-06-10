namespace CardsCenter;
public class Osoba : KlientBanku
{
    protected string imie, nazwisko, PESEL;

    public Osoba(string im, string nazw, string pesel)
    {
        imie = im;
        nazwisko = nazw;
        PESEL = pesel;
    }
    
}