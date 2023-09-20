namespace Strategy_Design_Pattens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OzelYapimUret ozelYapimUret =new OzelYapimUret();
            SeriUret seriUret = new SeriUret();
            SiparisUzerineUret siparisUzerineUret=new SiparisUzerineUret();
            Uretici uretici = new(seriUret);

            Console.WriteLine("Hello, World!");
        }
    }
    abstract class Strategy
    {
        public abstract Opel Uret();
    }
    class Opel
    {
        public Opel(string uretimTipi)
        {
            Console.WriteLine($"Opel {uretimTipi} üretilmiştir.");
        }
    }
    class SeriUret: Strategy
    {
        public override Opel Uret()
        {
            return new Opel("seri");
        }
    }
    class OzelYapimUret: Strategy
    {
        public override Opel Uret()
        {
            return new Opel("özel yapım");
        }
    }
    class SiparisUzerineUret:Strategy
    {
        public override Opel Uret()
        {
            return new Opel("sipariş üzerine");
        }
    }
    class Uretici
    {
        public Uretici(Strategy strategy)
        {
           strategy.Uret();
        }

    }
}