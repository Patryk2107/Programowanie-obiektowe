{
    internal class Program
{
    public static void Main()
    {
        Ulamek domyslny = new Ulamek();
        Ulamek dwaargumenty = new Ulamek(1, 2);
        Ulamek kopiujacy = new Ulamek(1);
        Ulamek kopiujacy1 = new Ulamek(2);

        Ulamek jl = new Ulamek("Kacper", 1999);
        Console.WriteLine(jl);

        //Przeladowania
        Ulamek licz1 = new Ulamek(15);
        Ulamek licz2 = new Ulamek(15);
        Ulamek suma = licz1 + licz2;
        Console.WriteLine($"Suma to : {suma.licznik}");
        Ulamek mnoz = licz1 * licz2;
        Console.WriteLine($"Mnozenie : {mnoz.licznik}");
        Ulamek dziel = licz1 / licz2;
        Console.WriteLine($"Dzielenie : {dziel.licznik}");
        Ulamek minus = licz1 - licz2;
        Console.WriteLine($"Odejmowanie : {minus.licznik}");


        Console.WriteLine(licz1.Equals(licz2));









        public class Ulamek : IEquatable<Ulamek>
    {

        //zmienne
        public int licznik = 1;
        private int mianownik = 2;
        public string imie;
        public int wiek;


        // konstruktor domyslny
        public Ulamek()
        {
            this.imie = "";
            Console.WriteLine("Konstruktor domyslny = " + imie);

        }

        // konstruktor z dwoma argumentami
        public Ulamek(int licznik, int mianownik)
        {
            this.licznik = licznik;
            this.mianownik = mianownik;
            Console.WriteLine("Konstruktor z dwoma argumentami " + licznik + "," + mianownik);
        }
        // konstruktor kopiujacy
        public Ulamek(int licznik)
        {
            this.licznik = licznik;

        }
        public Ulamek(Ulamek licznik)
        {
            this.licznik = licznik.licznik;

        }
        //Metoda ToString
        public Ulamek(string imie, int wiek)
        {
            this.imie = imie;
            this.wiek = wiek;
        }
        public override string ToString()
        {
            string obj = $"{this.imie}, {this.wiek}";
            return obj;
        }
        //Przeladowanie
        public static Ulamek operator +(Ulamek licz1, Ulamek licz2)
        {
            Ulamek suma = new Ulamek(licz1.licznik + licz2.licznik);
            return suma;
        }
        public static Ulamek operator *(Ulamek licz1, Ulamek licz2)
        {
            Ulamek mnoz = new Ulamek(licz1.licznik * licz2.licznik);
            return mnoz;
        }
        public static Ulamek operator /(Ulamek licz1, Ulamek licz2)
        {
            Ulamek dziel = new Ulamek(licz1.licznik / licz2.licznik);
            return dziel;
        }
        public static Ulamek operator -(Ulamek licz1, Ulamek licz2)
        {
            Ulamek minus = new Ulamek(licz1.licznik - licz2.licznik);
            return minus;
        }

        public bool Equals(Ulamek other)
        {
            if (other == null) return false;
            if (other == this) return true;

            return Object.Equals(this.licznik, other.licznik);
        }


    }


}

}