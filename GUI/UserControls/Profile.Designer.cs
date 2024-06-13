namespace GUI.UserControls
{
    partial class Profile
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
            LabelHai = new Label();
            LabelNama = new Label();
            SuspendLayout();
            // 
            // LabelHai
            // 
            LabelHai.AutoSize = true;
            LabelHai.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelHai.Location = new Point(476, 126);
            LabelHai.Name = "LabelHai";
            LabelHai.Size = new Size(71, 33);
            LabelHai.TabIndex = 0;
            LabelHai.Text = "Halo,";
            // 
            // LabelNama
            // 
            LabelNama.AutoSize = true;
            LabelNama.Location = new Point(562, 135);
            LabelNama.Name = "LabelNama";
            LabelNama.Size = new Size(50, 20);
            LabelNama.TabIndex = 1;
            LabelNama.Text = "label1";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LabelNama);
            Controls.Add(LabelHai);
            Name = "Profile";
            Size = new Size(1276, 845);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelHai;
        private Label LabelNama;
    }
}
