namespace CardsCenter;

public class Bank
{
    private List<KlientBanku> listaklientow;

    public Bank()
    {
        listaklientow = new List<KlientBanku>();
    }
    public void DodajKlienta(KlientBanku klient)
    {
        listaklientow.Add(klient);
    }

    public void UsunKlienta(KlientBanku klient)
    {
        listaklientow.Remove(klient);
    }
}
