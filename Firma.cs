namespace CardsCenter;

public class Firma : KlientCentrum
{
    private string nazwa;
    private string KRS;

    public Firma(string nazwa, string KRS) : base()
    {
        this.nazwa = nazwa;
        this.KRS = KRS;
    }
}
