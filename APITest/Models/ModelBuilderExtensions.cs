using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITest.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<employee>().HasData(
              new employee
              {
                  id = 1,
                  firstName = "mena",
                  lastName = "morcos"

              },
              new employee
              {
                  id = 2,
                  firstName = "Ahmed ",
                  lastName = "mohamed"

              },
               new employee
               {
                   id = 3,
                   firstName = "fady ",
                   lastName = "talat"

               },
              new employee
              {
                  id = 4,
                  firstName = "mina",
                  lastName = "naser"

              },
              new employee
              {
                  id = 5,
                  firstName = "Ahmed",
                  lastName = "gad"

              }

           );
        }
    }
}
