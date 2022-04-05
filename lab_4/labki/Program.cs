
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("LISTA");
        //Lista
        List<int> lista = new List<int>();
        lista.Add(1);
        lista.Add(2);

        foreach(var items in lista)
        {
            Console.WriteLine(items); 
        }

        Console.WriteLine("SLOWNIK");
        //Slownik
        Dictionary<int, string> slownik = new Dictionary<int, string>();
        slownik.Add(1, "Ania");
        slownik.Add(2, "bartek");

        foreach(var item in slownik)
        {
            Console.WriteLine("{0} : {1}", item.Key, item.Value);
        }
        Console.WriteLine("KOLEJKA");
        //Kolejka
        Queue<int> kolejka = new Queue<int>();
        kolejka.Enqueue(1);
        kolejka.Enqueue(2);
        kolejka.Enqueue(3);
        Console.WriteLine(kolejka.Dequeue());
        Console.WriteLine(kolejka.Dequeue());
        Console.WriteLine(kolejka.Peek()); // wyswietla ale nie usuwa

        //Stos
        Console.WriteLine("STOS");
        Stack<int> Stack = new Stack<int>();
        Stack.Push(1);
        Stack.Push(2);
        Stack.Push(3);
        Console.WriteLine(Stack.Pop());
        Console.WriteLine(Stack.Pop());
        Console.WriteLine(Stack.Peek());
        //Instrument

        IInstrument instrument = new Fortepian();
        instrument.Graj();
    }
    interface IInstrument
    {
        public abstract void Graj();
    }
    class Fortepian : IInstrument
    {
        public void Graj()
        {
            Console.WriteLine("Graj na Fortepian");
        }
    }




}