using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demooooo_o
{
    public class LibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        

        public override string ToString()
        {
            return "Library Item: " + Title + " by " + Author + ", published in " + PublicationYear ;
        }
    }

    public class Book : LibraryItem
    {
        public int Page { get; set; }
        public override string ToString()
        {
            return "\n Book" + ": " + Title + " \n Title :" + Author + ". \n Author :" + PublicationYear + ". \n Page :" + Page;

        }
    }

    public class Magazine : LibraryItem
    {
        public int Page { get; set; }
        public override string ToString()
        {
            return "\n Magazine: : " + Title + " \n Title :" + Author + ". \n Author :" + PublicationYear + ". \n Page :" + Page;
        }
    }

    public class DVD : LibraryItem
    {
        public int Page { get; set; }
        public override string ToString()
        {
            return "\n DVD: " + Title + " \n Title :" + Author + ". \n Author :" + PublicationYear + ". \n Page :" + Page;
               
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Book book = new Book()
            {
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                PublicationYear = 1925,
                Page = 1
            };

            Magazine magazine = new Magazine()
            {
                Title = "National Geographic",
                Author = "Various Authors",
                PublicationYear = 2023,
                Page =  2
            };

            DVD dvd = new DVD()
            {
                Title = "Inception",
                Author = "Christopher Nolan",
                PublicationYear = 2010,
                Page = 3
            };

            Console.WriteLine(book.ToString());     
            Console.WriteLine(magazine.ToString());  
            Console.WriteLine(dvd.ToString());       
        }
    }

}
