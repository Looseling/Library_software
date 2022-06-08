using System;

namespace LibControlApp
{
    public class Book
    {
        private static int counter = 0;
        private int id { get; set; }
        public int pages { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string genre { get; set; }

        public string cover { get; set; }

        public Book(string title, string author, string genre, int pages, string cover)
        {
            this.id = ++counter;
            this.pages = pages;
            this.author = author;
            this.title = title;
            this.genre = genre;
            this.cover = cover;
        }

        public int GetId()
        {
            return this.id;
        }
    }
}