using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace DataAccess.Repositories
{
    public class NyamaContext : DbContext
    {
        public NyamaContext() { }
        public NyamaContext(DbContextOptions<NyamaContext> options) : base(options) { }

        public DbSet<Category> Category { get; set; } = default!;
        public DbSet<City> City { get; set; } = default!;
        public DbSet<District> District { get; set; } = default!;
        public DbSet<Expense> Expense { get; set; } = default!;
        public DbSet<ExpenseType> ExpenseType { get; set; } = default!;
        public DbSet<Image> Image { get; set; } = default!;
        public DbSet<Order> Order { get; set; } = default!;
        public DbSet<Shop> Shop { get; set; } = default!;
        public DbSet<Unit> Unit { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Shop>()
                .HasMany(x => x.Orders)
                .WithOne(x => x.Shop)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Entity<Shop>()
                .HasOne(x => x.District)
                .WithMany(x => x.Shops)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Entity<District>()
                .HasOne(x => x.City)
                .WithMany(x => x.Districts)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Entity<Expense>()
                .HasOne(x => x.ExpenseType)
                .WithMany(x => x.Expenses)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Entity<Expense>()
                .HasOne(x => x.Unit)
                .WithMany(x => x.Expenses)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Entity<ExpenseType>()
                .HasOne(x => x.Category)
                .WithMany(x => x.ExpenseTypes)
                .OnDelete(DeleteBehavior.Restrict);

            
            modelBuilder
                .Entity<City>()
                .HasData(
                new City { CityId = 1, Name = "Paris" },
                new City { CityId = 2, Name = "Marseille" },
                new City { CityId = 3, Name = "Lyon" },
                new City { CityId = 4, Name = "Toulouse" }
        );

            modelBuilder
               .Entity<District>()
               .HasData(
              new District { CityId = 1, DistrictId = 1, Name = "Le Marais" },
                new District { CityId = 1, DistrictId = 2, Name = "Montmartre" },
                new District { CityId = 1, DistrictId = 3, Name = "Saint-Germain-des-Prés" },
                new District { CityId = 1, DistrictId = 4, Name = "Le Quartier Latin" },

                new District { CityId = 2, DistrictId = 5, Name = "Le Vieux-Port" },
                new District { CityId = 2, DistrictId = 6, Name = "Le Panier" },
                new District { CityId = 2, DistrictId = 7, Name = "Le Cours Julien" },
                new District { CityId = 2, DistrictId = 8, Name = "La Corniche" },

                new District { CityId = 3, DistrictId = 9, Name = "Vieux Lyon" },
                new District { CityId = 3, DistrictId = 10, Name = "Presqu'île" },
                new District { CityId = 3, DistrictId = 11, Name = "Croix-Rousse" },
                new District { CityId = 3, DistrictId = 12, Name = "Confluence" },

                new District { CityId = 4, DistrictId = 13, Name = "Capitole" },
                new District { CityId = 4, DistrictId = 14, Name = "Saint-Cyprien" },
                new District { CityId = 4, DistrictId = 15, Name = "Carmes" },
                new District { CityId = 4, DistrictId = 16, Name = "Saint-Étienne" }
       );

            modelBuilder
               .Entity<ExpenseType>()
               .HasData(
               new ExpenseType { CategoryId = 1, ExpenseTypeId = 1, Name = "Achat - Tapioca" },
                new ExpenseType { CategoryId = 1, ExpenseTypeId = 2, Name = "Achat - Arachide" },
                new ExpenseType { CategoryId = 1, ExpenseTypeId = 3, Name = "Achat - Sucre" },

                new ExpenseType { CategoryId = 2, ExpenseTypeId = 4, Name = "transport - Tapioca" },
                new ExpenseType { CategoryId = 2, ExpenseTypeId = 5, Name = "transport - Arachide" },
                new ExpenseType { CategoryId = 2, ExpenseTypeId = 6, Name = "transport - Sucre" },

                new ExpenseType { CategoryId = 3, ExpenseTypeId = 7, Name = "Déplacement - Prospection" },
                new ExpenseType { CategoryId = 3, ExpenseTypeId = 8, Name = " Déplacement - Achat Matières premières" },
                new ExpenseType { CategoryId = 3, ExpenseTypeId = 9, Name = "Déplacement - Dépôt en boutique" },
                new ExpenseType { CategoryId = 3, ExpenseTypeId = 10, Name = "Déplacement - Envoi de commandes" },

                new ExpenseType { CategoryId = 4, ExpenseTypeId = 11, Name = "Salaire - Grillage arachides" },
                new ExpenseType { CategoryId = 4, ExpenseTypeId = 12, Name = "Salaire - Dépulpage arachides" },
                new ExpenseType { CategoryId = 4, ExpenseTypeId = 13, Name = "Salaire Préparation arachides" },
                new ExpenseType { CategoryId = 4, ExpenseTypeId = 14, Name = "Salaire - Séchage tapioca" }
       );

            modelBuilder
               .Entity<Category>()
               .HasData(
              new Category { CategoryId = 1, Name = "Achats" },
                new Category { CategoryId = 2, Name = "Transport" },
                new Category { CategoryId = 3, Name = "Deplacement" },
                new Category { CategoryId = 4, Name = "Salaire" }
       );

            modelBuilder
               .Entity<Unit>()
               .HasData(
              new Unit { UnitId = 1, Name = "Demi-Sac" },
                new Unit { UnitId = 2, Name = "Sac" }
       );

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(
                "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = NyamaAppDb");
        }
    }
}
