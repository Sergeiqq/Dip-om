using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Cafe.BDModel
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=UchaevModel")
        {
        }

        public virtual DbSet<Autoriz> Autoriz { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Dishe> Dishe { get; set; }
        public virtual DbSet<Ingredient> Ingredient { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Order_Dishes> Order_Dishes { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tables> Tables { get; set; }
        public virtual DbSet<Заказ_столика> Заказ_столика { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Заказ_столика)
                .WithOptional(e => e.Client)
                .HasForeignKey(e => e.Код_клиента);

            modelBuilder.Entity<Dishe>()
                .Property(e => e.Quantity)
                .IsFixedLength();

            modelBuilder.Entity<Dishe>()
                .Property(e => e.Money)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ingredient>()
                .Property(e => e.Money)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ingredient>()
                .Property(e => e.Quantity)
                .IsFixedLength();

            modelBuilder.Entity<Post>()
                .Property(e => e.Salary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<Tables>()
                .HasMany(e => e.Client)
                .WithOptional(e => e.Tables)
                .HasForeignKey(e => e.ID_Tables);

            modelBuilder.Entity<Tables>()
                .HasMany(e => e.Заказ_столика)
                .WithOptional(e => e.Tables)
                .HasForeignKey(e => e.Код_столика);
        }
    }
}
