namespace GUI.UserControls
{
    partial class ProfileUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            DisplayPhone = new TextBox();
            LabelHargaProduk = new Label();
            DisplayEmail = new TextBox();
            LabelTipeProduk = new Label();
            DisplayUsername = new TextBox();
            LabelNamaProduk = new Label();
            buttonEditProfile = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(426, 70);
            label1.Name = "label1";
            label1.Size = new Size(248, 106);
            label1.TabIndex = 0;
            label1.Text = "Halo, ";
            label1.Click += label1_Click;
            // 
            // DisplayPhone
            // 
            DisplayPhone.Location = new Point(314, 335);
            DisplayPhone.Multiline = true;
            DisplayPhone.Name = "DisplayPhone";
            DisplayPhone.ReadOnly = true;
            DisplayPhone.Size = new Size(647, 37);
            DisplayPhone.TabIndex = 12;
            DisplayPhone.TextChanged += DisplayPhone_TextChanged;
            // 
            // LabelHargaProduk
            // 
            LabelHargaProduk.AutoSize = true;
            LabelHargaProduk.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelHargaProduk.Location = new Point(124, 335);
            LabelHargaProduk.Name = "LabelHargaProduk";
            LabelHargaProduk.Size = new Size(85, 33);
            LabelHargaProduk.TabIndex = 11;
            LabelHargaProduk.Text = "Phone";
            // 
            // DisplayEmail
            // 
            DisplayEmail.Location = new Point(314, 275);
            DisplayEmail.Multiline = true;
            DisplayEmail.Name = "DisplayEmail";
            DisplayEmail.ReadOnly = true;
            DisplayEmail.Size = new Size(647, 37);
            DisplayEmail.TabIndex = 10;
            // 
            // LabelTipeProduk
            // 
            LabelTipeProduk.AutoSize = true;
            LabelTipeProduk.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelTipeProduk.Location = new Point(124, 275);
            LabelTipeProduk.Name = "LabelTipeProduk";
            LabelTipeProduk.Size = new Size(75, 33);
            LabelTipeProduk.TabIndex = 9;
            LabelTipeProduk.Text = "Email";
            // 
            // DisplayUsername
            // 
            DisplayUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            DisplayUsername.Location = new Point(314, 218);
            DisplayUsername.Multiline = true;
            DisplayUsername.Name = "DisplayUsername";
            DisplayUsername.ReadOnly = true;
            DisplayUsername.Size = new Size(647, 37);
            DisplayUsername.TabIndex = 8;
            DisplayUsername.TextChanged += DisplayUsername_TextChanged;
            // 
            // LabelNamaProduk
            // 
            LabelNamaProduk.AutoSize = true;
            LabelNamaProduk.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelNamaProduk.Location = new Point(124, 218);
            LabelNamaProduk.Name = "LabelNamaProduk";
            LabelNamaProduk.Size = new Size(127, 33);
            LabelNamaProduk.TabIndex = 7;
            LabelNamaProduk.Text = "Username";
            // 
            // buttonEditProfile
            // 
            buttonEditProfile.Location = new Point(1046, 273);
            buttonEditProfile.Name = "buttonEditProfile";
            buttonEditProfile.Size = new Size(107, 42);
            buttonEditProfile.TabIndex = 13;
            buttonEditProfile.Text = "Edit Profile";
            buttonEditProfile.UseVisualStyleBackColor = true;
            buttonEditProfile.Click += button1_Click;
            // 
            // ProfileUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonEditProfile);
            Controls.Add(DisplayPhone);
            Controls.Add(LabelHargaProduk);
            Controls.Add(DisplayEmail);
            Controls.Add(LabelTipeProduk);
            Controls.Add(DisplayUsername);
            Controls.Add(LabelNamaProduk);
            Controls.Add(label1);
            Name = "ProfileUser";
            Size = new Size(1276, 845);
            Load += ProfileUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox DisplayPhone;
        private Label LabelHargaProduk;
        private TextBox DisplayEmail;
        private Label LabelTipeProduk;
        private TextBox DisplayUsername;
        private Label LabelNamaProduk;
        private Button buttonEditProfile;
    }
}
