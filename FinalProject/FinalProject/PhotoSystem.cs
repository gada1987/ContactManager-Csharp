using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    class PhotoSystem
    {
        //System to get the current photos to be used for the pre used and saved profile photos

        //Create a list for the bitmaps
        public List<Bitmap> photos = new List<Bitmap>();

        //Open all the bitmaps required
        private Bitmap photo1 = new Bitmap(@"images\windowsphoto.png");
        private Bitmap photo2 = new Bitmap(@"images\windowsphoto_black.png");
        private Bitmap photo3 = new Bitmap(@"images\windowsphoto_blue.png");
        private Bitmap photo4 = new Bitmap(@"images\windowsphoto_brown.png");
        private Bitmap photo5 = new Bitmap(@"images\windowsphoto_purple.png");
        private Bitmap photo6 = new Bitmap(@"images\windowsphoto_orange.png");
        private Bitmap photo7 = new Bitmap(@"images\windowsphoto_red.png");
        private Bitmap customBitmap = new Bitmap(@"images\customphoto.png");

        //Adds all the photos to the list and assigns it to a photobox
        public void LoadPhotoSystem(PictureBox photoBox1, PictureBox photoBox2, PictureBox photoBox3, PictureBox photoBox4, PictureBox photoBox5, PictureBox photoBox6, PictureBox photoBox7, PictureBox CustomPhotoBox)
        {
            photos.Add(photo1);
            photos.Add(photo2);
            photos.Add(photo3);
            photos.Add(photo4);
            photos.Add(photo5);
            photos.Add(photo6);
            photos.Add(photo7);

            photoBox1.Image = photos[0];
            photoBox2.Image = photos[1];
            photoBox3.Image = photos[2];
            photoBox4.Image = photos[3];
            photoBox5.Image = photos[4];
            photoBox6.Image = photos[5];
            photoBox7.Image = photos[6];

            CustomPhotoBox.Image = customBitmap;
        }

        //Sets the photo to the first one in the list
        public void SetPhoto_1(UserCheck user, EditUserProfileForm editUserProfileForm, PictureBox photoBox1)
        {
            //sets the image to a picturebox and creates a memorystream and updates the profile photo and saves its
            photoBox1.Image = photos[0];
            MemoryStream photoStream = new MemoryStream();
            photoBox1.Image.Save(photoStream, photoBox1.Image.RawFormat);
            user.UpdateUserProfilePhoto(GlobalData.GlobalUserId, photoStream);
            editUserProfileForm.photoBox.Image = photoBox1.Image;
        }

        //Sets the photo to the second one in the list
        public void SetPhoto_2(UserCheck user, EditUserProfileForm editUserProfileForm, PictureBox photoBox2)
        {
            photoBox2.Image = photos[1];
            MemoryStream photoStream = new MemoryStream();
            photoBox2.Image.Save(photoStream, photoBox2.Image.RawFormat);
            user.UpdateUserProfilePhoto(GlobalData.GlobalUserId, photoStream);
            editUserProfileForm.photoBox.Image = photoBox2.Image;
        }

        //Sets the photo to the third one in the list
        public void SetPhoto_3(UserCheck user, EditUserProfileForm editUserProfileForm, PictureBox photoBox3)
        {
            photoBox3.Image = photos[2];
            MemoryStream photoStream = new MemoryStream();
            photoBox3.Image.Save(photoStream, photoBox3.Image.RawFormat);
            user.UpdateUserProfilePhoto(GlobalData.GlobalUserId, photoStream);
            editUserProfileForm.photoBox.Image = photoBox3.Image;
        }

        //Sets the photo to the fourth image in the list
        public void SetPhoto_4(UserCheck user, EditUserProfileForm editUserProfileForm, PictureBox photoBox4)
        {
            photoBox4.Image = photos[3];
            MemoryStream photoStream = new MemoryStream();
            photoBox4.Image.Save(photoStream, photoBox4.Image.RawFormat);
            user.UpdateUserProfilePhoto(GlobalData.GlobalUserId, photoStream);
            editUserProfileForm.photoBox.Image = photoBox4.Image;
        }

        //Sets the photo to the fifth image in the list
        public void SetPhoto_5(UserCheck user, EditUserProfileForm editUserProfileForm, PictureBox photoBox5)
        {
            photoBox5.Image = photos[4];
            MemoryStream photoStream = new MemoryStream();
            photoBox5.Image.Save(photoStream, photoBox5.Image.RawFormat);
            user.UpdateUserProfilePhoto(GlobalData.GlobalUserId, photoStream);
            editUserProfileForm.photoBox.Image = photoBox5.Image;
        }

        //Set the photo the sixth image of the list
        public void SetPhoto_6(UserCheck user, EditUserProfileForm editUserProfileForm, PictureBox photoBox6)
        {
            photoBox6.Image = photos[5];
            MemoryStream photoStream = new MemoryStream();
            photoBox6.Image.Save(photoStream, photoBox6.Image.RawFormat);
            user.UpdateUserProfilePhoto(GlobalData.GlobalUserId, photoStream);
            editUserProfileForm.photoBox.Image = photoBox6.Image;
        }
        //Set the seventh image of the list to the photobox
        public void SetPhoto_7(UserCheck user, EditUserProfileForm editUserProfileForm, PictureBox photoBox7)
        {
            photoBox7.Image = photos[6];
            MemoryStream photoStream = new MemoryStream();
            photoBox7.Image.Save(photoStream, photoBox7.Image.RawFormat);
            user.UpdateUserProfilePhoto(GlobalData.GlobalUserId, photoStream);
            editUserProfileForm.photoBox.Image = photoBox7.Image;
        }
    }
}
