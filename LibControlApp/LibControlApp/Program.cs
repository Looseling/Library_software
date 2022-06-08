using Console;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibControlApp
{
    class Program
    {
        static List<Lending> lendings;
        static List<Book> books;
        static void Main(string[] args)
        {

            //Stock of book, and track of lendings
            lendings= new List<Lending>();
            books = new List<Book>();

            // need constructor for Book object
            books.Add(new Book("War and Piece", "Lev Tolstoy", "military prose", 1300, "Hard"));
            books.Add(new Book("Harry Potter", "J. K. Rowling", "Fantasy",800,"Soft"));
            books.Add(new Book("Fahrenheit 451", "Ray Bradbury", "Roman", 250, "Hard"));
            books.Add(new Book("Flowers for Algernon","Daniel Keyes", "Disability literature", 200, "Hard"));

            // User and Librarian objects,
            User user1 = new User("Sana667", "asdfGG1","Samanta", "Maximova");
            Librarian librarian1 = new Librarian("LibMan228", "BoOks4EvEr", "Alex", "Poppens");




                


            bool exit = false;
            string exit_answer;
            string option;
            System.Console.WriteLine("Hello! You are in Library");

            while (!exit)
            {
                System.Console.WriteLine("Enter number option you want go with");
                System.Console.WriteLine("1: Search for a book\n" +
                                         "2: add a lending\n" +
                                         "3: add a book\n" +
                                         "4: Search for a lending with given user id\n" +
                                         "5: exit\n");
                option = System.Console.ReadKey().KeyChar.ToString();
                System.Console.WriteLine();
                switch (option)
                {
                    case "1":
                        SearchBook();
                        break;
                    case "2":
                        AddLending(user1, librarian1);
                        break;
                    case "3":
                        AddBook();
                        break;
                    case "4":
                        SearchLenging_UserId();
                        break;
                    case "5":
                        return;
                        break;
                    default:
                        System.Console.WriteLine("Something went wrong try again :/");
                        break;
                }
            }


            System.Console.WriteLine("Thanks for using us! :)");
            


        }
        public static DateTime endDate()
        {
            System.Console.WriteLine("----------------------------------");
            System.Console.WriteLine("please specify end of lending: ");
            System.Console.Write("Enter a year: ");
            int year = int.Parse(System.Console.ReadLine());
            System.Console.Write("Enter a month: ");
            int month = int.Parse(System.Console.ReadLine());
            System.Console.Write("Enter a day: ");
            int day = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("----------------------------------");


            return new DateTime(year, month, day);
        }



        public static void AddLending(User user, Librarian librarian)
        {

            int userId = user.GetId();
            int LibrarianId = librarian.GetId();
            int bookId;
            DateTime startOfLending = DateTime.Now;
            DateTime endOfLending;

            System.Console.Write("give me title of the book: ");
            string title = System.Console.ReadLine();
            
            //add Lending
            foreach (var book in books)
            {
                if (book.title == title)
                {
                    endOfLending = endDate();
                    bookId = book.GetId();
                    
                    books.Remove(book);
                    //need parameters for Constructor
                    lendings.Add(new Lending(startOfLending,endOfLending,book.GetId(),user.GetId(),librarian.GetId()));
                    return;
                }
            }
            System.Console.WriteLine("No such book in library :(");
        }

        public static void SearchLenging_UserId( )
        {
            System.Console.WriteLine("Enter user Id");
            int userId = Int32.Parse(System.Console.ReadLine());

            bool answer = lendings.Where(l => l.userId == userId).First() != null ? true : false;

            if(answer)
                System.Console.WriteLine($"User: {userId} l ent this book");
            else
                System.Console.WriteLine("User: {userId} didn't lent this book");
        }

        public static void AddBook()
        {

            System.Console.WriteLine("----------------------------------");

            System.Console.Write("Enter Title: ");
            string title = System.Console.ReadLine();
            System.Console.Write("Enter author: ");
            string author = System.Console.ReadLine();
            System.Console.Write("Enter genre: ");
            string genre = System.Console.ReadLine();
            System.Console.Write("Enter amount of pages: ");
            int pages = Int32.Parse(System.Console.ReadLine());
            System.Console.Write("Enter cover type: ");
            string cover = System.Console.ReadLine();
            System.Console.WriteLine("----------------------------------");


            books.Add(new Book(title, author, genre, pages, cover));
        }

        

        public static bool  SearchBook()
        {
            System.Console.Write("\nPlease enter title to search for: ");
            string title = System.Console.ReadLine();
            foreach (var book in books)
            {
                if (book.title == title)
                {
                    System.Console.WriteLine("----------------------------------");
                    System.Console.WriteLine($"You are lucky we have this book! ");
                    System.Console.WriteLine($"Title: {title}\n" +
                                             $"book Id: {book.GetId()}");
                    System.Console.WriteLine("----------------------------------");
                    return true;
                }
            }
            System.Console.WriteLine("No such book in library :(");
            return false;
        }
    }
}
