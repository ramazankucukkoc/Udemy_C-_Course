namespace Singleton_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetHashCode() metodu refreans numaralırını bulur ve şuan Singleton Design Pattern 
            //olarak referanslar aynı nesneyi gösteriyor  singleton1=singleton2 önemli !!!!

            Console.WriteLine("Hello, World!");
            Singleton singleton1 =Singleton.getInstance();
            Console.WriteLine(singleton1.GetHashCode());

            Singleton singleton2 = Singleton.getInstance();
            Console.WriteLine(singleton2.GetHashCode());
            

        }
        class Singleton
        {
            private static Singleton _instance;
            private Singleton()
            {
                Console.WriteLine("Singleton class instance oluşturuldu.");
            }
            public static Singleton getInstance()
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }

        }
    }
}