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
    public partial class Edit_ContactsForm : Form
    {
        GroupClass group = new GroupClass(); //Loads the Group class
        Contact contact = new Contact(); //Loads the Contact class
        myDataBase myDB = new myDataBase(); //Loads the myDataBase class
        StandardPhoto sPhoto = new StandardPhoto(); //Loads the StandardPhoto class
        LoadInformation load = new LoadInformation(); //Loads the LoadInformation class

        bool hasSelectedPhoto = true; //creates a bool if the customphoto is used

        public Edit_ContactsForm()
        {
            InitializeComponent();
        }

        //If click the SelectContact Button
        private void SelectContactButton_Click(object sender, EventArgs e)
        { 
            hasSelectedPhoto = true; //sets the bool to true, the custom photo should be used
            SelectContactForm selectContactForm = new SelectContactForm(); //Loads the SelctContactForm
            selectContactForm.ShowDialog(this); //Shows the selectContactform over this form

            try //Catches if theres an error
            {
                int contactID = Convert.ToInt32(selectContactForm.dataGrid.CurrentRow.Cells[0].Value.ToString()); //gets the contactID from te database
                DataTable dataTable = contact.getContactByID(contactID); //sets the datatable to the contacts ID

                //Edits the Contact and gets its information fro the text boxes
                load.EditContacts(contact, contactID, IDtextbox, fnameBox, lnameBox, SelectGroupBox, phoneBox, emailBox, addressBox, photoBox);
            }
            catch(Exception ex) //If there is an error then show error message
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        //when the form loads
        private void Edit_ContactsForm_Load(object sender, EventArgs e)
        {
            //sets the datasouce of the alternatives of the groupbox from the database information
            SelectGroupBox.DataSource = group.getGroups(GlobalData.GlobalUserId);
            SelectGroupBox.DisplayMember = "name";
            SelectGroupBox.ValueMember = "id";

            timer1.Interval = 100; //Sets interval of the timer to 100
            timer1.Start(); //Starts the timer
        }

        //Creates a function to Update the photo in a form
        public void UpdatePhoto()
        {
            load.UpdatePhoto(IDtextbox, photoBox); //Updates the photes and calls the function to process it
        }

        //if click add contac button
        private void addContactButton_Click(object sender, EventArgs e)
        {
            UpdatePhoto(); //Update Photo

            //Strings for each text box to add contact information
            string fname = fnameBox.Text;
            string lname = lnameBox.Text;
            string phone = phoneBox.Text;
            string address = addressBox.Text;
            string email = emailBox.Text;

            //if the picturebox has aimage and a group has been selected
            if (photoBox.Image != null && SelectGroupBox.SelectedValue != null) 
            {

                int contactID = Convert.ToInt32(IDtextbox.Text); //sets the contactID to from the texbox 
                int groupID = (int)SelectGroupBox.SelectedValue; //Sets the groupID from the selected group

                //creates a memorystream for the photo and saves the photo
                MemoryStream photo = new MemoryStream();
                photoBox.Image.Save(photo, photoBox.Image.RawFormat);

                //If all boxes has information then upload the information and replace it in the database
                if (contact.editContact(contactID,fname,lname,groupID,phone,email,address,photo))
                {
                    if(MessageBox.Show("Contact has been updated", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.Close(); //Closes this this form
                    }

                }
                else //else show error message
                {
                    MessageBox.Show("Error editing contact", "Error editing Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //If not all field have information then show error message
            {
                MessageBox.Show("Failed to edit Contact, Fields are empty", "Error Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //If click the increase photo index button
        private void IncreasePhotoIndex_Click(object sender, EventArgs e)
        {
            hasSelectedPhoto = false; //then the customphoto should not be used and the next photo appears
            //IF the current index isnt larger then the amounts of photos in the list
            if (sPhoto.currentIndex < sPhoto.photos.Count - 1)
            {
                sPhoto.currentIndex++; //Increase the photo index
            }
            else if (sPhoto.currentIndex <= 7) //If the photo index is 7 or larger then set the index to 0
            {
                sPhoto.currentIndex = 0;
            }
        }

        //If click the Decrease Photo indexx
        private void DecreasePhotoIndex_Click(object sender, EventArgs e)
        {
            hasSelectedPhoto = false; //Sets the bool to false
            if (sPhoto.currentIndex > 0) //If the current photo index is larger larger than 0
            {
                sPhoto.currentIndex--; //decrease the current photo index
            }
            else if (sPhoto.currentIndex >= 0) //If the photo index is 0 or smaller thens et the current index to 7 (custom photo)
            {
                sPhoto.currentIndex = 7;
            }
        }

        //if user clicks on the photo
        private void photoBox_Click(object sender, EventArgs e)
        {
            if (sPhoto.currentIndex == 7) //If the photo is 7(custom photo)
            {
                hasSelectedPhoto = true; //Set the bool to true

                //opens a file dialog to choose the file to use for the profile photo
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Select Image(*.jpg; *.png;* .gif) |*.jpg; *.png; *.gif"; //Suported file extensions

                if (openFileDialog.ShowDialog() == DialogResult.OK) //if presses ok in the Dialog
                {
                    photoBox.Image = Image.FromFile(openFileDialog.FileName); //change the photo of the photo box to the image of the file
                }
                else if (photoBox.Image != sPhoto.photos[6]) //If the photo index isnt the custom photos index then
                {
                    hasSelectedPhoto = false; //Sets the bool to false
                }
            }
        }

        //for each tick of the timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hasSelectedPhoto == false) //if false
            {
                photoBox.Image = sPhoto.photos[sPhoto.currentIndex]; //Sets the photo of the picturebox to the current indexs photo in the list

            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes this form
        }
    }
}
