public class LoveCalculator
{
    public string GetResults(string Ime1, string Ime2)
    {
        return GetCount(Ime1, Ime2);
    }
    private string GetCount(string PrvoIme, string DrugoIme)
    {
        try
        {
            string prvo = PrvoIme.ToUpper();
            int prvaduljina = PrvoIme.Length;
            string drugo = DrugoIme.ToUpper();
            int drugaduljina = DrugoIme.Length;
            int LjubavniZbroj = 0;

            for (int Zbroj = 0; Zbroj < prvaduljina; Zbroj++)
            {
                string samoSlovo = prvo.Substring(Zbroj, 1);
                if (samoSlovo.Equals("A")) LjubavniZbroj += 2;
                if (samoSlovo.Equals("E")) LjubavniZbroj += 2;
                if (samoSlovo.Equals("I")) LjubavniZbroj += 2;
                if (samoSlovo.Equals("O")) LjubavniZbroj += 2;
                if (samoSlovo.Equals("U")) LjubavniZbroj += 3;
                if (samoSlovo.Equals("A")) LjubavniZbroj += 1;
                if (samoSlovo.Equals("E")) LjubavniZbroj += 3;
            }
            for (int Zbroj = 0; Zbroj < drugaduljina; Zbroj++)
            {
                string samoSlovo = drugo.Substring(Zbroj, 1);
                if (samoSlovo.Equals("A")) LjubavniZbroj += 2;
                if (samoSlovo.Equals("E")) LjubavniZbroj += 2;
                if (samoSlovo.Equals("I")) LjubavniZbroj += 2;
                if (samoSlovo.Equals("O")) LjubavniZbroj += 2;
                if (samoSlovo.Equals("U")) LjubavniZbroj += 3;
                if (samoSlovo.Equals("A")) LjubavniZbroj += 1;
                if (samoSlovo.Equals("E")) LjubavniZbroj += 3;
            }
            int iznos = 0;
            if (LjubavniZbroj > 0) iznos = 5 - ((prvaduljina  + drugaduljina) / 2);
            if (LjubavniZbroj > 2) iznos = 10 - ((prvaduljina + drugaduljina) / 2);
            if (LjubavniZbroj > 4) iznos = 20 - ((prvaduljina + drugaduljina) / 2);
            if (LjubavniZbroj > 6) iznos = 30 - ((prvaduljina + drugaduljina) / 2);
            if (LjubavniZbroj > 8) iznos = 40 - ((prvaduljina + drugaduljina) / 2);
            if (LjubavniZbroj > 10) iznos = 50 - ((prvaduljina + drugaduljina) / 2);
            if (LjubavniZbroj > 12) iznos = 60 - ((prvaduljina + drugaduljina) / 2);
            if (LjubavniZbroj > 14) iznos = 70 - ((prvaduljina + drugaduljina) / 2);
            if (LjubavniZbroj > 16) iznos = 80 - ((prvaduljina + drugaduljina) / 2);
            if (LjubavniZbroj > 18) iznos = 90 - ((prvaduljina + drugaduljina) / 2);
            if (LjubavniZbroj > 20) iznos = 100 - ((prvaduljina + drugaduljina) / 2);
            if (LjubavniZbroj > 22) iznos = 110 - ((prvaduljina + drugaduljina) / 2);
            if (prvaduljina == 0 || drugaduljina == 0) iznos = 0;
            if (iznos < 0) iznos = 0;
            if (iznos > 99) iznos = 99;
            return iznos.ToString();
        }
        catch (Exception ex)
        {
            return "Greška!!" + ex.ToString();
        }
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ljubavni Klakulator");

        while (true)
        {
            Console.Write("Unesite prvo Ime: ");

            string Ime1 = Console.ReadLine();
            Console.Write("Unesite drugo Ime: ");

            string Ime2 = Console.ReadLine();

            LoveCalculator loveCalculator = new LoveCalculator();
            string result = loveCalculator.GetResults(Ime1, Ime2);
            Console.WriteLine("Rezultat :" + result + "%");
            Console.WriteLine("Pritisni q za izlaz");
            string quit = Console.ReadLine();
            if (quit.ToLower().Trim() == "q")
                break;
        }
    }
}
