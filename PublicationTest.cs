using System;
using System.Collections.Generic;
using System.Text;

namespace myappAug10
{   class Publications
    {
        
        public Publications(string title, float price)
        {
            this.title = title;
            this.price = price;
        }
        public float price { get; set; }

        public string title { get; set; }
        public virtual string Display()
        {
            return "";
        }
        

    }

    class Book : Publications
    {
        
        public Book(string title, float price, int pagecnt): base(title,price)
        {
            this.pagecnt = pagecnt;
        }

        public int pagecnt { get; set; }

        
        public override string Display()
        {
            return $"The title of the Book is {this.title} for price {this.price} and page count is {this.pagecnt}";
        }
    }

    class Video: Publications
    {
        float playtime;

        public Video(string title, float price, float playtime) : base(title, price)
        {
            this.playtime = playtime;
        }
        
        public float palytime { get; set; }
       
        public override string Display()
        {
           return $"The title of the video is {this.title} for price {this.price} and playtime is {this.playtime}";
        }


    }
    class PublicationTest
    {
        public static void Main()
        {
            Book b1 = new Book("Harry Potter",255,252);
            Video v1 = new Video("Harry Potter", 600, 132);
            Console.WriteLine(b1.Display());
            Console.WriteLine(v1.Display());
            
            
        }
    }
}
