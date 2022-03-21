namespace FinalProject
{
    partial class EditUserProfileForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.updateProfilButton = new System.Windows.Forms.Button();
            this.passwordChangeTxtbox = new System.Windows.Forms.TextBox();
            this.usernameChangeTxtbox = new System.Windows.Forms.TextBox();
            this.lNameChangeTxtbox = new System.Windows.Forms.TextBox();
            this.fNameChangeTxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeProfilePhotoButton = new System.Windows.Forms.Button();
            this.photoBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.updateProfilButton);
            this.panel1.Controls.Add(this.passwordChangeTxtbox);
            this.panel1.Controls.Add(this.usernameChangeTxtbox);
            this.panel1.Controls.Add(this.lNameChangeTxtbox);
            this.panel1.Controls.Add(this.fNameChangeTxtbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ChangeProfilePhotoButton);
            this.panel1.Controls.Add(this.photoBox);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 301);
            this.panel1.TabIndex = 3;
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(590, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(50, 50);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // updateProfilButton
            // 
            this.updateProfilButton.BackColor = System.Drawing.Color.Gray;
            this.updateProfilButton.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProfilButton.ForeColor = System.Drawing.Color.Snow;
            this.updateProfilButton.Location = new System.Drawing.Point(351, 227);
            this.updateProfilButton.Name = "updateProfilButton";
            this.updateProfilButton.Size = new System.Drawing.Size(234, 42);
            this.updateProfilButton.TabIndex = 12;
            this.updateProfilButton.Text = "Update";
            this.updateProfilButton.UseVisualStyleBackColor = false;
            this.updateProfilButton.Click += new System.EventHandler(this.updateProfilButton_Click);
            // 
            // passwordChangeTxtbox
            // 
            this.passwordChangeTxtbox.Location = new System.Drawing.Point(351, 190);
            this.passwordChangeTxtbox.Multiline = true;
            this.passwordChangeTxtbox.Name = "passwordChangeTxtbox";
            this.passwordChangeTxtbox.Size = new System.Drawing.Size(234, 31);
            this.passwordChangeTxtbox.TabIndex = 11;
            // 
            // usernameChangeTxtbox
            // 
            this.usernameChangeTxtbox.Location = new System.Drawing.Point(351, 130);
            this.usernameChangeTxtbox.Multiline = true;
            this.usernameChangeTxtbox.Name = "usernameChangeTxtbox";
            this.usernameChangeTxtbox.Size = new System.Drawing.Size(234, 31);
            this.usernameChangeTxtbox.TabIndex = 10;
            // 
            // lNameChangeTxtbox
            // 
            this.lNameChangeTxtbox.Location = new System.Drawing.Point(351, 70);
            this.lNameChangeTxtbox.Multiline = true;
            this.lNameChangeTxtbox.Name = "lNameChangeTxtbox";
            this.lNameChangeTxtbox.Size = new System.Drawing.Size(234, 31);
            this.lNameChangeTxtbox.TabIndex = 9;
            // 
            // fNameChangeTxtbox
            // 
            this.fNameChangeTxtbox.Location = new System.Drawing.Point(351, 12);
            this.fNameChangeTxtbox.Multiline = true;
            this.fNameChangeTxtbox.Name = "fNameChangeTxtbox";
            this.fNameChangeTxtbox.Size = new System.Drawing.Size(234, 31);
            this.fNameChangeTxtbox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(204, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(204, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(204, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(200, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "First name:";
            // 
            // ChangeProfilePhotoButton
            // 
            this.ChangeProfilePhotoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ChangeProfilePhotoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeProfilePhotoButton.ForeColor = System.Drawing.Color.Snow;
            this.ChangeProfilePhotoButton.Location = new System.Drawing.Point(25, 134);
            this.ChangeProfilePhotoButton.Name = "ChangeProfilePhotoButton";
            this.ChangeProfilePhotoButton.Size = new System.Drawing.Size(125, 32);
            this.ChangeProfilePhotoButton.TabIndex = 3;
            this.ChangeProfilePhotoButton.Text = "Change Profile Photo";
            this.ChangeProfilePhotoButton.UseVisualStyleBackColor = false;
            this.ChangeProfilePhotoButton.Click += new System.EventHandler(this.ChangeProfilePhotoButton_Click);
            // 
            // photoBox
            // 
            this.photoBox.BackColor = System.Drawing.Color.White;
            this.photoBox.Location = new System.Drawing.Point(25, 3);
            this.photoBox.Name = "photoBox";
            this.photoBox.Size = new System.Drawing.Size(125, 125);
            this.photoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoBox.TabIndex = 2;
            this.photoBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EditUserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 379);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditUserProfileForm";
            this.Text = "EditUserProfileForm";
            this.Load += new System.EventHandler(this.EditUserProfileForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateProfilButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangeProfilePhotoButton;
        public System.Windows.Forms.PictureBox photoBox;
        public System.Windows.Forms.TextBox usernameChangeTxtbox;
        public System.Windows.Forms.TextBox lNameChangeTxtbox;
        public System.Windows.Forms.TextBox fNameChangeTxtbox;
        public System.Windows.Forms.TextBox passwordChangeTxtbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button CloseButton;
    }
}