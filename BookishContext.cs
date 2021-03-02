using Bookish.Models;
using Microsoft.EntityFrameworkCore;


namespace Bookish.Data
{
    public class BookishContext : DbContext
    {
        public DbSet<BookModel> BookModel { get; set; }
        public DbSet<UserModel> UserModel { get; set; }

         public DbSet<LibrarianModel> LibrarianModel { get; set; }

         public DbSet<BookCheckedOutModel> BookCheckedOutModel {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=BookishDB;Trusted_Connection=True;");
        }
    }
}