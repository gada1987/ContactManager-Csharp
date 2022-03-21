using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Operations
    {
        //Function to verify the fields
        public bool VerifyFields(Login_Register_Form form, string operation)
        {
            bool check = false;

            //If the operation is = "register" then check the textboxes and if true continue
            if (operation == "register")
            {
                if (form.firstnameTxtBox.Text.Equals("") || form.lastnameTxtBox.Text.Equals("") || form.usernameAddTxtBox.Text.Equals("") || form.passwordAddTxtBox.Text.Equals("") || form.photoBox.Image == null) //If the textboxes is empty
                {
                    check = false;

                }
                else
                {
                    check = true;
                }
            }
            else if (operation == "login") //if the opeation is = "login" and the textboxes is populated then continue
            {
                if (form.usernameTxtBox.Text.Equals("") || form.passwordTxtBox.Text.Equals("")) //If the textboxes has no content
                {
                    check = false;
                }
                else
                {
                    check = true;
                }
            }
            return check;
        }

    }
}