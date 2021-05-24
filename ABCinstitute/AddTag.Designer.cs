namespace Student_Management_System
{
    partial class AddTag
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tag_Code = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.Related_Tag = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tag_Name = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tag Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tag Name";
            // 
            // Tag_Code
            // 
            // 
            // 
            // 
            this.Tag_Code.CustomButton.Image = null;
            this.Tag_Code.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.Tag_Code.CustomButton.Name = "";
            this.Tag_Code.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Tag_Code.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Tag_Code.CustomButton.TabIndex = 1;
            this.Tag_Code.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Tag_Code.CustomButton.UseSelectable = true;
            this.Tag_Code.CustomButton.Visible = false;
            this.Tag_Code.Lines = new string[0];
            this.Tag_Code.Location = new System.Drawing.Point(345, 226);
            this.Tag_Code.MaxLength = 32767;
            this.Tag_Code.Name = "Tag_Code";
            this.Tag_Code.PasswordChar = '\0';
            this.Tag_Code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Tag_Code.SelectedText = "";
            this.Tag_Code.SelectionLength = 0;
            this.Tag_Code.SelectionStart = 0;
            this.Tag_Code.ShortcutsEnabled = true;
            this.Tag_Code.Size = new System.Drawing.Size(189, 23);
            this.Tag_Code.TabIndex = 37;
            this.Tag_Code.UseSelectable = true;
            this.Tag_Code.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Tag_Code.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(210, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Related Tag";
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.SystemColors.Highlight;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.ForeColor = System.Drawing.Color.White;
            this.metroButton2.Location = new System.Drawing.Point(391, 376);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(111, 29);
            this.metroButton2.TabIndex = 47;
            this.metroButton2.Text = "Save";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.metroButton4.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroButton4.Location = new System.Drawing.Point(258, 376);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(112, 29);
            this.metroButton4.TabIndex = 48;
            this.metroButton4.Text = "Clear";
            this.metroButton4.UseCustomBackColor = true;
            this.metroButton4.UseCustomForeColor = true;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // Related_Tag
            // 
            this.Related_Tag.FormattingEnabled = true;
            this.Related_Tag.ItemHeight = 23;
            this.Related_Tag.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.Related_Tag.Location = new System.Drawing.Point(345, 265);
            this.Related_Tag.Name = "Related_Tag";
            this.Related_Tag.Size = new System.Drawing.Size(189, 29);
            this.Related_Tag.TabIndex = 53;
            this.Related_Tag.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel1.Location = new System.Drawing.Point(38, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 25);
            this.metroLabel1.TabIndex = 60;
            this.metroLabel1.Text = "Add Tag";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABCinstitute.Properties.Resources.backbtn;
            this.pictureBox1.Location = new System.Drawing.Point(-14, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Tag_Name
            // 
            // 
            // 
            // 
            this.Tag_Name.CustomButton.Image = null;
            this.Tag_Name.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.Tag_Name.CustomButton.Name = "";
            this.Tag_Name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Tag_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Tag_Name.CustomButton.TabIndex = 1;
            this.Tag_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Tag_Name.CustomButton.UseSelectable = true;
            this.Tag_Name.CustomButton.Visible = false;
            this.Tag_Name.Lines = new string[0];
            this.Tag_Name.Location = new System.Drawing.Point(345, 183);
            this.Tag_Name.MaxLength = 32767;
            this.Tag_Name.Name = "Tag_Name";
            this.Tag_Name.PasswordChar = '\0';
            this.Tag_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Tag_Name.SelectedText = "";
            this.Tag_Name.SelectionLength = 0;
            this.Tag_Name.SelectionStart = 0;
            this.Tag_Name.ShortcutsEnabled = true;
            this.Tag_Name.Size = new System.Drawing.Size(189, 23);
            this.Tag_Name.TabIndex = 64;
            this.Tag_Name.UseSelectable = true;
            this.Tag_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Tag_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 488);
            this.Controls.Add(this.Tag_Name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Related_Tag);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.Tag_Code);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Name = "AddTag";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox Tag_Code;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroComboBox Related_Tag;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox Tag_Name;
    }
}

