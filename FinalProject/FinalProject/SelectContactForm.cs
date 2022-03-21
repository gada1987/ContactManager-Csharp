using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class SelectContactForm : Form
    {
        //Load classes
        myDataBase myDB = new myDataBase();
        Contact contact = new Contact();

        public SelectContactForm()
        {
            InitializeComponent();
        }

        //When load this form then update the grid to the users current contacts
        private void SelectContactForm_Load(object sender, EventArgs e)
        {
            contact.SelectContactFormLoad(dataGrid);
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //if double click on any position of a row/column then close this form
        private void dataGrid_DoubleClick(object sender, EventArgs e)
        { 
            this.Close();
        }

        //if press close button then close this form
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
