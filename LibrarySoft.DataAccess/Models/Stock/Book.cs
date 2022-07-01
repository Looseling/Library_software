using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace LibControlApp
{
    public class Book : IBorrowable, ISearchable
    {
        [Key]
        public int bookId { get; set; }
        public int pages { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public string cover { get; set; }
        public Lending lended { get; set; }
        public LibraryContext context { get; set; }

        

        public void Borrow(Lending lended)
        {
            this.lended = lended;
        }

        public static Book Search(LibraryContext context,string title)
        {
                try
                {
                    var result = context.Books.Where(s => s.title == title);
                    return result.First();
                }
                catch (SqlException)
                {
                    return null;
                }
        }

        public void print()
        {
                Console.WriteLine($"Title: {title}\n" +
                              $"pages: {pages}\n" +
                              $"Cover: {cover}\n" +
                              $"Author: {author}\n" +
                              $"Genre: {genre}\n");
        }

        public void Add()
        {
            context.Add(this);
            context.SaveChanges();
        }






    }
}