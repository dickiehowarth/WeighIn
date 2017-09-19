using DataRepository;
using DataRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeighIn
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new DataContext())
            {
                var user = new User()
                {
                    FirstName = "Rich",
                    LastName = "Howarth",
                    Email = "ricj@hotmail.com",
                    Password = "password"
                };

                ctx.Users.Add(user);

                ctx.SaveChanges();

            }

            using (var ctx = new DataContext())
            {
                ctx.Users.ToList().ForEach(
                    u => Console.WriteLine($"Name: {u.FirstName}")
                    );
            }

            using (var ctx = new DataContext())
            {
                ctx.Users.ToList().ForEach(
                    u => Console.WriteLine($"Name: {u.FirstName}")
                    );
            }

            Console.ReadLine();
        }
    }
}
