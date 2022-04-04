using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoinQueries
{
    public partial class JoiningTableData : Form
    {
        public JoiningTableData()
        {
            InitializeComponent();
        }

        private void JoiningTableData_Load(object sender, EventArgs e)
        {
            var dbcontext = new BooksExamples.BooksEntities();

            var authorsAndISBNs =
                from author in dbcontext.Authors
                from book in author.Titles
                orderby book.Title1
                select new { author.FirstName, author.LastName, book.Title1 };

            outputTextBox.AppendText("Authors and titles: ");
            foreach (var element in authorsAndISBNs)
            {
                outputTextBox.AppendText($"\r\n\t{element.FirstName,-10} " +
                $"{element.LastName,-10} {element.Title1,-10}");
            }


            var authorsAndTitles =
         from book in dbcontext.Titles
         from author in book.Authors
         orderby book.Title1, author.LastName, author.FirstName
         select new { author.FirstName, author.LastName, book.Title1 };

            outputTextBox.AppendText("\r\n\r\nAuthors and titles:");
            foreach (var element in authorsAndTitles)
            {
                outputTextBox.AppendText($"\r\n\t{element.FirstName,-10} " +
                $"{element.LastName,-10} {element.Title1}");
            }


            var titlesByAuthor =
                from book in dbcontext.Titles
                orderby book.Title1 
                select new {Name = book.Title1,
               title = from author in book.Authors
                orderby author.LastName, author.FirstName
                         select author.FirstName + " "+ author.LastName
                };


            outputTextBox.AppendText("\r\n\r\nauthors grouped by title:");
            foreach (var book in titlesByAuthor)
            {
                // display author's name
                outputTextBox.AppendText($"\r\n\t{book.Name}:");

                // display titles written by that author
                foreach (var title in book.title)
                {
                    outputTextBox.AppendText($"\r\n\t\t{title}");
                }



            }



        }



    }
}
