namespace CardsCenter;

public abstract class KlientBanku
{
    private List<Konto> listakont;
    
    public KlientBanku()
    {
        listakont = new List<Konto>();
    }

    public void DodajKonto(Konto konto)
    {
        listakont.Add(konto);
    }
    
    public void UsunKonto(Konto konto)
    {
        listakont.Remove(konto);
    }
    
    public List<Konto> GetKonta()
    {
        return listakont;
    }
}