using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS_Class_Lib;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        List<Book> books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addUserOnClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(userIDTextBox.Text);
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;

            User dummy = new User(id, name, address);
            users.Add(dummy);
            MessageBox.Show("User has been added successfully!");
        }

        private void addBookOnClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(bookIDTextBox.Text);
            string title = bookTitleTextBox.Text;
            string author = authorTextBox.Text;
            string publisher = publisherTextBox.Text;
            int quantity = Convert.ToInt32(quantityTextBox.Text);

            if(quantity<0)
            {
                MessageBox.Show("Quantity can not be negative.");
                return;
            }

            Book dummy = new Book(id, title, author, publisher, quantity);

            books.Add(dummy);
            MessageBox.Show("Book has been added successfully!");
        }

        private void bookShowOnClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(bookIDShowTextBox.Text);
            bool flag = false;
            foreach(Book book in books)
            {
                if(book.id == id)
                {
                    flag = true;
                    bookIDLabel.Text = "Book ID:" + " " + book.id.ToString();
                    bookTitleLabel.Text = "Book Title:" + " " + book.title;
                    authorLabel.Text = "Author:" + " " + book.author;
                    publisherLabel.Text = "Publisher:" + " " + book.publisher;
                    quantityLabel.Text = "Quantity:" + " " + book.quantity.ToString();
                }
            }

            if (flag == false)
            {
                MessageBox.Show("Book could not be found!");
            }
        }

        private void showUserOnClick(object sender, EventArgs e)
        {
            
        }

        private void showUserHistoryOnClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(userIDShowTextBox.Text);
            User dummy = new User();
            bool flag = false;
            foreach (User user in users)
            {
                if (user.id == id)
                {
                    flag = true;
                    dummy = user;
                    break;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("User could not be found!");
            }
            userListBox.Items.Clear();
            for(int i = 0; i<dummy.books.Count;i++)
            {
                int id_book = dummy.books[i];
                for(int j = 0;j<books.Count;j++)
                {
                    if(books[j].id==id_book)
                    {
                        userListBox.Items.Add(books[j].history());
                    }
                }
            }
        }

        private bool userExists(int id)
        {
            foreach(User user in users)
            {
                if(user.id==id)
                {
                    return true;
                }
            }
            return false;
        }
        private bool bookExists(int id)
        {
            foreach (Book book in books)
            {
                if (book.id == id)
                {
                    return true;
                }
            }
            return false;
        }

        private void borrowOnClick(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(userIDBorrowTextBox.Text);
            int bookID = Convert.ToInt32(bookIDBorrowTextBox.Text);

            if(bookExists(bookID) && userExists(userID))
            {
                foreach(Book book in books)
                {
                    if(book.id == bookID)
                    {
                        if(book.quantity < 1)
                        {
                            MessageBox.Show("Not enough item in stock.");
                            break;
                        }
                        book.quantity -= 1;
                        foreach (User user in users)
                        {
                            if (user.id == userID)
                            {
                                user.books.Add(bookID);
                                MessageBox.Show("Book has been added to the user.");
                            }
                        }
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Input.");
            }
            

        }
    }
}
