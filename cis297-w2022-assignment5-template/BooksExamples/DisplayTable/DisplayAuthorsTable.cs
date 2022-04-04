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

namespace DisplayTable
{
  
    public partial class DisplayAuthorsTable : Form
    {
        private bool searcht = true;
        public DisplayAuthorsTable()
        {
            InitializeComponent();
        }

        //Entity Framework DbContext
        private BooksExamples.BooksEntities dbcontext = new BooksExamples.BooksEntities();
        //load data from database into DataGridView
        private void DisplayAuthorsTable_Load(object sender, EventArgs e)
        {
            if (searcht)
            {
                //load Authors table ordered by LastName then FirstName
                dbcontext.Authors
                    .OrderBy(author => author.LastName)
                    .ThenBy(author => author.FirstName)
                    .Load();
                //specify datasource for authorBindingSource
                authorBindingSource.DataSource = dbcontext.Authors.Local;
            }

         
        }
        private void authorBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

            if (searcht)
            {
                //load Authors table ordered by LastName then FirstName
                dbcontext.Authors
                    .OrderBy(author => author.LastName)
                    .ThenBy(author => author.FirstName)
                    .Load();
                //specify datasource for authorBindingSource
                authorBindingSource.DataSource = dbcontext.Authors.Local;
            }
        }

        
        private void authorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            authorBindingSource.EndEdit();
            try
            {
                dbcontext.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException)
            {
                MessageBox.Show("FirstName and LastName must contain values", "Entity Validation Exception");
            }
        }

        private void authorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }






        private void DisplayAuthorsTable_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            searcht = false;
            authorBindingSource.DataSource = dbcontext.Authors.Local.Where(author => author.LastName.StartsWith(userinput.Text)).OrderBy(author => author.LastName).ThenBy(author => author.FirstName);
            authorBindingSource.MoveFirst();
           
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            searcht = true;
            //load Authors table ordered by LastName then FirstName
            dbcontext.Authors
                .OrderBy(author => author.LastName)
                .ThenBy(author => author.FirstName)
                .Load();
            //specify datasource for authorBindingSource
            authorBindingSource.DataSource = dbcontext.Authors.Local;
        }
    }
}
