namespace GUI
{
    partial class Lohjin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lohjin));
            panel3 = new Panel();
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
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel3.BackColor = Color.FromArgb(0, 34, 49);
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
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // RegisterLabel
            // 
            RegisterLabel.AutoSize = true;
            RegisterLabel.Font = new Font("Microsoft Sans Serif", 7.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterLabel.ForeColor = Color.Snow;
            RegisterLabel.ImageAlign = ContentAlignment.TopRight;
            RegisterLabel.Location = new Point(489, 370);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(91, 15);
            RegisterLabel.TabIndex = 9;
            RegisterLabel.Text = "Join with us !";
            RegisterLabel.Click += RegisterLabel_Click;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(311, 426);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(133, 39);
            button1.TabIndex = 8;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(264, 554);
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
            label3.Location = new Point(238, 538);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(291, 13);
            label3.TabIndex = 6;
            label3.Text = "I confirm that I have read and agree to the Terms of Service, ";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(295, 521);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(172, 13);
            label2.TabIndex = 5;
            label2.Text = "By logging in to ReCycle Sukabirus,";
            label2.Click += label2_Click;
            // 
            // UasernameLabel
            // 
            UasernameLabel.AutoSize = true;
            UasernameLabel.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UasernameLabel.ForeColor = Color.Ivory;
            UasernameLabel.Location = new Point(193, 214);
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
            label1.Location = new Point(196, 301);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 24);
            label1.TabIndex = 3;
            label1.Text = "Password";
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(195, 338);
            PasswordInput.Margin = new Padding(4, 5, 4, 5);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(385, 27);
            PasswordInput.TabIndex = 2;
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(195, 249);
            UsernameInput.Margin = new Padding(4, 25, 4, 5);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(385, 27);
            UsernameInput.TabIndex = 1;
            UsernameInput.TextChanged += textBox1_TextChanged;
            // 
            // Bergabung
            // 
            Bergabung.AutoSize = true;
            Bergabung.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bergabung.ForeColor = Color.Snow;
            Bergabung.Location = new Point(313, 118);
            Bergabung.Margin = new Padding(4, 0, 4, 0);
            Bergabung.Name = "Bergabung";
            Bergabung.Size = new Size(131, 39);
            Bergabung.TabIndex = 0;
            Bergabung.Text = "Sign In";
            Bergabung.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(395, 689);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 125);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
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
            panel1.TabIndex = 0;
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
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(-3, -1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1541, 1065);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Lohjin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1540, 846);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Lohjin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Bergabung;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UasernameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label RegisterLabel;
    }
}

