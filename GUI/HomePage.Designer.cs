namespace GUI
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            LogoutButton = new Guna.UI2.WinForms.Guna2Button();
            ListButton = new Guna.UI2.WinForms.Guna2Button();
            TambahButton = new Guna.UI2.WinForms.Guna2Button();
            PanelContainer = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 34, 49);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(LogoutButton);
            panel1.Controls.Add(ListButton);
            panel1.Controls.Add(TambahButton);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 846);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.CustomizableEdges = customizableEdges1;
            LogoutButton.DisabledState.BorderColor = Color.DarkGray;
            LogoutButton.DisabledState.CustomBorderColor = Color.DarkGray;
            LogoutButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LogoutButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LogoutButton.FillColor = Color.Transparent;
            LogoutButton.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutButton.ForeColor = Color.White;
            LogoutButton.Image = (Image)resources.GetObject("LogoutButton.Image");
            LogoutButton.ImageAlign = HorizontalAlignment.Left;
            LogoutButton.Location = new Point(13, 726);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.PressedColor = Color.SeaShell;
            LogoutButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            LogoutButton.Size = new Size(254, 56);
            LogoutButton.TabIndex = 2;
            LogoutButton.Text = "Logout";
            LogoutButton.TextAlign = HorizontalAlignment.Left;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // ListButton
            // 
            ListButton.BackColor = Color.Transparent;
            ListButton.CustomizableEdges = customizableEdges3;
            ListButton.DisabledState.BorderColor = Color.DarkGray;
            ListButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ListButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ListButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ListButton.FillColor = Color.Transparent;
            ListButton.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListButton.ForeColor = Color.White;
            ListButton.Image = (Image)resources.GetObject("ListButton.Image");
            ListButton.ImageAlign = HorizontalAlignment.Left;
            ListButton.Location = new Point(13, 330);
            ListButton.Name = "ListButton";
            ListButton.RightToLeft = RightToLeft.No;
            ListButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ListButton.Size = new Size(254, 56);
            ListButton.TabIndex = 1;
            ListButton.Text = "List Produk";
            ListButton.TextAlign = HorizontalAlignment.Left;
            ListButton.Click += ListButton_Click;
            // 
            // TambahButton
            // 
            TambahButton.BackColor = Color.Gainsboro;
            TambahButton.BorderColor = Color.Transparent;
            TambahButton.CustomizableEdges = customizableEdges5;
            TambahButton.DisabledState.BorderColor = Color.DarkGray;
            TambahButton.DisabledState.CustomBorderColor = Color.DarkGray;
            TambahButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            TambahButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            TambahButton.FillColor = Color.FromArgb(0, 34, 49);
            TambahButton.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TambahButton.ForeColor = Color.White;
            TambahButton.Image = (Image)resources.GetObject("TambahButton.Image");
            TambahButton.ImageAlign = HorizontalAlignment.Left;
            TambahButton.Location = new Point(13, 268);
            TambahButton.Name = "TambahButton";
            TambahButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TambahButton.Size = new Size(254, 56);
            TambahButton.TabIndex = 0;
            TambahButton.Text = "Tambah Product";
            TambahButton.TextAlign = HorizontalAlignment.Left;
            TambahButton.Click += TambahButton_Click;
            // 
            // PanelContainer
            // 
            PanelContainer.Location = new Point(266, 1);
            PanelContainer.Name = "PanelContainer";
            PanelContainer.Size = new Size(1276, 845);
            PanelContainer.TabIndex = 1;
            PanelContainer.Paint += panel2_Paint;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1540, 846);
            Controls.Add(PanelContainer);
            Controls.Add(panel1);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button ListButton;
        private Guna.UI2.WinForms.Guna2Button TambahButton;
        private Guna.UI2.WinForms.Guna2Button LogoutButton;
        private PictureBox pictureBox1;
        private Panel PanelContainer;
    }
}