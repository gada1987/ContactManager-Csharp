using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace FinalProject
{
    class LoadInformation
    {
        myDataBase myDB = new myDataBase(); //Loads class

        //Function to get the current Image and username of the user
        public void GetImageAndUsername(PictureBox profilePhoto, Label welcomeTxt)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable dataTable = new DataTable();

            //Mysql command to select information from the user database
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `id`=@uid", myDB.getConnection);
            command.Parameters.Add("@uid", MySqlDbType.Int32).Value = GlobalData.GlobalUserId;

            //Changs the adapters command to the mysql command
            adapter.SelectCommand = command;

            //Fils the datatable with the information
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                //Gets the current photo for the user in the database
                byte[] photo = (byte[])dataTable.Rows[0]["photo"];
                MemoryStream photostream = new MemoryStream(photo); //Creates a memorystream and returns it
                profilePhoto.Image = Image.FromStream(photostream);

                //Sets the text to the username from the database
                welcomeTxt.Text = "Welcome back (" + dataTable.Rows[0]["username"] + ")";
            }
        }

        //Function to edit the contacts
        public void EditContacts(Contact contact, int contactID, TextBox IDtextBox, TextBox fnameBox, TextBox lnameBox, ComboBox selectGroupBox, TextBox phoneBox, TextBox emailBox, TextBox addressBox, PictureBox photoBox)
        {
            //retirns the contactID to the datatable
            DataTable dataTable = contact.getContactByID(contactID);

            //returns the information from the database to the textboxes
            IDtextBox.Text = dataTable.Rows[0]["id"].ToString();
            fnameBox.Text = dataTable.Rows[0]["fname"].ToString();
            lnameBox.Text = dataTable.Rows[0]["lname"].ToString();
            selectGroupBox.SelectedValue = dataTable.Rows[0]["group_id"].ToString();
            phoneBox.Text = dataTable.Rows[0]["phone"].ToString();
            emailBox.Text = dataTable.Rows[0]["email"].ToString();
            addressBox.Text = dataTable.Rows[0]["address"].ToString();

            //Creates a memorstream for the photo and sets the photo from the datbase
            byte[] photo = (byte[])dataTable.Rows[0]["photo"];
            MemoryStream photoStream = new MemoryStream(photo);
            photoBox.Image = Image.FromStream(photoStream);
        }

        //Function to Update the photo seperatly from the contacts database
        public void UpdatePhoto(TextBox IDtextBox, PictureBox photoBox)
        {
            //Creates a memorystream and gets the contactsID from textbox
            MemoryStream photostream = new MemoryStream();
            int contactID = Convert.ToInt32(IDtextBox.Text);
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //saves the image
            photoBox.Image.Save(photostream, photoBox.Image.RawFormat);

            photoBox.Image = Image.FromStream(photostream);

            //MYSQL command to update the photo from the usersID
            MySqlCommand command = new MySqlCommand("UPDATE `contacts` SET `photo`=@photo WHERE `id`=@uid", myDB.getConnection);
            command.Parameters.Add("@photo", MySqlDbType.Blob).Value = photostream.ToArray();
            command.Parameters.Add("@uid", MySqlDbType.Int32).Value = contactID;


            myDB.OpenConnection(); //Opens a connection to the database

            if (command.ExecuteNonQuery() == 1)
            {
                myDB.CloseConnection(); //Closes the connection
            }
            else
            {
                myDB.CloseConnection(); //Closes the connection
            }
        }

        //Settings for the EditUserForm to Load
        public void EditUserFormLoad(UserCheck user, TextBox fNameChangeTxtbox, TextBox lNameChangeTxtbox, TextBox usernameChangeTxtbox, TextBox passwordChangeTxtbox)
        {
            //Datatable to get the users current ID
            DataTable dataTable = user.getUserID(GlobalData.GlobalUserId);

            //Sets the textboxes to the correct information of the current column in the database
            fNameChangeTxtbox.Text = dataTable.Rows[0][1].ToString();
            lNameChangeTxtbox.Text = dataTable.Rows[0][2].ToString();
            usernameChangeTxtbox.Text = dataTable.Rows[0][3].ToString();
            passwordChangeTxtbox.Text = dataTable.Rows[0][4].ToString();
        }
    }
}