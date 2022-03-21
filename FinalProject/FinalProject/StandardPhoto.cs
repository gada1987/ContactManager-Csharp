using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class StandardPhoto
    {
        //loads Classes
        EditUserProfileForm editUserProfileForm = new EditUserProfileForm();
        UserCheck user = new UserCheck();

        //Creates a list for bitmaps
        public List<Bitmap> photos = new List<Bitmap>();

        //loads all bitmaps
        private Bitmap photo1 = new Bitmap(@"images\windowsphoto.png");
        private Bitmap photo2 = new Bitmap(@"images\windowsphoto_black.png");
        private Bitmap photo3 = new Bitmap(@"images\windowsphoto_blue.png");
        private Bitmap photo4 = new Bitmap(@"images\windowsphoto_brown.png");
        private Bitmap photo5 = new Bitmap(@"images\windowsphoto_purple.png");
        private Bitmap photo6 = new Bitmap(@"images\windowsphoto_orange.png");
        private Bitmap photo7 = new Bitmap(@"images\windowsphoto_red.png");
        private Bitmap photo8 = new Bitmap(@"images\customphoto.png");

        //Creates index for current photo should be used
        public int currentIndex = 0;

        //adds the bitmaps to the list
        public StandardPhoto()
        {
            photos.Add(photo1);
            photos.Add(photo2);
            photos.Add(photo3);
            photos.Add(photo4);
            photos.Add(photo5);
            photos.Add(photo6);
            photos.Add(photo7);
            photos.Add(photo8);
        }
    }
}
