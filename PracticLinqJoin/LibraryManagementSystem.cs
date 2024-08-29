using LibraryManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticLinqJoin
{
    public class LibraryManagementSystem
    {
        public static void Main(string[] args)
        {
            List<Author> authors = new List<Author>()
        {
                // Author table created
            new Author { AuthorId =1, AuthorName = "Orhan Pamuk"},
            new Author { AuthorId =2, AuthorName = "Elif Safak"},
            new Author { AuthorId =3, AuthorName = "Ahmet Umit"},
            new Author { AuthorId =4, AuthorName = "Ilber Ortayli"},

        };
            // Book tablo created
            List<Book> books = new List<Book>()
            {
                new Book { BookId = 1, Title = "Kar", AuthorId =1 },
                new Book { BookId = 2, Title = "Istanbul", AuthorId =1 },
                new Book { BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId =2 },
                new Book { BookId = 4, Title = "Beyoglu Rapsodisi", AuthorId =3 },
                new Book { BookId = 5, Title = "Cumhuriyetin Ilk Sabahi", AuthorId =4 },

            };
            //Merge books and authors with linq query
            var bookAndAuthor = from book in books
                                join author in authors on book.AuthorId equals author.AuthorId
                                select new
                                {
                                    book.Title,
                                    author.AuthorName
                                };
            //Result print
            Console.WriteLine("Kitaplar ve Yazarlari:");
            foreach (var book in bookAndAuthor)
            {
                Console.WriteLine($"Kitap Adi: {book.Title}, Yazar: {book.AuthorName}");
            }
        }
    }
}
