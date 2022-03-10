using System;

namespace lab_01
{
    class Program
    {
        public static void Main()
        {
            Uczen[] uczniowie = new Uczen[]
            {
                new Uczen("Staszek")
            }
        }
        public class Ulamek
        {
            private static int licznik = 1;
            private static mianownik = 2;

            
                
            public Ulamek() 
            {
                this.licznik;
                this mianownik;
            }

            public Ulamek(int licznik, int mianownik)
            {
                this.licznik = licznik;
                this.mianownik = mianownik;
            }

            public Ulamek(int licznik, int mianownik)
            {
                this.licznik = licznik;
                this.mianownik = mianownik;
            }

            public Ulamek(Ulamek licznik, Ulamek mianownik)
            {
                this.licznik = Ulamek.licznik;
                this.mianownik = Ulamek.mianownik;
            }



            

        }
        public class Uczen
        {
            private string imie;
            public Uczen(string Uczen)
            {
                this imie = imie;
            }
            public override string ToString()
            {
                return $"Student: {this.imie}";
            }
        }
    }
}
