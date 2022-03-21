namespace FinalProject
{
    partial class ProgramForm
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
            this.welcomeTxt = new System.Windows.Forms.Label();
            this.editMyProfileTxt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowAllContacts = new System.Windows.Forms.Button();
            this.SelectContactButton = new System.Windows.Forms.Button();
            this.IDTxtBox = new System.Windows.Forms.TextBox();
            this.RemoveContactButton = new System.Windows.Forms.Button();
            this.EditContactButton = new System.Windows.Forms.Button();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.removeGroupBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.removeGroupButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.editGroupnameBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EditGroupnameTxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editGroupnameButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupnameTxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddEntergroupButtonGroupButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.profilePhoto = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeTxt
            // 
            this.welcomeTxt.AutoSize = true;
            this.welcomeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeTxt.Location = new System.Drawing.Point(68, 9);
            this.welcomeTxt.Name = "welcomeTxt";
            this.welcomeTxt.Size = new System.Drawing.Size(341, 39);
            this.welcomeTxt.TabIndex = 0;
            this.welcomeTxt.Text = "Welcome (username)";
            // 
            // editMyProfileTxt
            // 
            this.editMyProfileTxt.AutoSize = true;
            this.editMyProfileTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMyProfileTxt.Location = new System.Drawing.Point(83, 48);
            this.editMyProfileTxt.Name = "editMyProfileTxt";
            this.editMyProfileTxt.Size = new System.Drawing.Size(166, 29);
            this.editMyProfileTxt.TabIndex = 2;
            this.editMyProfileTxt.Text = "edit my Profile";
            this.editMyProfileTxt.Click += new System.EventHandler(this.editMyProfileTxt_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ShowAllContacts);
            this.panel1.Controls.Add(this.SelectContactButton);
            this.panel1.Controls.Add(this.IDTxtBox);
            this.panel1.Controls.Add(this.RemoveContactButton);
            this.panel1.Controls.Add(this.EditContactButton);
            this.panel1.Controls.Add(this.AddContactButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1395, 451);
            this.panel1.TabIndex = 3;
            // 
            // ShowAllContacts
            // 
            this.ShowAllContacts.Location = new System.Drawing.Point(154, 329);
            this.ShowAllContacts.Name = "ShowAllContacts";
            this.ShowAllContacts.Size = new System.Drawing.Size(462, 61);
            this.ShowAllContacts.TabIndex = 12;
            this.ShowAllContacts.Text = "Show all contacts";
            this.ShowAllContacts.UseVisualStyleBackColor = true;
            this.ShowAllContacts.Click += new System.EventHandler(this.ShowAllContacts_Click);
            // 
            // SelectContactButton
            // 
            this.SelectContactButton.Location = new System.Drawing.Point(358, 213);
            this.SelectContactButton.Name = "SelectContactButton";
            this.SelectContactButton.Size = new System.Drawing.Size(258, 35);
            this.SelectContactButton.TabIndex = 11;
            this.SelectContactButton.Text = "Select Contact";
            this.SelectContactButton.UseVisualStyleBackColor = true;
            this.SelectContactButton.Click += new System.EventHandler(this.SelectContactButton_Click);
            // 
            // IDTxtBox
            // 
            this.IDTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTxtBox.Location = new System.Drawing.Point(358, 254);
            this.IDTxtBox.Multiline = true;
            this.IDTxtBox.Name = "IDTxtBox";
            this.IDTxtBox.Size = new System.Drawing.Size(258, 47);
            this.IDTxtBox.TabIndex = 10;
            // 
            // RemoveContactButton
            // 
            this.RemoveContactButton.Location = new System.Drawing.Point(154, 254);
            this.RemoveContactButton.Name = "RemoveContactButton";
            this.RemoveContactButton.Size = new System.Drawing.Size(188, 47);
            this.RemoveContactButton.TabIndex = 9;
            this.RemoveContactButton.Text = "Remove Contact";
            this.RemoveContactButton.UseVisualStyleBackColor = true;
            this.RemoveContactButton.Click += new System.EventHandler(this.RemoveContactButton_Click);
            // 
            // EditContactButton
            // 
            this.EditContactButton.Location = new System.Drawing.Point(154, 156);
            this.EditContactButton.Name = "EditContactButton";
            this.EditContactButton.Size = new System.Drawing.Size(188, 47);
            this.EditContactButton.TabIndex = 8;
            this.EditContactButton.Text = "Edit Contact";
            this.EditContactButton.UseVisualStyleBackColor = true;
            this.EditContactButton.Click += new System.EventHandler(this.EditContactButton_Click);
            // 
            // AddContactButton
            // 
            this.AddContactButton.Location = new System.Drawing.Point(154, 103);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(188, 47);
            this.AddContactButton.TabIndex = 7;
            this.AddContactButton.Text = "Add Contact";
            this.AddContactButton.UseVisualStyleBackColor = true;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(147, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 37);
            this.label6.TabIndex = 6;
            this.label6.Text = "CONTACTS";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.removeGroupBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.removeGroupButton);
            this.groupBox3.Location = new System.Drawing.Point(680, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // removeGroupBox
            // 
            this.removeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeGroupBox.FormattingEnabled = true;
            this.removeGroupBox.Location = new System.Drawing.Point(226, 14);
            this.removeGroupBox.Name = "removeGroupBox";
            this.removeGroupBox.Size = new System.Drawing.Size(303, 33);
            this.removeGroupBox.TabIndex = 4;
            this.removeGroupBox.DropDown += new System.EventHandler(this.removeGroupBox_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Select group;";
            // 
            // removeGroupButton
            // 
            this.removeGroupButton.Location = new System.Drawing.Point(226, 53);
            this.removeGroupButton.Name = "removeGroupButton";
            this.removeGroupButton.Size = new System.Drawing.Size(303, 41);
            this.removeGroupButton.TabIndex = 3;
            this.removeGroupButton.Text = "Remove group";
            this.removeGroupButton.UseVisualStyleBackColor = true;
            this.removeGroupButton.Click += new System.EventHandler(this.removeGroupButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.editGroupnameBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.EditGroupnameTxtbox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.editGroupnameButton);
            this.groupBox2.Location = new System.Drawing.Point(680, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 153);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // editGroupnameBox
            // 
            this.editGroupnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editGroupnameBox.FormattingEnabled = true;
            this.editGroupnameBox.Location = new System.Drawing.Point(226, 13);
            this.editGroupnameBox.Name = "editGroupnameBox";
            this.editGroupnameBox.Size = new System.Drawing.Size(303, 33);
            this.editGroupnameBox.TabIndex = 5;
            this.editGroupnameBox.DropDown += new System.EventHandler(this.editGroupnameBox_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "New group name:";
            // 
            // EditGroupnameTxtbox
            // 
            this.EditGroupnameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditGroupnameTxtbox.Location = new System.Drawing.Point(226, 57);
            this.EditGroupnameTxtbox.Multiline = true;
            this.EditGroupnameTxtbox.Name = "EditGroupnameTxtbox";
            this.EditGroupnameTxtbox.Size = new System.Drawing.Size(303, 41);
            this.EditGroupnameTxtbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select group:";
            // 
            // editGroupnameButton
            // 
            this.editGroupnameButton.Location = new System.Drawing.Point(226, 104);
            this.editGroupnameButton.Name = "editGroupnameButton";
            this.editGroupnameButton.Size = new System.Drawing.Size(303, 41);
            this.editGroupnameButton.TabIndex = 3;
            this.editGroupnameButton.Text = "Edit group name";
            this.editGroupnameButton.UseVisualStyleBackColor = true;
            this.editGroupnameButton.Click += new System.EventHandler(this.editGroupnameButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupnameTxtbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddEntergroupButtonGroupButton);
            this.groupBox1.Location = new System.Drawing.Point(680, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupnameTxtbox
            // 
            this.groupnameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupnameTxtbox.Location = new System.Drawing.Point(226, 6);
            this.groupnameTxtbox.Multiline = true;
            this.groupnameTxtbox.Name = "groupnameTxtbox";
            this.groupnameTxtbox.Size = new System.Drawing.Size(303, 41);
            this.groupnameTxtbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Group name:";
            // 
            // AddEntergroupButtonGroupButton
            // 
            this.AddEntergroupButtonGroupButton.Location = new System.Drawing.Point(226, 53);
            this.AddEntergroupButtonGroupButton.Name = "AddEntergroupButtonGroupButton";
            this.AddEntergroupButtonGroupButton.Size = new System.Drawing.Size(303, 41);
            this.AddEntergroupButtonGroupButton.TabIndex = 3;
            this.AddEntergroupButtonGroupButton.Text = "Add";
            this.AddEntergroupButtonGroupButton.UseVisualStyleBackColor = true;
            this.AddEntergroupButtonGroupButton.Click += new System.EventHandler(this.AddEntergroupButtonGroupButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(684, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "GROUP";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // profilePhoto
            // 
            this.profilePhoto.Location = new System.Drawing.Point(12, 9);
            this.profilePhoto.Name = "profilePhoto";
            this.profilePhoto.Size = new System.Drawing.Size(50, 50);
            this.profilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePhoto.TabIndex = 1;
            this.profilePhoto.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(1357, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(50, 50);
            this.CloseButton.TabIndex = 29;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 543);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.editMyProfileTxt);
            this.Controls.Add(this.profilePhoto);
            this.Controls.Add(this.welcomeTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgramForm";
            this.Text = "ProgramForm";
            this.Load += new System.EventHandler(this.ProgramForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeTxt;
        private System.Windows.Forms.PictureBox profilePhoto;
        private System.Windows.Forms.Label editMyProfileTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox groupnameTxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddEntergroupButtonGroupButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox editGroupnameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EditGroupnameTxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button editGroupnameButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button removeGroupButton;
        private System.Windows.Forms.ComboBox removeGroupBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button AddContactButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button RemoveContactButton;
        private System.Windows.Forms.Button EditContactButton;
        private System.Windows.Forms.Button ShowAllContacts;
        private System.Windows.Forms.Button SelectContactButton;
        private System.Windows.Forms.TextBox IDTxtBox;
        private System.Windows.Forms.Button CloseButton;
    }
}