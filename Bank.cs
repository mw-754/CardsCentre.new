namespace CardsCenter;
public class Bank
{
    private List<KlientBanku> listaKlientow;

    public Bank()
    {
        listaKlientow = new List<KlientBanku>();
    }
    
    public void DodajKlienta(KlientBanku klient)
    {
        listaKlientow.Add(klient);
    }

    public void UsunKlienta(KlientBanku klient)
    {
        listaKlientow.Remove(klient);
    }
    
    public List<KlientBanku> GetKlienci()
    {
        return listaKlientow;
    }
    
}