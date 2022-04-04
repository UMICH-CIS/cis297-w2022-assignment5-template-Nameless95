using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayQueryResult
{
    public partial class TitleQueries : Form
    {
        public TitleQueries()
        {
            InitializeComponent();
        }

        private BooksExamples.BooksEntities dbcontext = new BooksExamples.BooksEntities();
        private void TitleQueries_Load(object sender, EventArgs e)
        {
            dbcontext.Titles.OrderBy(titles => titles.Title1).Load();

            titleBindingSource.DataSource = dbcontext.Titles.Local;
        }

   

        private void titleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }

        private void searchbutton_Click(object sender, EventArgs e)
        {

            titleBindingSource.DataSource = dbcontext.Titles.Local.Where(title => title.Title1.Contains(userinput.Text)).OrderBy(title => title.Title1);
            titleBindingSource.MoveFirst();

        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            dbcontext.Titles.OrderBy(titles => titles.Title1).Load();

            titleBindingSource.DataSource = dbcontext.Titles.Local;

        }
    }
}
