using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace HashTableWindowsApp
{
    public partial class BookInfoUI : Form
    {
        public BookInfoUI()
        {
            InitializeComponent();
        }

        Hashtable aHashtable = new Hashtable();
        Book aBook = new Book();
        private void addBookButton_Click(object sender, EventArgs e)
        {

            aBook.bookIsbn = Convert.ToInt32(isbnTextBox);
            aBook.bookInformation = bookDetailsListBox.Text;
            aHashtable.Add(aBook.bookIsbn, aBook.bookInformation);
            MessageBox.Show("Add SuccessFully");

            isbnTextBox.Text = "";
            bookDetailsListBox.Text = "";
            
        }

        private void findButton_Click(object sender, EventArgs e)
        {

            aBook.bookIsbn = Convert.ToInt32(searchIsbnTextBox.Text);
            string bookdetails = (string)aHashtable[aBook.bookIsbn];
            bookNameListBox.Items.Add(bookdetails);
           
            
         
        }
    }
}
