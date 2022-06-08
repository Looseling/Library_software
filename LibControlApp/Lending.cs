using System;

namespace LibControlApp
{
    public class Lending
    {
        private static int counter = 0;
        private int id { get; set; }
        private int bookId { get; set; }
        public int userId { get; private set; }
        private int librarianId { get; set; }
        private DateTime startLending { get; set; }
        private DateTime endLending { get; set; }

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