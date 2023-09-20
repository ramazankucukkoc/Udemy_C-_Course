namespace Template_Method_Design_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //RefOutKeyword refKeyword = new RefOutKeyword();
            //int age = 5;
            //int age2=20;
            //Console.WriteLine(age);

            //refKeyword.SetAge(ref age); 
            //Console.WriteLine(age);

            //refKeyword.SetAge2(out age2);
            //Console.WriteLine(age2);
            ////Sum sum = new Sum();
            ////int result = sum.Calc(2, 3, 2, 6, 8);
            ////Console.WriteLine(result);
            ///

            Alisveris alisveris1 = new Televizyon();
            alisveris1.TemplateMethod();
            Alisveris alisveris2 = new Buzdolabi();
            alisveris2.TemplateMethod();

            Console.ReadLine();

        }
        enum OdemeTipi
        {
            Pesin,Taksit
        }
        abstract class Alisveris
        {
            protected string UrunAdi;
            protected OdemeTipi OdemeTipi;
            void Baslat() => Console.WriteLine("Alışveriş Başladı");
            void Bitir() => Console.WriteLine($"Alışveriş bitti.{UrunAdi} {OdemeTipi} " +
                $"olarak alındı" );
            abstract public void Urun();
            abstract public void OdemeSekli();
            public void TemplateMethod()
            {
                Baslat();
                Urun();
                OdemeSekli();
                Bitir();
            }

        }
        class Televizyon : Alisveris
        {
            public override void OdemeSekli()
            {
                OdemeTipi = OdemeTipi.Pesin;
            }

            public override void Urun()
            {
                UrunAdi = "Televizyon";
            }
        }
        class Buzdolabi : Alisveris
        {
            public override void OdemeSekli()
            {
                OdemeTipi = OdemeTipi.Taksit;
            }

            public override void Urun()
            {
                UrunAdi = "Buzdolaabı";
            }
        }
    }

}