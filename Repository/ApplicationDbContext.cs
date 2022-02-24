using Microsoft.EntityFrameworkCore;
using efcore2.EntityConfugation;
using efcore2.Models;

namespace efcore2.Repository {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options) { }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=DBName;Integrated Security=True");
        // }

        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<ProductModel> Products {get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configures one-to-many relationship
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            
            //modelBuilder.Entity<ProductModel>()
            //        .HasOne<CategoryModel>(p => p.Category)
            //        .WithMany(c => c.Products)
            //       .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<CategoryModel>().HasKey(c => c.CategoryId);

            modelBuilder.Entity<ProductModel>().HasKey(p => p.ProductId);

            modelBuilder.Entity<CategoryModel>().HasData(
                new CategoryModel{ CategoryId = 1, CategoryName = "Books"},
                new CategoryModel{ CategoryId = 2, CategoryName = "Smartphones"}
            );

            modelBuilder.Entity<ProductModel>().HasData(
                new ProductModel{ ProductId = 1, ProductName = "English", Manufacture = "Oxford", CategoryId = 1 },
                new ProductModel{ ProductId = 2, ProductName = "German", Manufacture = "Duden", CategoryId = 1 },
                new ProductModel{ ProductId = 3, ProductName = "Tieng Viet", Manufacture = "Tuoitre", CategoryId = 1 },
                new ProductModel{ ProductId = 4, ProductName = "iPhone 20", Manufacture = "Apple", CategoryId = 2 },
                new ProductModel{ ProductId = 5, ProductName = "iPhone 21", Manufacture = "Apple", CategoryId = 2 },
                new ProductModel{ ProductId = 6, ProductName = "Galaxy 100", Manufacture = "Samsung", CategoryId = 2 }
            );            
        }
    }
}