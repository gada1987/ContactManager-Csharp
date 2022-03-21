using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class EditUserProfileForm : Form
    {
        //loads essentional classes
        UserCheck user = new UserCheck(); 
        myDataBase myDB = new myDataBase(); 
        LoadInformation load = new LoadInformation();

        public EditUserProfileForm()
        {
            InitializeComponent();
        }

        //If press the changeprofile photo button
        private void ChangeProfilePhotoButton_Click(object sender, EventArgs e)
        {
            //open the profile photo changer form
            ProfilePhotos profilePhotos = new ProfilePhotos();
            profilePhotos.Show();
            photoBox.Image = profilePhotos.CustomPhotoBox.Image; //set the phhotot to the customphoto image
        }

        //when the form loads
        private void EditUserProfileForm_Load(object sender, EventArgs e)
        { 
            //Load the EdituserLoad function and get the information from the database to the textboxes
            load.EditUserFormLoad(user, fNameChangeTxtbox, lNameChangeTxtbox, usernameChangeTxtbox, passwordChangeTxtbox);
            
            //sets the interval of the timer to 100 and starts it
            timer1.Interval = 100;
            timer1.Start();
        }

        //if click the updateprofilebutton
        private void updateProfilButton_Click(object sender, EventArgs e)
        {
            //Sets the string and UserID to the textboxes information
            int userID = GlobalData.GlobalUserId;
            string fname = fNameChangeTxtbox.Text;
            string lname = lNameChangeTxtbox.Text;
            string username = usernameChangeTxtbox.Text;
            string password = passwordChangeTxtbox.Text;

            //Creates a photstream for the photo and saves it
            MemoryStream photoStream = new MemoryStream();
            photoBox.Image.Save(photoStream, photoBox.Image.RawFormat);


            if(usernameChangeTxtbox.Text.Equals("") || passwordChangeTxtbox.Text.Equals("")) //if the username textbox and password textbox is empty
            {
                MessageBox.Show("Please fill in all fields!", "Edit profile info", MessageBoxButtons.OK);
            }
            else 
            {
                if (user.usernameExist(username, "edit") ) //If the username already exists then show a error message
                {
                    MessageBox.Show("This username already exists! Try another one.", "Error Edit Profile Info", MessageBoxButtons.OK);
                }
                //else if all textboxes has information the edit it to the new information and show a textmessage
                else if (user.UpdateUserProfile(userID, fname, lname, username, password, photoStream))
                {
                    MessageBox.Show("Your profile information has been updated!", "Edit Profile Info", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error", "Error Edit Profile Info", MessageBoxButtons.OK);
                }
            }

        }

        //for each tick of the timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Creates a datatable and Command for the timer and gets the current users Photo to the photobox
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable dataTable = new DataTable();

            //mysql command to GET the users Photo depending on the users ID
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `id`=@uid", myDB.getConnection);
            command.Parameters.Add("@uid", MySqlDbType.Int32).Value = GlobalData.GlobalUserId;

            adapter.SelectCommand = command;

            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                byte[] photo = (byte[])dataTable.Rows[0]["photo"]; //Select the photo from row 0 and the "photo" column
                MemoryStream photostream = new MemoryStream(photo); //creates new photostream
                photoBox.Image = Image.FromStream(photostream); //saves the image
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes this form
        }
    }
}
