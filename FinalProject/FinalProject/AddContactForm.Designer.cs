namespace FinalProject
{
    partial class AddContactForm
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
            this.DecreasePhotoIndex = new System.Windows.Forms.Button();
            this.IncreasePhotoIndex = new System.Windows.Forms.Button();
            this.addCpmtactButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.photoBox = new System.Windows.Forms.PictureBox();
            this.SelectGroupBox = new System.Windows.Forms.ComboBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DecreasePhotoIndex);
            this.panel1.Controls.Add(this.IncreasePhotoIndex);
            this.panel1.Controls.Add(this.addCpmtactButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.photoBox);
            this.panel1.Controls.Add(this.SelectGroupBox);
            this.panel1.Controls.Add(this.addressBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.emailBox);
            this.panel1.Controls.Add(this.phoneBox);
            this.panel1.Controls.Add(this.fnameBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lnameBox);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 833);
            this.panel1.TabIndex = 0;
            // 
            // DecreasePhotoIndex
            // 
            this.DecreasePhotoIndex.Location = new System.Drawing.Point(274, 723);
            this.DecreasePhotoIndex.Name = "DecreasePhotoIndex";
            this.DecreasePhotoIndex.Size = new System.Drawing.Size(50, 25);
            this.DecreasePhotoIndex.TabIndex = 23;
            this.DecreasePhotoIndex.Text = "<";
            this.DecreasePhotoIndex.UseVisualStyleBackColor = true;
            this.DecreasePhotoIndex.Click += new System.EventHandler(this.DecreasePhotoIndex_Click);
            // 
            // IncreasePhotoIndex
            // 
            this.IncreasePhotoIndex.Location = new System.Drawing.Point(349, 723);
            this.IncreasePhotoIndex.Name = "IncreasePhotoIndex";
            this.IncreasePhotoIndex.Size = new System.Drawing.Size(50, 25);
            this.IncreasePhotoIndex.TabIndex = 22;
            this.IncreasePhotoIndex.Text = ">";
            this.IncreasePhotoIndex.UseVisualStyleBackColor = true;
            this.IncreasePhotoIndex.Click += new System.EventHandler(this.IncreasePhotoIndex_Click);
            // 
            // addCpmtactButton
            // 
            this.addCpmtactButton.Location = new System.Drawing.Point(394, 791);
            this.addCpmtactButton.Name = "addCpmtactButton";
            this.addCpmtactButton.Size = new System.Drawing.Size(379, 39);
            this.addCpmtactButton.TabIndex = 20;
            this.addCpmtactButton.Text = "Add Contact";
            this.addCpmtactButton.UseVisualStyleBackColor = true;
            this.addCpmtactButton.Click += new System.EventHandler(this.addContactButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 592);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 37);
            this.label7.TabIndex = 19;
            this.label7.Text = "Photo:";
            // 
            // photoBox
            // 
            this.photoBox.Location = new System.Drawing.Point(274, 592);
            this.photoBox.Name = "photoBox";
            this.photoBox.Size = new System.Drawing.Size(125, 125);
            this.photoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoBox.TabIndex = 18;
            this.photoBox.TabStop = false;
            this.photoBox.Click += new System.EventHandler(this.photoBox_Click);
            // 
            // SelectGroupBox
            // 
            this.SelectGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectGroupBox.FormattingEnabled = true;
            this.SelectGroupBox.Location = new System.Drawing.Point(274, 209);
            this.SelectGroupBox.Name = "SelectGroupBox";
            this.SelectGroupBox.Size = new System.Drawing.Size(502, 37);
            this.SelectGroupBox.TabIndex = 17;
            this.SelectGroupBox.SelectedIndexChanged += new System.EventHandler(this.SelectGroupBox_SelectedIndexChanged);
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.Location = new System.Drawing.Point(274, 451);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(502, 118);
            this.addressBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 37);
            this.label6.TabIndex = 15;
            this.label6.Text = "Address:";
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(274, 365);
            this.emailBox.Multiline = true;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(502, 50);
            this.emailBox.TabIndex = 14;
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.Location = new System.Drawing.Point(274, 276);
            this.phoneBox.Multiline = true;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(502, 50);
            this.phoneBox.TabIndex = 13;
            // 
            // fnameBox
            // 
            this.fnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameBox.Location = new System.Drawing.Point(274, 46);
            this.fnameBox.Multiline = true;
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(502, 50);
            this.fnameBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "First name:";
            // 
            // lnameBox
            // 
            this.lnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameBox.Location = new System.Drawing.Point(274, 117);
            this.lnameBox.Multiline = true;
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(502, 50);
            this.lnameBox.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(730, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(60, 60);
            this.CloseButton.TabIndex = 24;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 923);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddContactForm";
            this.Text = "AddContactForm";
            this.Load += new System.EventHandler(this.AddContactForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addCpmtactButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox SelectGroupBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lnameBox;
        public System.Windows.Forms.PictureBox photoBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button IncreasePhotoIndex;
        private System.Windows.Forms.Button DecreasePhotoIndex;
        private System.Windows.Forms.Button CloseButton;
    }
}