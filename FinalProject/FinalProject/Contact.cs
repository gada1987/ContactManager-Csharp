using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    class Contact
    {
        GroupClass group = new GroupClass(); //Load MyGroupClass
        myDataBase myDB = new myDataBase(); //Load myDataBase class

        //Function to inserttheContact into the database
        public bool insertContact(string fname, string lname, int userID, int groupID, string phone, string email, string address, MemoryStream Photo)
        {
            //Command to insert First name, last name, groupid, phone, email, address, photo and users id into the database
            MySqlCommand command = new MySqlCommand("INSERT INTO `contacts`(`fname`, `lname`, `group_id`, `phone`, `email`, `address`, `photo`, `userid`) VALUES (@fn, @ln, @gid, @phn, @mail, @address, @photo, @uid)", myDB.getConnection);

            //ADDS THE information to the database from the string/different variables
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@gid", MySqlDbType.Int32).Value = groupID;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@photo", MySqlDbType.Blob).Value = Photo.ToArray();
            command.Parameters.Add("@uid", MySqlDbType.Int32).Value = userID;


            myDB.OpenConnection(); //opens a connection to the database

            if (command.ExecuteNonQuery() == 1) //If a errors happens
            {  
                myDB.CloseConnection(); //Close the connection
                return true; 
            }
            else
            {
                myDB.CloseConnection(); //Close the connection
                return false;
            }
        }

        //Creates a funciton to edit the contact
        public bool editContact(int ID, string fname, string lname, int groupID, string phone, string email, string address, MemoryStream Photo)
        {
            //UPDATES THE FOLLING OBJECTS IN THE DATABASE, First name, lastname, groupid, phone, email, address and photo
            MySqlCommand command = new MySqlCommand("UPDATE `contacts` SET `fname`=@fn,`lname`=@ln,`group_id`=@gid,`phone`=@phn,`email`=@mail,`address`=@address,`photo`=photo WHERE `id`=@id", myDB.getConnection);

            //Adds the information from the variables
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@gid", MySqlDbType.Int32).Value = groupID;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@photo", MySqlDbType.Blob).Value = Photo.ToArray();
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = ID;


            myDB.OpenConnection(); //opens a connection to the database

            if (command.ExecuteNonQuery() == 1)
            {
                myDB.CloseConnection(); //closes the connection to the database
                return true;
            }
            else
            {
                myDB.CloseConnection(); //Closes the connection to the database
                return false;
            }
        }

        //Creates a datvase to see the current information the the rows of the database
        public DataTable selectContactList(MySqlCommand command)
        {
            //gets the current connection to the database
            command.Connection = myDB.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            //Creates a datatable for from the database
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }

        //Creates a function to the the contactsID
        public DataTable getContactByID(int contactID)
        {
            //Mysql command to get the informatin: ID, first name , lastname, groupid, phone, email, adddress, photo, user id from the database depending on the users id
            MySqlCommand command = new MySqlCommand("SELECT `id`, `fname`, `lname`, `group_id`, `phone`, `email`, `address`, `photo`, `userid` FROM `contacts` WHERE `id`=@id", myDB.getConnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = contactID; //Gets the information depening on that ID the user has, to return the right information
            command.Connection = myDB.getConnection; //sets the commands connection to the current database connection

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            
            //creates a datatable with the information of the database rows
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }

        //Creates a function to delete the contact
        public bool deleteContact(int contactID)
        {
            //DELETES THE ROW WITH INFORMATION depending on the users ID
            MySqlCommand command = new MySqlCommand("DELETE FROM `contacts` WHERE `id`=@id", myDB.getConnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = contactID;

            myDB.OpenConnection(); //opens a connection to the database

            if (command.ExecuteNonQuery() == 1)
            {
                myDB.CloseConnection(); //Closes the connection 
                return true;
            }
            else
            {
                myDB.CloseConnection(); //Closes the connection
                return false;
            }
        }

        //creates a function to load the contactList to see all the users Contacts
        public void ContactListLoad(DataGridView grid, ListBox listBox)
        {
            DataGridViewImageColumn photoColumn = new DataGridViewImageColumn(); //Different settings for the photoColumn

            grid.RowTemplate.Height = 80; //Sets the height of the grid to 80

            //Mysql command to GET the information of the fistname, lastname, group name, phone, adddress and photo from the Database
            MySqlCommand command = new MySqlCommand("SELECT fname as 'first name', lname as 'last name', groups.name as 'group', phone, email, address, photo FROM contacts INNER JOIN groups on contacts.group_id = groups.id WHERE contacts.userid = @userid");
            command.Parameters.Add("@userid", MySqlDbType.Int32).Value = GlobalData.GlobalUserId;
            grid.DataSource = selectContactList(command); //Sets the grids data to the database information

            photoColumn = (DataGridViewImageColumn)grid.Columns[6]; //Sets the photocolumn to the grids column number 6
            photoColumn.ImageLayout = DataGridViewImageCellLayout.Stretch; //Sets the image of the photocolumn to STRETCH mode
            
            listBox.DataSource = group.getGroups(GlobalData.GlobalUserId); //sets the side listbox to groups of the User
            listBox.DisplayMember = "name";
            listBox.ValueMember = "id";

            listBox.SelectedItem = null;
            grid.ClearSelection(); //clears all selected cells and rows of the grid
        }

        public void SelectGroup(Contact contact, int groupID, DataGridView grid)
        {
            //mysql command to GET the information of first name, lastname, groupname, phone, email, address and photo from the Contact database
            MySqlCommand command = new MySqlCommand("SELECT fname as 'first name', lname as 'last name', groups.name as 'group', phone, email, address, photo FROM contacts INNER JOIN groups on contacts.group_id = groups.id WHERE contacts.userid = @userid AND contacts.group_id=@groupid");
            command.Parameters.Add("@userid", MySqlDbType.Int32).Value = GlobalData.GlobalUserId;
            command.Parameters.Add("@groupid", MySqlDbType.Int32).Value = groupID;


            grid.DataSource = contact.selectContactList(command); //Sets the grids data to the database information
            grid.ClearSelection();
        }

        //creats a function to search for the users in the grid, You can search on First name, last name, phone, email or address
        public void SearchUserList(TextBox txtBox, DataGridView grid)
        {
            //RETURNS the First name, lastname, groudid, phone, email, address, photo, userID from the contact database
            MySqlCommand command = new MySqlCommand("SELECT `fname`, `lname`, `group_id`, `phone`, `email`, `address`, `photo`, `userid` FROM `contacts` WHERE  `fname`=@fn OR `lname`=@ln OR `phone`=@phn OR `email`=@mail OR `address`=@address", myDB.getConnection);
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = txtBox.Text; //Sear
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = txtBox.Text;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = txtBox.Text;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = txtBox.Text;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = txtBox.Text;

            grid.DataSource = selectContactList(command); //Sets the grids information to the specific users that comes of from the search
        }

        //Creats a function for the setting of the SelectContactForm
        public void SelectContactFormLoad(DataGridView grid)
        {
            //MYsql command that gets the information from the contacts
            MySqlCommand command = new MySqlCommand("SELECT `id`, `fname`, `lname`, `group_id` as 'group_id' FROM `contacts` WHERE `userid`=@uid", myDB.getConnection);
            command.Parameters.Add("@uid", MySqlDbType.Int32).Value = GlobalData.GlobalUserId;

            Contact contact = new Contact();

            grid.DataSource = contact.selectContactList(command); //Sets the 
        }
    }
}