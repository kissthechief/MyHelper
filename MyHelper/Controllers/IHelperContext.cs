using Dal.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IHelperContext
    {
         DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
         DbSet<Food> Food { get; set; }
         DbSet<FoodSort> FoodSort { get; set; }
         DbSet<Inventar> Inventar { get; set; }
         DbSet<Messurement> Messurement { get; set; }
         DbSet<User> User { get; set; }
         DbSet<AspNetRoles> AspNetRoles { get; set; }
         DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
         DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
         DbSet<AspNetUsers> AspNetUsers { get; set; }
        int SaveChanges();
    }
}
