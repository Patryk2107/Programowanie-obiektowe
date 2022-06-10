using System;

namespace lab2ok
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //#name: string,#age: int, #group: string, #tasks: List<Task>
        protected string name;
        protected int age;
        protected string group;
        protected List<Task> tasks;
        //#task List<Product> = new List<Product>()
        protected List<Product> tasks = new List<Product>();
        //-name:string, -status: TaskStatus, -person: Person[]
        private string _name;
        private TaskStatus _status;
        private Person[] _persons;

        // +<property> Name:String, +<property> Age:Int
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        //+<property> Group: string
        public string Group { get; set; }
        //+<create>Person (name: string, age:int)
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        //+<create> name:string, age: int, tasks: List<Task> pobiera name i age
        public Student(string name, int age, string group, List<Task> tasks) : base(name, age)
        {
            this.name = name;
            this.age = age;
            this.group = group;
            this.tasks = tasks;
        }
        //+Equals (other:Person?): bool
        public bool Equals(Person? obj)
        {
            return base.Equals(obj);
        }
        //+ToString()
        public override string ToString()
        {
            return base.ToString();
        }
        //+AddTask - metoda
        public void AddTask(string taskName, TaskStatus taskStatus)
        {
            Task task = new Task(taskName, taskStatus);
            tasks.Add(task);
        }
        //+Update
        public void RemoveTask(int index)
        {
            tasks.RemoveAt(index);
        }
        public void UpdateTask(int index, TaskStatus taskStatus)
        {
            tasks[index].Status = (TaskStatus)(System.Threading.Tasks.TaskStatus)taskStatus;
        }
        //+<create> Classroom(name: String, persons: Person || + To String
        public Classroom(string name, Person[] persons)
        {
            this.Name = name;
            this._persons = persons;
        }
        public override string ToString()
        {
            string cl = $"Classrom: {Name} \n";
            foreach (Person person in _persons)
            {
                cl += "\n" + person.ToString() + "\n";
            }
            return cl;
        }
        //+<create> Task (name: string, status:TaskStatus) || To String
        public Task(string name, TaskStatus status)
        {
            this.Name = name;
            this.Status = status;
        }
        public override string ToString()
        {
            return $"{Name} [{Status}]";
        }
        //+Print(prefix:string)
        public override void Print(string prefix)
        {
            Console.WriteLine($"{prefix}Seller: {Name} ({Age} y.o.)");
        }
        //+Print(prefix:string) // list
        public override void Print(string prefix)
        {
            Console.WriteLine($"{prefix}Buyer: {Name} ({Age} y.o.)");
            if (this.tasks.Count > 0)
            {
                Console.WriteLine(prefix + prefix + "-- Products: --");
                foreach (var task in this.tasks)
                    task.Print(prefix + prefix);
            }

        }
        //+<create> Shop(name:String, people: Person[], products:Product[]
        public Shop(string name, Person[] people, Product[] products)
        {
            _name = name;
            this._people = people;
            this._products = products;
        }
        //+++++ToString()
        public void Print()
        {
            Console.WriteLine("Shop: " + Name);
            Console.WriteLine("-- People: --");
            foreach (Person person in _people)
                person.Print("\t");

            Console.WriteLine("-- Products: --");
            foreach (Product product in _products)
                product.Print("\t");

        }
    }
}
}
