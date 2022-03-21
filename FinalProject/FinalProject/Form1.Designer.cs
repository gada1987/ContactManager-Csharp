namespace FinalProject
{
    partial class Login_Register_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DecreasePhotoIndex = new System.Windows.Forms.Button();
            this.IncreasePhotoIndex = new System.Windows.Forms.Button();
            this.createnewAccountTxt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GotoTheLoginForm = new System.Windows.Forms.Label();
            this.GoToRegisterForm = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.photoBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordAddTxtBox = new System.Windows.Forms.TextBox();
            this.usernameAddTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lastnameTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstnameTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registerTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseProgram = new System.Windows.Forms.Button();
            this.Minimizebutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Location = new System.Drawing.Point(144, 227);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(211, 44);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.ForeColor = System.Drawing.Color.Black;
            this.RegisterButton.Location = new System.Drawing.Point(144, 885);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(211, 44);
            this.RegisterButton.TabIndex = 1;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.Location = new System.Drawing.Point(144, 155);
            this.passwordTxtBox.MaxLength = 16;
            this.passwordTxtBox.Multiline = true;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(211, 40);
            this.passwordTxtBox.TabIndex = 2;
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtBox.Location = new System.Drawing.Point(144, 70);
            this.usernameTxtBox.Multiline = true;
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(211, 40);
            this.usernameTxtBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DecreasePhotoIndex);
            this.panel1.Controls.Add(this.IncreasePhotoIndex);
            this.panel1.Controls.Add(this.createnewAccountTxt);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.GotoTheLoginForm);
            this.panel1.Controls.Add(this.GoToRegisterForm);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.photoBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.passwordAddTxtBox);
            this.panel1.Controls.Add(this.usernameAddTxtBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lastnameTxtBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.firstnameTxtBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.usernameTxtBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.RegisterButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Controls.Add(this.passwordTxtBox);
            this.panel1.Location = new System.Drawing.Point(12, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 971);
            this.panel1.TabIndex = 6;
            // 
            // DecreasePhotoIndex
            // 
            this.DecreasePhotoIndex.Location = new System.Drawing.Point(139, 844);
            this.DecreasePhotoIndex.Name = "DecreasePhotoIndex";
            this.DecreasePhotoIndex.Size = new System.Drawing.Size(50, 25);
            this.DecreasePhotoIndex.TabIndex = 25;
            this.DecreasePhotoIndex.Text = "<";
            this.DecreasePhotoIndex.UseVisualStyleBackColor = true;
            this.DecreasePhotoIndex.Click += new System.EventHandler(this.DecreasePhotoIndex_Click);
            // 
            // IncreasePhotoIndex
            // 
            this.IncreasePhotoIndex.Location = new System.Drawing.Point(301, 844);
            this.IncreasePhotoIndex.Name = "IncreasePhotoIndex";
            this.IncreasePhotoIndex.Size = new System.Drawing.Size(50, 25);
            this.IncreasePhotoIndex.TabIndex = 24;
            this.IncreasePhotoIndex.Text = ">";
            this.IncreasePhotoIndex.UseVisualStyleBackColor = true;
            this.IncreasePhotoIndex.Click += new System.EventHandler(this.IncreasePhotoIndex_Click);
            // 
            // createnewAccountTxt
            // 
            this.createnewAccountTxt.AutoSize = true;
            this.createnewAccountTxt.Enabled = false;
            this.createnewAccountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createnewAccountTxt.Location = new System.Drawing.Point(45, 445);
            this.createnewAccountTxt.Name = "createnewAccountTxt";
            this.createnewAccountTxt.Size = new System.Drawing.Size(319, 39);
            this.createnewAccountTxt.TabIndex = 21;
            this.createnewAccountTxt.Text = "Create new account";
            this.createnewAccountTxt.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(86, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(233, 39);
            this.label10.TabIndex = 20;
            this.label10.Text = "Account Login";
            // 
            // GotoTheLoginForm
            // 
            this.GotoTheLoginForm.AutoSize = true;
            this.GotoTheLoginForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GotoTheLoginForm.Location = new System.Drawing.Point(0, 946);
            this.GotoTheLoginForm.Name = "GotoTheLoginForm";
            this.GotoTheLoginForm.Size = new System.Drawing.Size(391, 25);
            this.GotoTheLoginForm.TabIndex = 19;
            this.GotoTheLoginForm.Text = "Already have an account? Login HERE!";
            this.GotoTheLoginForm.Click += new System.EventHandler(this.GoToTheLoginForm_Click);
            // 
            // GoToRegisterForm
            // 
            this.GoToRegisterForm.AutoSize = true;
            this.GoToRegisterForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToRegisterForm.Location = new System.Drawing.Point(47, 296);
            this.GoToRegisterForm.Name = "GoToRegisterForm";
            this.GoToRegisterForm.Size = new System.Drawing.Size(323, 25);
            this.GoToRegisterForm.TabIndex = 18;
            this.GoToRegisterForm.Text = "Don\'t have an account? Sign up!";
            this.GoToRegisterForm.Click += new System.EventHandler(this.GoToTheRegisterForm_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 800);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Photo:";
            // 
            // photoBox
            // 
            this.photoBox.Location = new System.Drawing.Point(195, 769);
            this.photoBox.Name = "photoBox";
            this.photoBox.Size = new System.Drawing.Size(100, 100);
            this.photoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoBox.TabIndex = 15;
            this.photoBox.TabStop = false;
            this.photoBox.Click += new System.EventHandler(this.photoBox_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 712);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Password:";
            // 
            // passwordAddTxtBox
            // 
            this.passwordAddTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordAddTxtBox.Location = new System.Drawing.Point(144, 701);
            this.passwordAddTxtBox.Multiline = true;
            this.passwordAddTxtBox.Name = "passwordAddTxtBox";
            this.passwordAddTxtBox.PasswordChar = '*';
            this.passwordAddTxtBox.Size = new System.Drawing.Size(211, 40);
            this.passwordAddTxtBox.TabIndex = 12;
            // 
            // usernameAddTxtBox
            // 
            this.usernameAddTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameAddTxtBox.Location = new System.Drawing.Point(144, 636);
            this.usernameAddTxtBox.Multiline = true;
            this.usernameAddTxtBox.Name = "usernameAddTxtBox";
            this.usernameAddTxtBox.Size = new System.Drawing.Size(211, 40);
            this.usernameAddTxtBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 647);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Username:";
            // 
            // lastnameTxtBox
            // 
            this.lastnameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTxtBox.Location = new System.Drawing.Point(144, 575);
            this.lastnameTxtBox.Multiline = true;
            this.lastnameTxtBox.Name = "lastnameTxtBox";
            this.lastnameTxtBox.Size = new System.Drawing.Size(211, 40);
            this.lastnameTxtBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lastname:";
            // 
            // firstnameTxtBox
            // 
            this.firstnameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTxtBox.Location = new System.Drawing.Point(144, 510);
            this.firstnameTxtBox.Multiline = true;
            this.firstnameTxtBox.Name = "firstnameTxtBox";
            this.firstnameTxtBox.Size = new System.Drawing.Size(211, 40);
            this.firstnameTxtBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "First name:";
            // 
            // registerTimer
            // 
            this.registerTimer.Tick += new System.EventHandler(this.registerTimer_Tick);
            // 
            // CloseProgram
            // 
            this.CloseProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseProgram.Location = new System.Drawing.Point(357, 9);
            this.CloseProgram.Name = "CloseProgram";
            this.CloseProgram.Size = new System.Drawing.Size(50, 50);
            this.CloseProgram.TabIndex = 7;
            this.CloseProgram.Text = "X";
            this.CloseProgram.UseCompatibleTextRendering = true;
            this.CloseProgram.UseVisualStyleBackColor = true;
            this.CloseProgram.Click += new System.EventHandler(this.CloseProgram_Click);
            // 
            // Minimizebutton
            // 
            this.Minimizebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimizebutton.Location = new System.Drawing.Point(304, 9);
            this.Minimizebutton.Margin = new System.Windows.Forms.Padding(0);
            this.Minimizebutton.Name = "Minimizebutton";
            this.Minimizebutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Minimizebutton.Size = new System.Drawing.Size(50, 50);
            this.Minimizebutton.TabIndex = 8;
            this.Minimizebutton.Text = "-";
            this.Minimizebutton.UseCompatibleTextRendering = true;
            this.Minimizebutton.UseVisualStyleBackColor = true;
            this.Minimizebutton.Click += new System.EventHandler(this.Minimizebutton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login_Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 565);
            this.Controls.Add(this.Minimizebutton);
            this.Controls.Add(this.CloseProgram);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Register_Form";
            this.Text = "Login/Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label GotoTheLoginForm;
        private System.Windows.Forms.Label GoToRegisterForm;
        private System.Windows.Forms.Timer registerTimer;
        private System.Windows.Forms.Label createnewAccountTxt;
        private System.Windows.Forms.Button CloseProgram;
        private System.Windows.Forms.Button Minimizebutton;
        private System.Windows.Forms.Button DecreasePhotoIndex;
        private System.Windows.Forms.Button IncreasePhotoIndex;
        public System.Windows.Forms.TextBox passwordTxtBox;
        public System.Windows.Forms.TextBox usernameTxtBox;
        public System.Windows.Forms.PictureBox photoBox;
        public System.Windows.Forms.TextBox passwordAddTxtBox;
        public System.Windows.Forms.TextBox usernameAddTxtBox;
        public System.Windows.Forms.TextBox lastnameTxtBox;
        public System.Windows.Forms.TextBox firstnameTxtBox;
        private System.Windows.Forms.Timer timer1;
    }
}

