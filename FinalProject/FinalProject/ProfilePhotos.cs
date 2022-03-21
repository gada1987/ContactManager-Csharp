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
    public partial class ProfilePhotos : Form
    {
        //Loads the classes
        EditUserProfileForm editUserProfileForm = new EditUserProfileForm();
        UserCheck user = new UserCheck();
        PhotoSystem photoSystem = new PhotoSystem();

        public ProfilePhotos()
        {
            InitializeComponent();
        }

        //when the form loads load the Photo System photos
        private void ProfilePhotos_Load(object sender, EventArgs e)
        {
            photoSystem.LoadPhotoSystem(photoBox1, photoBox2, photoBox3, photoBox4, photoBox5, photoBox6, photoBox7, CustomPhotoBox);
        }

        //when click the 8th picturebox then open a file dialog and choose it for then profile photo
        private void CustomPhotoBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Select Image(*.jpg; *.png;* .gif) |*.jpg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CustomPhotoBox.Image = Image.FromFile(openFileDialog.FileName);

                //creates a memostream and saves it to the database and assigns it the the user
                MemoryStream photoStream = new MemoryStream();
                CustomPhotoBox.Image.Save(photoStream, CustomPhotoBox.Image.RawFormat);
                user.UpdateUserProfilePhoto(GlobalData.GlobalUserId, photoStream);
                editUserProfileForm.photoBox.Image = CustomPhotoBox.Image;
                this.Close(); //Closes the form
            }
        }

        //if click the picturebox 1 then change it to its photo
        private void photoBox1_Click(object sender, EventArgs e)
        {
            photoSystem.SetPhoto_1(user, editUserProfileForm, photoBox1);
            this.Close();
        }

        //if click the picturebox 2 then change it to its photo
        private void photoBox2_Click(object sender, EventArgs e)
        {
            photoSystem.SetPhoto_2(user, editUserProfileForm, photoBox2);
            this.Close();
        }

        //if click the picturebox 3 then change it to its photo
        private void photoBox3_Click(object sender, EventArgs e)
        {
            photoSystem.SetPhoto_3(user, editUserProfileForm, photoBox3);
            this.Close();
        }

        //if click the picturebox 4 then change it to its photo
        private void photoBox4_Click(object sender, EventArgs e)
        {
            photoSystem.SetPhoto_4(user, editUserProfileForm, photoBox4);
            this.Close();
        }

        //if click the picturebox 5 then change it to its photo
        private void photoBox5_Click(object sender, EventArgs e)
        {
            photoSystem.SetPhoto_5(user, editUserProfileForm, photoBox5);
            this.Close();
        }

        //if click the picturebox 6 then change it to its photo
        private void photoBox6_Click(object sender, EventArgs e)
        {
            photoSystem.SetPhoto_6(user, editUserProfileForm, photoBox6);
            this.Close();
        }

        //if click the picturebox 7 then change it to its photo
        private void photoBox7_Click(object sender, EventArgs e)
        {
            photoSystem.SetPhoto_7(user, editUserProfileForm, photoBox7);
            this.Close();
        }

        //if click the X button then close the form
        private void close_(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
