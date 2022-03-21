using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Login_Register_Form : Form
    {
        //Creates bool for Custom photo and if the Register part should be used or not
        private bool hasSelectedPhoto = false;
        private bool RegisterFormBool = true;

        //Loads a classes required
        myDataBase myDB = new myDataBase();
        UserCheck user = new UserCheck();
        StandardPhoto sPhoto = new StandardPhoto();
        Operations operations = new Operations();
        Login_RegisterClass login_registerClass = new Login_RegisterClass();

        public Login_Register_Form()
        {
            InitializeComponent();
            registerTimer.Interval = 1; //sets the register timer interval to 1
        }

        //For each tick of the registerTimer
        private void registerTimer_Tick(object sender, EventArgs e)
        { 
            //If the registerform should be used then
            if (RegisterFormBool == true)
            {
                //as long as the current postion isnt equal to -410 then subtract -10 from its position to get to the Register form
                if (panel1.Location.Y > -410)
                {
                    createnewAccountTxt.Visible = true;
                    panel1.Location = new Point(panel1.Location.X, panel1.Location.Y - 10);
                }
                else
                {
                    //If position is equal to -410 or smaller then stop the timer and stop
                    registerTimer.Stop();
                    RegisterFormBool = false;
                }
            }
            else if(RegisterFormBool == false) //If the register form should not be used then add +10 to the position to get to the login form
            {
                if (panel1.Location.Y < 65)
                {
                    createnewAccountTxt.Visible = false;
                    panel1.Location = new Point(panel1.Location.X, panel1.Location.Y + 10);
                }
                else
                {
                    //Stop the timer and set the bool to true
                    registerTimer.Stop();
                    RegisterFormBool = true;
                }
            }
        }

        //IF click the GOtoRegisterformLabel then start the register timer
        private void GoToTheRegisterForm_Click(object sender, EventArgs e)
        {
            registerTimer.Start();
        }

        //If click the photobox picturebox
        private void photoBox_Click(object sender, EventArgs e)
        {
            //IF the current photo index equals 7 then open a file dialog and set the photo to its choosen file
            if (sPhoto.currentIndex == 7)
            {
                hasSelectedPhoto = true;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Select Image(*.jpg; *.png;* .gif) |*.jpg; *.png; *.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    photoBox.Image = Image.FromFile(openFileDialog.FileName);
                }
                else if (photoBox.Image != sPhoto.photos[6]) //IF the photoimage isnt equal to the image 6 image in the list
                {
                    hasSelectedPhoto = false; //Set the bool to false
                }
            }
        }

        //IF click the label to return to the login form then start the timer again
        private void GoToTheLoginForm_Click(object sender, EventArgs e)
        {
            registerTimer.Start();
        }

        //Minimize the window state
        private void Minimizebutton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseProgram_Click(object sender, EventArgs e)
        {
            this.Close(); //Close this form/program
        }

        //If click the register button then open the register function
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            login_registerClass.Register(this, operations, user, firstnameTxtBox, lastnameTxtBox, usernameAddTxtBox, passwordAddTxtBox, photoBox);
        }

        //If click the login button the open the function to login
        private void LoginButton_Click(object sender, EventArgs e)
        {
            login_registerClass.Login(this, operations, usernameTxtBox, passwordTxtBox);
        }

        //When the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            //Set the interval to 100 and start the timer
            timer1.Interval = 100;
            timer1.Start();

            //IF the customphoto should not be used then set the image to the current photo index
            if (hasSelectedPhoto == false)
            {
                photoBox.Image = sPhoto.photos[sPhoto.currentIndex];
            }
        }

        //If click the > button the change the photo to the next in the list
        private void IncreasePhotoIndex_Click(object sender, EventArgs e)
        {
            hasSelectedPhoto = false;
            if (sPhoto.currentIndex < sPhoto.photos.Count - 1) //as lpng as the index don't go over the count-1 of the list
            {
                sPhoto.currentIndex++; //Add to the current photo índex/next photo
            }
            else if (sPhoto.currentIndex <= 7) //If the photo index is 7 or larger
            {
                sPhoto.currentIndex = 0; //set the index to 0
            }
        }

        //if press the decreasephoto index button then decrease the photo index and change the photo to the previous photo
        private void DecreasePhotoIndex_Click(object sender, EventArgs e)
        {
            hasSelectedPhoto = false;
            if (sPhoto.currentIndex > 0) //if the index is bigger then 0 then subtract one
            {
                sPhoto.currentIndex--;
            }
            else if (sPhoto.currentIndex <= 0) //If the current index is 0 or smaller
            {
                sPhoto.currentIndex = 7;
            }
        }

        //for each tick of the timer set the image to the correct one
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hasSelectedPhoto == false)
            {
                photoBox.Image = sPhoto.photos[sPhoto.currentIndex];
            }
        }
    }
}