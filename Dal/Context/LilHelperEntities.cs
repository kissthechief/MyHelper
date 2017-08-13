namespace Dal.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LilHelperEntities : DbContext, IHelperContext
    {
        public LilHelperEntities()
            : base("name=LilHelperEntities")
        {
        }

        public LilHelperEntities(string connectionstring)
            : base(connectionstring)
        {

        }

        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Food> Food { get; set; }
        public virtual DbSet<FoodSort> FoodSort { get; set; }
        public virtual DbSet<Inventar> Inventar { get; set; }
        public virtual DbSet<Messurement> Messurement { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("LHELP");

            modelBuilder.Entity<AspNetRoles>().ToTable("AspNetRoles", "dbo");
            modelBuilder.Entity<AspNetUserClaims>().ToTable("AspNetUserClaims", "dbo");
            modelBuilder.Entity<AspNetUserLogins>().ToTable("AspNetUserLogins", "dbo");
            modelBuilder.Entity<AspNetUsers>().ToTable("AspNetUsers", "dbo");

            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles", "dbo").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.Inventar)
                .WithMany(e => e.Food)
                .Map(m => m.ToTable("FoodInventars", "LHELP").MapLeftKey("InventarId").MapRightKey("FoodId"));
            ;

            modelBuilder.Entity<FoodSort>()
                .HasMany(e => e.Food)
                .WithOptional(e => e.FoodSort)
                .HasForeignKey(e => e.FoodSort_Id);

            modelBuilder.Entity<Messurement>()
                .HasMany(e => e.Food)
                .WithOptional(e => e.Messurement)
                .HasForeignKey(e => e.Messurement_Id);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Inventar)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.User_Id);
        }
    }
}
