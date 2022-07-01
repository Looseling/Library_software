using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace LibControlApp
{
    public class Lending
    {

        [Key]
        public int lendingId { get; set; }
        public int bookId { get; set; }
        public int userId { get; set; }
        public int librarianId { get; set; }
        public DateTime startLending { get; set; }
        public DateTime endLending { get; set; }

        public LibraryContext context { get; set; }


        public void Add()
        {
            context.Lendings.Add(this);
            context.SaveChanges();
        }

        public static Lending SearchByUserid(LibraryContext context, Member member)
        {
            using (context)
            {
                try
                {
                    var result = context.Lendings.Where(s => s.userId == member.userId);
                    return result.First();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }


        public void print()
        {
            Console.WriteLine($"UserId: {userId}\n" +
                          $"LibrarianId: {librarianId}\n" +
                          $"bookId: {bookId}\n" +
                          $"startLending: {startLending}\n" +
                          $"endLending: {endLending}\n");
        }





    }
}