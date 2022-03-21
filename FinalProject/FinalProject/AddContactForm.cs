using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AddContactForm : Form
    {
        GroupClass group = new GroupClass(); //Load the GroupClass
        Contact contact = new Contact(); //Load Contact class
        StandardPhoto sPhoto = new StandardPhoto(); //Load StandardPhoto class
        bool hasSelectedPhoto = false; //Create bool to determine if custom photo should be used

        public AddContactForm()
        {
            InitializeComponent();
        }

        private void addContactButton_Click(object sender, EventArgs e)
        {
            //creates a string for each textbox in the form
            string fname = fnameBox.Text;
            string lname = lnameBox.Text;
            string phone = phoneBox.Text;
            string address = addressBox.Text;
            string email = emailBox.Text;
            int userID = GlobalData.GlobalUserId; //Creates a int for the users ID

            //If the Box of the photo isn't empty and a group has been selected then continue
            if(photoBox.Image != null && SelectGroupBox.SelectedValue != null)
            {
                int groupID = (int)SelectGroupBox.SelectedValue; //Grabs the groups ID

                MemoryStream photo = new MemoryStream(); //Creats a stream for the photo
                photoBox.Image.Save(photo, photoBox.Image.RawFormat); //saves the photo

                //If All textboxes has some information then continue
                if(contact.insertContact(fname,lname,userID,groupID,phone,email,address, photo)) 
                {
                    //Shows a message
                    if(MessageBox.Show("Contacted added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.Close(); //Closes this form
                    }      
                }
                else //If some box has no information in it then show error message
                {
                    MessageBox.Show("Error Adding Contact", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //If no group has been selected or the no image has been selected
            {
                MessageBox.Show("Failed to Add Contact, Fields are empty", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void SelectGroupBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //timer for the image system
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hasSelectedPhoto == false) //If not true then the custom photo should not be used and instead the picturebox gets a photo from the list of standard images
            {
                photoBox.Image = sPhoto.photos[sPhoto.currentIndex]; //gives the contact a photo depending on what index is choosen
            }
        }

        //when form is loaded
        private void AddContactForm_Load(object sender, EventArgs e)
        { 
            //the Select Group box gets the information of the database
            SelectGroupBox.DataSource = group.getGroups(GlobalData.GlobalUserId); //Gets the group information depending on what userid
            SelectGroupBox.DisplayMember = "name"; //Gives the name column from database
            SelectGroupBox.ValueMember = "id"; //gives the id column from database
            timer1.Interval = 100; //Sets the interval of the photo timer to 100
            timer1.Start(); //Starts the timer
        }

        private void photoBox_Click(object sender, EventArgs e)
        {
            if(sPhoto.currentIndex == 7) //If the current photo index is 7 
            {
                hasSelectedPhoto = true; //IF true then custom photo should be used
                OpenFileDialog openFileDialog = new OpenFileDialog(); //Opens a file dialog to choose a png
                openFileDialog.Filter = "Select Image(*.jpg; *.png;* .gif) |*.jpg; *.png; *.gif"; //Supported file extensions

                if (openFileDialog.ShowDialog() == DialogResult.OK) //If click ok in the dialog then
                {
                    photoBox.Image = Image.FromFile(openFileDialog.FileName); //Sets the photo to the choosen file
                }
                else if (photoBox.Image != sPhoto.photos[6]) //else
                {
                    hasSelectedPhoto = false; //Should not use custom photo
                }
            }
        }

        //If click > button then
        private void IncreasePhotoIndex_Click(object sender, EventArgs e)
        {
            //If the current photo index is more than the current photos -1 then
            if (sPhoto.currentIndex < sPhoto.photos.Count - 1)
            {
                sPhoto.currentIndex++; //increase the photo index and sets the photo to the next bitmap in the list
            }
            else if (sPhoto.currentIndex <= 7) //If the index is larger or equal to 7 then set the image back to the beginning (0)
            {
                sPhoto.currentIndex = 0;
            }
        }

        //If click < button then
        private void DecreasePhotoIndex_Click(object sender, EventArgs e)
        {
            //if the current photo index is bigger than 0 then
            if (sPhoto.currentIndex > 0)
            {
                sPhoto.currentIndex--; //Decrease the photo index and change photo
            }
            else if (sPhoto.currentIndex >= 0) //IF the photo is 0 or smaller then set the photo index to the custom photo index (7)
            {
                sPhoto.currentIndex = 7;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); //close this form
        }
    }
}
