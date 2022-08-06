using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Cart> Carts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Book>().HasData
            //    (
            //        new Book() { BookTitle = "Vadideki Zambak", Description = "Vadideki Zambak, Fransız yazar Honoré de Balzac'ın romanıdır. 1835'te yayımlanan ve yazarın en bilinen kitaplarından biri olan roman, Balzac'ın İnsanlık Komedyası'nın 'Taşra Yaşamından Sahneler' bölümünde yer almaktadır", Price = 25m, AuthorId = 1, Publisher = "D&R" }i
            //    );

            //modelBuilder.Entity<Author>().HasData
            //    (
            //        new Author() { AuthorName = "Sir. Arthur Conan Doyle", BirthDate = new DateTime(16/08/1967) }
            //    );

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
