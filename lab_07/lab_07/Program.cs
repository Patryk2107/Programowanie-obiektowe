using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uwaga: zmień `DESKTOP-123ABC\SQLEXPRESS` na nazwę swojego serwera.

            string connectionString = @"Data Source=DESKTOP-44D0CBM\SQLEXPRESS;Initial Catalog=projectdb;Integrated Security=True";

            using (DataContext dataContext = new DataContext(connectionString))
            {
                Table<UserEntity> users = dataContext.GetTable<UserEntity>();

                IQueryable<UserEntity> query = from user in users
                                               where user.CreatedAt.HasValue == true // user.RemovedAt == null
                                               select user;

                foreach (UserEntity user in query)
                    Console.WriteLine("{0} {1} {2} {3}", user.Id, user.Name, user.CreatedAt, user.RemovedAt);
            }
        }
        [Table(Name = "Users")]
        public class UserEntity
        {
            [Column(IsPrimaryKey = true, Name = "Id")]
            public long Id { get; set; }

            [Column(Name = "Name")]
            public string Name { get; set; }

            [Column(Name = "Role")]
            public string Role { get; set; } // ADMIN, MODERATOR, TEACHER, STUDENT

            [Column(Name = "CreatedAt")]
            public DateTime? CreatedAt { get; set; }

            [Column(Name = "RemovedAt")]
            public DateTime? RemovedAt { get; set; }
        }


    }

}
