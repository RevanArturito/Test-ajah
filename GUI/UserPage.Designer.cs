namespace GUI
{
    partial class UserPage
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPage));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panel2 = new Panel();
            PanelContainer = new Panel();
            ProfileUser = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            LogoutButton = new Guna.UI2.WinForms.Guna2Button();
            BeliButton = new Guna.UI2.WinForms.Guna2Button();
            PanelContainer2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 34, 49);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(PanelContainer);
            panel1.Controls.Add(ProfileUser);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(LogoutButton);
            panel1.Controls.Add(BeliButton);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 846);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Location = new Point(270, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 2;
            // 
            // PanelContainer
            // 
            PanelContainer.Location = new Point(270, 0);
            PanelContainer.Name = "PanelContainer";
            PanelContainer.Size = new Size(1276, 845);
            PanelContainer.TabIndex = 2;
            // 
            // ProfileUser
            // 
            ProfileUser.BackColor = Color.Transparent;
            ProfileUser.CustomizableEdges = customizableEdges1;
            ProfileUser.DisabledState.BorderColor = Color.DarkGray;
            ProfileUser.DisabledState.CustomBorderColor = Color.DarkGray;
            ProfileUser.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ProfileUser.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ProfileUser.FillColor = Color.Transparent;
            ProfileUser.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProfileUser.ForeColor = Color.White;
            ProfileUser.Image = (Image)resources.GetObject("ProfileUser.Image");
            ProfileUser.ImageAlign = HorizontalAlignment.Left;
            ProfileUser.Location = new Point(10, 330);
            ProfileUser.Name = "ProfileUser";
            ProfileUser.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ProfileUser.Size = new Size(254, 56);
            ProfileUser.TabIndex = 4;
            ProfileUser.Text = "Profile";
            ProfileUser.TextAlign = HorizontalAlignment.Left;
            ProfileUser.Click += Profile_Click;
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
            // 
            // LogoutButton
            // 
            LogoutButton.CustomizableEdges = customizableEdges3;
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
            LogoutButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            LogoutButton.Size = new Size(254, 56);
            LogoutButton.TabIndex = 2;
            LogoutButton.Text = "Logout";
            LogoutButton.TextAlign = HorizontalAlignment.Left;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // BeliButton
            // 
            BeliButton.BackColor = Color.Gainsboro;
            BeliButton.BorderColor = Color.Transparent;
            BeliButton.CustomizableEdges = customizableEdges5;
            BeliButton.DisabledState.BorderColor = Color.DarkGray;
            BeliButton.DisabledState.CustomBorderColor = Color.DarkGray;
            BeliButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BeliButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BeliButton.FillColor = Color.FromArgb(0, 34, 49);
            BeliButton.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BeliButton.ForeColor = Color.White;
            BeliButton.Image = (Image)resources.GetObject("BeliButton.Image");
            BeliButton.ImageAlign = HorizontalAlignment.Left;
            BeliButton.Location = new Point(13, 268);
            BeliButton.Name = "BeliButton";
            BeliButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            BeliButton.Size = new Size(254, 56);
            BeliButton.TabIndex = 0;
            BeliButton.Text = "Beli Produk";
            BeliButton.TextAlign = HorizontalAlignment.Left;
            BeliButton.Click += TambahButton_Click;
            // 
            // PanelContainer2
            // 
            PanelContainer2.BackColor = SystemColors.ActiveCaption;
            PanelContainer2.Location = new Point(268, 1);
            PanelContainer2.Name = "PanelContainer2";
            PanelContainer2.Size = new Size(1276, 845);
            PanelContainer2.TabIndex = 2;
            PanelContainer2.Paint += PanelContainer2_Paint;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1540, 846);
            Controls.Add(PanelContainer2);
            Controls.Add(panel1);
            Name = "UserPage";
            Text = "UserPage";
            Load += UserPage_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button ProfileUser;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button LogoutButton;
        private Guna.UI2.WinForms.Guna2Button BeliButton;
        private Panel PanelContainer;
        private Panel panel2;
        private Panel PanelContainer2;
    }
}