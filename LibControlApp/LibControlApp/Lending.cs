using System;

namespace LibControlApp
{
    public class Lending
    {
        private static int counter = 0;
        private int id { get; set; }
        public int bookId { get; set; }
        public int userId { get; set; }
        public int librarianId { get; set; }
        public DateTime startLending { get; set; }
        public DateTime endLending { get; set; }

        public Lending( DateTime startLending, DateTime endLending, int bookId, int userId, int librarianId)
        {
            this.id = ++counter;
            this.startLending = startLending;
            this.endLending = endLending;
            this.bookId = bookId;
            this.userId = userId;
            this.librarianId = librarianId; 
        }

    }
}