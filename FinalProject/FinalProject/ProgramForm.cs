using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FinalProject
{
    public partial class ProgramForm : Form
    {
        //Loads the required classes
        myDataBase myDB = new myDataBase();
        GroupClass group = new GroupClass();
        LoadInformation load = new LoadInformation();

        public ProgramForm()
        {
            InitializeComponent();
        }

        //When the Form Loads
        private void ProgramForm_Load(object sender, EventArgs e)
        {
            //Gets the current photo and username from the database
            load.GetImageAndUsername(profilePhoto, welcomeTxt);

            //Sets the timer interval to 100 and starts it
            timer1.Interval = 100;
            timer1.Start();
        }

        //When click edit label
        private void editMyProfileTxt_Click(object sender, EventArgs e)
        {
            //open the form for editing profile and show it over this
            EditUserProfileForm editUserForm = new EditUserProfileForm();
            editUserForm.Show(this);
        }

        //If cick add group button
        private void AddEntergroupButtonGroupButton_Click(object sender, EventArgs e)
        {
            //get the group name to be added to the database
            string groupName = groupnameTxtbox.Text;

            //if the textbox isnt empty add the group to the database from the userID
            if (!groupName.Trim().Equals("")){
                if(!group.groupExists(groupName, "add",GlobalData.GlobalUserId)) //Checks if the groupnname already exists
                {
                    //Inserts the group into the database
                    if(group.insertGroup(groupName, GlobalData.GlobalUserId))
                    {
                        MessageBox.Show("New group created!", "Create group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else //else show error message
                    {
                        MessageBox.Show("Failed to create group", "Create group", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("This group name already exists!", "Create group", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else //If textbox has missing information then show error message
            {
                MessageBox.Show("Enter a group name", "Create group", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //Function to get the group to the lists of the form
        public void getGroups()
        {
            editGroupnameBox.DataSource = group.getGroups(GlobalData.GlobalUserId);
            editGroupnameBox.DisplayMember = "name";
            editGroupnameBox.ValueMember = "id";

            removeGroupBox.DataSource = group.getGroups(GlobalData.GlobalUserId);
            removeGroupBox.DisplayMember = "name";
            removeGroupBox.ValueMember = "id";
        }

        //IF click then the new name in textbox gets replaced in the database for the group
        private void editGroupnameButton_Click(object sender, EventArgs e)
        {
            string newGroupname = EditGroupnameTxtbox.Text;
            int groupID;

            if (editGroupnameBox.SelectedValue != null)
            {
                groupID = Convert.ToInt32(editGroupnameBox.SelectedValue.ToString());


                if (!newGroupname.Trim().Equals("") && groupID.ToString() != null)
                {
                    if (!group.groupExists(newGroupname, "edit", GlobalData.GlobalUserId, groupID)) //If the group dont exists
                    {
                        if (group.updateGroup(groupID, newGroupname)) //update the group to new name 
                        {
                            MessageBox.Show("The group name has been updated!", "Edit group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update group name", "Edit group", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("You already have group that has this name", "Edit group", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("Please enter a new group name", "Edit group", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Please select a group to edit name.", "Failed to edit group" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editGroupnameBox_DropDown(object sender, EventArgs e)
        {
            getGroups(); //get the current group names
        }

        //If click remove group button then
        private void removeGroupButton_Click(object sender, EventArgs e)
        {
            if(removeGroupBox.SelectedValue != null) //if a value in the drop down box has been selected
            { 
                int groupID = Convert.ToInt32(removeGroupBox.SelectedValue.ToString());

                //asks if user want to remove the group and if yes
                if (MessageBox.Show("Are you sure you want to remove this group?", "Remove group", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //removes the group
                    if (group.removeGroup(groupID))
                    {
                        MessageBox.Show("Group has been removed!", "Remove group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove group", "Remove group", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a group to remove!", "Failed to remove a group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //When click the remove group dropdown box then show all groups in database
        private void removeGroupBox_DropDown(object sender, EventArgs e)
        {
            getGroups();
        }

        //foreach tick update the profile photo and users username
        private void timer1_Tick(object sender, EventArgs e)
        {
            load.GetImageAndUsername(profilePhoto, welcomeTxt);
        }

        //IF cick the button then show add contact form
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddContactForm addContact = new AddContactForm();
            addContact.Show(this);
        }

        //If click the edit button then show the edit contact button
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            Edit_ContactsForm edit = new Edit_ContactsForm();
            edit.Show(this);
        }

        //If show select contact button then show the form
        private void SelectContactButton_Click(object sender, EventArgs e)
        {
            SelectContactForm selectContactForm = new SelectContactForm();
            selectContactForm.ShowDialog(this);

            //sets the currents contacts ID and sets the IDTxtbox to the ID
            try
            {
                int contactID = Convert.ToInt32(selectContactForm.dataGrid.CurrentRow.Cells[0].Value.ToString());

                IDTxtBox.Text = contactID.ToString();
            }
            catch (Exception ex) //If a error happens show error message
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        //If click the remove contact button
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            //Load class
            Contact contact = new Contact();
            try //catch error
            {
                if (!IDTxtBox.Text.Trim().Equals("")) //if ID texbox isn't empty
                {
                    //gt the contactid from the textbox and delete the contact with that ID
                    int contactID = Convert.ToInt32(IDTxtBox.Text);
                    if (contact.deleteContact(contactID))
                    {
                        MessageBox.Show("Contact has been deleted!", "Delete contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        IDTxtBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error deleting contact", "Error delete contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a contact", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex) //If error then show error message
            {
                MessageBox.Show("ERROR: " + ex.Message, "Delete contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //If click show all contacts button then open form
        private void ShowAllContacts_Click(object sender, EventArgs e)
        {
            ContactList contactList = new ContactList();
            contactList.Show(this);
        }

        //If click this button then close this form
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}