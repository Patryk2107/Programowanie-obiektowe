using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    class Program
    {

        Seller treacher = new Seller("Jan", 50);

        Buyer buyer1 = new Buyer("Zbyszek", 25);
        Buyer buyer2 = new Buyer("Staszek", 21);
        Buyer buyer3 = new Buyer("Jozek", 23);

        buyer.AddProduct = new Fruit("Apple", 6));
            buyer1.AddProduct = new Meat("Fish", 0.5));

            Person[] persons = { treacher, buyer1, buyer2, buyer3 };

        Product[] products = {
                new Fruit("Wisnia", 1000),
                new Fruit("Ogorek", 700),
                new Fruit("Sliwka", 500),
                new Meat("Ziemniak", 100.0),
                new Meat("Miesko", 75.0)
            };

        Shop shop = new Shop("Najlepszy sklep", persons, products);

        shop.Print(shop);
        }
    interface IThing
    {
        string name
        {
            get;
            set;
        }
    }
    public class Product
    {
        private string name { get; set; }

        public Product(string name)
        {
            this.name = name;
        }
        public void Print()
        {
            Console.WriteLine(name);
        }
    }
    public class Fruit : Product
    {
        private int count { get; set; }

        public Fruit(string name, int count) : base(name)
        {
            this.count = count;
        }
        public void Print()
        {


            Console.WriteLine(name + "(" + count + " fruints)");
            base.Print();
        }
    }
    public class Meat : Product
    {
        private double waight { get; set; }

        public Meat(string name, int waight) : base(name)
        {
            this.waight = waight;
        }
        public void Print()
        {
            Console.WriteLine(name + "(" + waight + " fruints)");
        }
    }
    public class Person
    {
        private string name { get; set; }
        private int age { get; set; }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Print()
        {
            Console.WriteLine(name + " (" + age + " y.o.)");
        }
    }
    public class Buyer : Person
    {
        protected List<Product> tasks = new List<Product>();
        public Buyer(string name, int age) : base(name, age)
        {

        }
        public void AddProduct(Product product)
        {
            tasks.Add(product);
        }
        public void RemoveProduct(int index)
        {
            tasks.RemoveAt(index);
        }
    }
    public class Seller : Person
    {
        public Seller(string name, int age) : base(name, age)
        {

        }
    }
    public class Shop
    {
        private string name { get; set; }
        private Person[] people;
        private Product[] products;
        public Shop(string name, Person[] people, Product[] products)
        {
            this.name = name;
            this.people = people;
            this.products = products;
        }
        public void Print()
        {
            Console.WriteLine("Shop " + name + people + products);
        }
    }

}

