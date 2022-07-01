using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibControlApp
{
    public class LibraryContext : DbContext
    {
      

        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Memebers { get; set; }
        public DbSet<Lending> Lendings { get; set; }
        public DbSet<Librarian> Librarians { get; set; }

        public string DbPath { get; }
      
        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=LibraryDB;Trusted_Connection=True");
    }
}
