using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;

namespace FinalProject
{
    class Login_RegisterClass
    {
        //Login to the database
        public void Login(Login_Register_Form form, Operations operations, TextBox usernameTxtBox, TextBox passwordTxtBox)
        {
            //Load class and create a datatable for the information
            myDataBase db = new myDataBase();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dataTabel = new DataTable();

            //mysql command to select the username and pass from the database
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `username`=@un AND `pass`=@pass", db.getConnection);

            command.Parameters.Add("@un", MySqlDbType.VarChar).Value = usernameTxtBox.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passwordTxtBox.Text;

            adapter.SelectCommand = command;

            adapter.Fill(dataTabel);

            //Open function to verify the field of the form
            if (operations.VerifyFields(form, "login"))
            {
                if (dataTabel.Rows.Count > 0)
                {
                    //get the current userid and set it to the other class
                    int userid = Convert.ToInt32(dataTabel.Rows[0][0].ToString());
                    GlobalData.setGlobalUserId(userid);

                    form.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Empty username or Password field", "Login error", MessageBoxButtons.OK);

            }
        }

        //Function to register the user to the database
        public void Register(Login_Register_Form form, Operations operations, UserCheck user, TextBox firstnameTxtBox, TextBox lastnameTxtBox, TextBox usernameAddTxtBox, TextBox passwordAddTxtBox, PictureBox photoBox)
        {
            //get the information from the textboxes and assign it to a string
            string fname = firstnameTxtBox.Text;
            string lname = lastnameTxtBox.Text;
            string username = usernameAddTxtBox.Text;
            string password = passwordAddTxtBox.Text;

            //If the operation "register" should be used then verify the fields and upload the strings to the database
            if (operations.VerifyFields(form, "register"))
            {
                //Create a photostream and save the image
                MemoryStream photo = new MemoryStream();
                photoBox.Image.Save(photo, photoBox.Image.RawFormat);

                //If the username don't exist then continue
                if (!user.usernameExist(username, "register"))
                {
                    //if all fields are populated then continue
                    if (user.insertUser(fname, lname, username, password, photo))
                    {
                        MessageBox.Show("Registration Completed Succefully!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!", "Register Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("This username already exist! Try another one.", "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Field Incomplete, Account could not be Registred!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
