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
            //zmienne
            private static int licznik = 1;
            private static mianownik = 2;
            

            
            //Domyslny  
            public Ulamek()
            {
                this.licznik;
                this mianownik;
            }
            //z dwoma argumentami
            public Ulamek(int licznik, int mianownik)
            {
                this.licznik = licznik;
                this.mianownik = mianownik;
            }

            //Kopiujacy
            public Ulamek(Ulamek licznik, Ulamek mianownik)
            {
                this.licznik = Ulamek.licznik;
                this.mianownik = Ulamek.mianownik;
            }









            public class Uczen : IEquatable<Uczen>
            {
                private string imie;
                public Uczen(string imie)
                {
                    this imie = imie;
                }
                //Tostring
                public override string ToString()
                {
                    return $"Uczen ma na imie: {this.imie}";
                }


                //Equtable
                public bool Equals(Uczen other)
                {
                    if (other == null) return false;
                    if (other == this) return true;
                    return Object.Equals(this.imie, other.imie);
                }
            }

            //CompareTo
            public int CompareTo(Ulamek other)
            {

                if (other == null) return -1;
                if (other == this) return 0;

                int spr = this.licznik - other.licznik;

                if (spr > 0) return +1;
                if (spr < 0) return -1;

                return 0;
            }


               
        }
        //Zaokraglanie
        static double Zaokraglanie(double liczba, int precyzja)
        {
            double licz = Math.Pow(10, precyzja);

            return Math.Round(number * licz) / licz;
            Console.WriteLine(licz(0.5, 0); //0
            Console.WriteLine(licz(-1.2345, 0); //-1
            Console.WriteLine(Math.Round(2.49)); //  2
        }
        

    }
