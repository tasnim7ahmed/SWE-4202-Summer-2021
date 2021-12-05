using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Class_Lib
{
    public class Book
    {
        public int id;
        public string title;
        public string author;
        public string publisher;
        public int quantity;

        public Book(int id, string title, string author, string publisher, int quantity)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.quantity = quantity;
        }

        public string history()
        {
            return this.id.ToString() + "\t" + this.title;
        }
    }
}
