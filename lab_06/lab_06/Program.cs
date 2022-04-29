using System;
using System.Collections.Generic;
using System.Linq;
namespace lab_06
{
    class Program
    {
      public  static void Main(string[] args)
        {
            int[] Marks = new int[]{ 0, 1, 2, 3, 4, 5, 6 };
            List<User> users = new List<User>()
            {

                new User {Name = "Bartek", Role = "Moderator"},
                new User {Name = "Celina", Role = "Admin"},
                new User {Name = "Adam", Role = "Teacher"},
                new User {Name = "Grażyna", Role = "Admin", },
                new User {Name = "Darek", Role = "Student",  }
            };
            //1
            Console.WriteLine("Lista rekordów"+ users.Count());
            Console.WriteLine((from user in users select user).Count());

            //2
            List<string> name_1 = users.Select(user => user.Name).ToList();
            List<string> name_2 = (from user in users select user.Name).ToList();
            Console.WriteLine("Lista nazw użytkowników");
            foreach (string name in name_1)
                Console.WriteLine(name);

            //3
           List<User> users_1 =  users.OrderBy(User => User.Name).ToList();
            List<User> users_2 = (from user in users orderby user.Name select user).ToList();
            Console.WriteLine("Posortowane po nazwie");
            foreach (User user in users_1)
               
                Console.WriteLine(user.Name);

            //4
           List<string> role = (from user in users select user.Role).ToList();
            IEnumerable<string> roles = role.Distinct();
            Console.WriteLine("Lista ról: ");
            foreach (string name in roles)
               Console.WriteLine(name);

            //5

            IEnumerable<IGrouping<string, string>> query =
            users.GroupBy(user => user.Role, user => user.Name);
            Console.WriteLine("Group by role (celina, grażyna to admini");
            foreach (IGrouping<string, string> petGroup in query)
            {

                foreach (string name in petGroup)
                    Console.WriteLine("  {0}", name );
            }

            //6

            var numQuery =
              from num in Marks
              where (num > 0) 
              select num;
            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }






        }

    }
    public class User
    {
        public string Name { get; set; }
        public string Role { get; set; } // ADMIN, MODERATOR, TEACHER, STUDENT
        public int Age { get; set; }
        public int[] Marks { get; set; } // zawsze null gdy ADMIN, MODERATOR lub TEACHER
        public DateTime? CreatedAt { get; set; }
        public DateTime? RemovedAt { get; set; }
    }

}
