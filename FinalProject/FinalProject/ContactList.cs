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
    public partial class ContactList : Form
    {
        Contact contact = new Contact(); //Load the Contact Class
        myDataBase myDB = new myDataBase(); //Load the myDataBase class

        public ContactList()
        {
            InitializeComponent();
        }

        //when the form loads
        private void ContactList_Load(object sender, EventArgs e)
        {
            contact.ContactListLoad(dataGrid, listBox); //Loads the setting from the function
        }

        //When you click on the listbox
        private void listBox_Click(object sender, EventArgs e)
        {
            try //Catches error
            {

                if (listBox.SelectedValue != null) //If a group has been selected in the listbox
                {
                    int groupid = (Int32)listBox.SelectedValue; //gets a groupid from the selected group in the listbox
                    contact.SelectGroup(contact, groupid, dataGrid); //Selects the group and returns the correct contacts in the group
                }
            }
            catch(Exception ex) //If a error happens then a message show with the message
            {
                MessageBox.Show("ERROR: ", "ERROR" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //if press button to show all contacts
        private void ShowAllContactsLabel_Click(object sender, EventArgs e)
        {
            //Load the Contactlist_Load
            ContactList_Load(null, null);
        }

        //If user click on the datagrid
        private void dataGrid_Click(object sender, EventArgs e)
        {
            addressTxtBox.Text = dataGrid.CurrentRow.Cells[5].Value.ToString(); //shows the address of choosen contact
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close(); //Close this form
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTxtBox.Text == "") //If the search textbox is empty
            {
                ContactList_Load(null, null); //Load the ContactList_Load
            }
            else //if there is any text in the textbox then
            {
                contact.SearchUserList(searchTxtBox, dataGrid); //search for the user from the textbox and shows it in the datagrid
            }
        }
    }
}