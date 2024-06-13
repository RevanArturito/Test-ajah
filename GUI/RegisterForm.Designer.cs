namespace GUI
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            PhoneInput = new TextBox();
            label5 = new Label();
            EmailInput = new TextBox();
            RegisterLabel = new Label();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            UasernameLabel = new Label();
            label1 = new Label();
            PasswordInput = new TextBox();
            UsernameInput = new TextBox();
            Bergabung = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1545, 1081);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(176, 114);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 625);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(25, 338);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(341, 205);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(79, 118);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(239, 128);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(395, 689);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 125);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel3.BackColor = Color.FromArgb(0, 34, 49);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(PhoneInput);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(EmailInput);
            panel3.Controls.Add(RegisterLabel);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(UasernameLabel);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(PasswordInput);
            panel3.Controls.Add(UsernameInput);
            panel3.Controls.Add(Bergabung);
            panel3.ForeColor = Color.Chocolate;
            panel3.Location = new Point(568, 114);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(783, 625);
            panel3.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(197, 390);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 24);
            label6.TabIndex = 13;
            label6.Text = "Phone";
            // 
            // PhoneInput
            // 
            PhoneInput.Location = new Point(199, 427);
            PhoneInput.Margin = new Padding(4, 5, 4, 5);
            PhoneInput.Name = "PhoneInput";
            PhoneInput.Size = new Size(385, 27);
            PhoneInput.TabIndex = 12;
            PhoneInput.TextChanged += PhoneInput_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(197, 302);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 24);
            label5.TabIndex = 11;
            label5.Text = "Email";
            label5.Click += label5_Click;
            // 
            // EmailInput
            // 
            EmailInput.Location = new Point(199, 338);
            EmailInput.Margin = new Padding(4, 5, 4, 5);
            EmailInput.Name = "EmailInput";
            EmailInput.Size = new Size(385, 27);
            EmailInput.TabIndex = 10;
            EmailInput.TextChanged += EmailInput_TextChanged;
            // 
            // RegisterLabel
            // 
            RegisterLabel.AutoSize = true;
            RegisterLabel.Font = new Font("Microsoft Sans Serif", 7.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterLabel.ForeColor = Color.Snow;
            RegisterLabel.ImageAlign = ContentAlignment.TopRight;
            RegisterLabel.Location = new Point(410, 459);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(174, 15);
            RegisterLabel.TabIndex = 9;
            RegisterLabel.Text = "Already have an account ?";
            RegisterLabel.Click += RegisterLabel_Click;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(312, 526);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(133, 39);
            button1.TabIndex = 8;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(264, 668);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(238, 13);
            label4.TabIndex = 7;
            label4.Text = "Privacy Policy and to receive emails and updates.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(238, 651);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(291, 13);
            label3.TabIndex = 6;
            label3.Text = "I confirm that I have read and agree to the Terms of Service, ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(295, 635);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(172, 13);
            label2.TabIndex = 5;
            label2.Text = "By logging in to ReCycle Sukabirus,";
            // 
            // UasernameLabel
            // 
            UasernameLabel.AutoSize = true;
            UasernameLabel.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UasernameLabel.ForeColor = Color.Ivory;
            UasernameLabel.Location = new Point(197, 135);
            UasernameLabel.Margin = new Padding(4, 0, 4, 0);
            UasernameLabel.Name = "UasernameLabel";
            UasernameLabel.Size = new Size(88, 24);
            UasernameLabel.TabIndex = 4;
            UasernameLabel.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(197, 217);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 24);
            label1.TabIndex = 3;
            label1.Text = "Password";
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(199, 254);
            PasswordInput.Margin = new Padding(4, 5, 4, 5);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(385, 27);
            PasswordInput.TabIndex = 2;
            PasswordInput.TextChanged += PasswordInput_TextChanged;
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(199, 170);
            UsernameInput.Margin = new Padding(4, 25, 4, 5);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(385, 27);
            UsernameInput.TabIndex = 1;
            UsernameInput.TextChanged += UsernameInput_TextChanged;
            // 
            // Bergabung
            // 
            Bergabung.AutoSize = true;
            Bergabung.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bergabung.ForeColor = Color.Snow;
            Bergabung.Location = new Point(275, 54);
            Bergabung.Margin = new Padding(4, 0, 4, 0);
            Bergabung.Name = "Bergabung";
            Bergabung.Size = new Size(217, 39);
            Bergabung.TabIndex = 0;
            Bergabung.Text = "Join with us!";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1540, 846);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UasernameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Label Bergabung;
        private Label label5;
        private TextBox EmailInput;
        private Label label6;
        private TextBox PhoneInput;
    }
}