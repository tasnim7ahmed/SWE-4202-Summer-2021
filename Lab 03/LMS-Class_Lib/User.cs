using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Class_Lib
{
    public class User
    {
        public int id;
        public string name;
        public string address;
        public List<int> books = new List<int>();

        public User()
        {
        }

        public User(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public void addBook(int id)
        {
            books.Add(id);
        }

        public void returnBook(int id)
        {
            books.Remove(id);
        }
    }
}
