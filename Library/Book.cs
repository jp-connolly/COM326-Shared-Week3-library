using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    public class Book
    {
        // private fields
        private string title;
        private string author;
        private string isbn;


        // Public properties
        public string Title
        {
            get { return title; }
            set
            {
                // Ensure name does not contain any numbers
                if (!value.Any(char.IsDigit) && value != "")
                {
                    title = value;
                }
                else
                {
                    Console.WriteLine("Error: Book title cannot be blank or contain numbers.");
                }
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                // Ensure name does not contain any numbers
                if (!value.Any(char.IsDigit) && value != "")
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Book author cannot be blank or contain numbers.");
                }
            }
        }

        public string ISBN
        {
            get { return isbn; }
            set
            {
                // Ensure name does not contain any numbers
                if (!value.Any(char.IsDigit) && value != "")
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("Error: Book ISBN cannot be blank or contain numbers.");
                }
            }
        }


        // Constructor
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
} 
    
