using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataRepository;
using DataRepository.Models;
using System.Linq;
using System.Data.Entity;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void ClearDataBase()
        {
        }

        [TestMethod]
        public void Contention()
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

            User user1;
            User user2;
            using (var ctx = new DataContext())
            {
                user1 = ctx.Users.OrderByDescending(u => u.Id).FirstOrDefault();
            }
            using (var ctx = new DataContext())
            {
                user2 = ctx.Users.OrderByDescending(u => u.Id).FirstOrDefault();
            }


            using (var ctx = new DataContext())
            {
                user1.FirstName = "R1";
                ctx.Entry(user1).State = EntityState.Modified;
                ctx.SaveChanges();
            }

            using (var ctx = new DataContext())
            {
                user2.FirstName = "R2";
                ctx.Entry(user2).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}
