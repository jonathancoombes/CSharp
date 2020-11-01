using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Schema;

namespace ConsoleApp.Fundamentals
{
    class LINQ
    {
        //Using LINQ to create a list of books matching given expression

        IEnumerable<Book> Books = new Book().GetBooks().Where(b => b.Price < 201);

        public void DisplayResult() { 
        
            foreach(var book in Books){
                Console.WriteLine("Title: " + book.Title + "Price: " + book.Price);
            }
        
        }        

    }

    public class Book {

        public int Price { get; set; }
        public string  Title { get; set; }

        public IEnumerable<Book> GetBooks() {

            return new List <Book>()
        {
            new Book(){Price = 200, Title = "The better"},
            new Book(){Price = 300, Title = "The second best" },
            new Book(){Price = 400, Title = "The  best" },

        };
        
        }
        
        
        
    }

}
