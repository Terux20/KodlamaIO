namespace KodlamaIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "İbrahim Kaya";
            kurs1.IzlenmeOrani = 523;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "dgC";
            kurs2.Egitmen = "Ali veli";
            kurs2.IzlenmeOrani = 2;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.Egitmen = "İbrahim Kaya";
            kurs3.IzlenmeOrani = 3223;

            Kurs a = new Kurs();
            a.KursAdi = "selam";
            a.Egitmen = "aylin";
            Console.WriteLine(kurs1.KursAdi + "-" + a.Egitmen);
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
