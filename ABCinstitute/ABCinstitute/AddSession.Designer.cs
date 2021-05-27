namespace Student_Management_System
{
    partial class AddSession
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.lecNameText = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tag = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lecturer = new MetroFramework.Controls.MetroComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Session_Type = new MetroFramework.Controls.MetroComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.label7 = new System.Windows.Forms.Label();
            this.Duration = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.No_Of_Students = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Subject = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Group = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel1.Location = new System.Drawing.Point(38, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(115, 25);
            this.metroLabel1.TabIndex = 60;
            this.metroLabel1.Text = "Add Session";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(38, 131);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 334);
            this.tabControl1.TabIndex = 64;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(650, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select Lecturer(s) And Tag";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroButton6);
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.lecNameText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Tag);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Lecturer);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1";
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(328, 91);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(31, 23);
            this.metroButton6.TabIndex = 69;
            this.metroButton6.Text = "+";
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Red;
            this.metroButton2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroButton2.Location = new System.Drawing.Point(498, 220);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(97, 35);
            this.metroButton2.TabIndex = 68;
            this.metroButton2.Text = "Clear";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.Menu;
            this.metroButton1.Location = new System.Drawing.Point(385, 220);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(97, 35);
            this.metroButton1.TabIndex = 67;
            this.metroButton1.Text = "Next";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // lecNameText
            // 
            // 
            // 
            // 
            this.lecNameText.CustomButton.Image = null;
            this.lecNameText.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.lecNameText.CustomButton.Name = "";
            this.lecNameText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lecNameText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lecNameText.CustomButton.TabIndex = 1;
            this.lecNameText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lecNameText.CustomButton.UseSelectable = true;
            this.lecNameText.CustomButton.Visible = false;
            this.lecNameText.Lines = new string[0];
            this.lecNameText.Location = new System.Drawing.Point(171, 146);
            this.lecNameText.MaxLength = 32767;
            this.lecNameText.Name = "lecNameText";
            this.lecNameText.PasswordChar = '\0';
            this.lecNameText.ReadOnly = true;
            this.lecNameText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lecNameText.SelectedText = "";
            this.lecNameText.SelectionLength = 0;
            this.lecNameText.SelectionStart = 0;
            this.lecNameText.ShortcutsEnabled = true;
            this.lecNameText.Size = new System.Drawing.Size(424, 23);
            this.lecNameText.TabIndex = 66;
            this.lecNameText.UseSelectable = true;
            this.lecNameText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lecNameText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "Selected Lecturer(s)";
            // 
            // Tag
            // 
            this.Tag.FormattingEnabled = true;
            this.Tag.ItemHeight = 23;
            this.Tag.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.Tag.Location = new System.Drawing.Point(450, 87);
            this.Tag.Name = "Tag";
            this.Tag.Size = new System.Drawing.Size(145, 29);
            this.Tag.TabIndex = 57;
            this.Tag.UseSelectable = true;
            this.Tag.SelectedIndexChanged += new System.EventHandler(this.tagsCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Select Tag";
            // 
            // Lecturer
            // 
            this.Lecturer.FormattingEnabled = true;
            this.Lecturer.ItemHeight = 23;
            this.Lecturer.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.Lecturer.Location = new System.Drawing.Point(171, 87);
            this.Lecturer.Name = "Lecturer";
            this.Lecturer.Size = new System.Drawing.Size(156, 29);
            this.Lecturer.TabIndex = 55;
            this.Lecturer.UseSelectable = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 17);
            this.label9.TabIndex = 54;
            this.label9.Text = "Select Lecturer(s)";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(650, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Select Group And Subject";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Session_Type);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.metroButton5);
            this.groupBox2.Controls.Add(this.metroButton3);
            this.groupBox2.Controls.Add(this.metroButton4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Duration);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.No_Of_Students);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Subject);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Group);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 296);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2";
            // 
            // Session_Type
            // 
            this.Session_Type.FormattingEnabled = true;
            this.Session_Type.ItemHeight = 23;
            this.Session_Type.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.Session_Type.Location = new System.Drawing.Point(145, 163);
            this.Session_Type.Name = "Session_Type";
            this.Session_Type.Size = new System.Drawing.Size(168, 29);
            this.Session_Type.TabIndex = 86;
            this.Session_Type.UseSelectable = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 85;
            this.label8.Text = "Session Type";
            // 
            // metroButton5
            // 
            this.metroButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metroButton5.ForeColor = System.Drawing.SystemColors.Menu;
            this.metroButton5.Location = new System.Drawing.Point(297, 211);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(97, 35);
            this.metroButton5.TabIndex = 84;
            this.metroButton5.Text = "Back";
            this.metroButton5.UseCustomBackColor = true;
            this.metroButton5.UseCustomForeColor = true;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click_1);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.Red;
            this.metroButton3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroButton3.Location = new System.Drawing.Point(524, 211);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(97, 35);
            this.metroButton3.TabIndex = 83;
            this.metroButton3.Text = "Clear";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseCustomForeColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton4.ForeColor = System.Drawing.SystemColors.Menu;
            this.metroButton4.Location = new System.Drawing.Point(411, 211);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(97, 35);
            this.metroButton4.TabIndex = 82;
            this.metroButton4.Text = "Submit";
            this.metroButton4.UseCustomBackColor = true;
            this.metroButton4.UseCustomForeColor = true;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(589, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 81;
            this.label7.Text = "Hrs";
            // 
            // Duration
            // 
            // 
            // 
            // 
            this.Duration.CustomButton.Image = null;
            this.Duration.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.Duration.CustomButton.Name = "";
            this.Duration.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Duration.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Duration.CustomButton.TabIndex = 1;
            this.Duration.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Duration.CustomButton.UseSelectable = true;
            this.Duration.CustomButton.Visible = false;
            this.Duration.Lines = new string[0];
            this.Duration.Location = new System.Drawing.Point(451, 111);
            this.Duration.MaxLength = 32767;
            this.Duration.Name = "Duration";
            this.Duration.PasswordChar = '\0';
            this.Duration.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Duration.SelectedText = "";
            this.Duration.SelectionLength = 0;
            this.Duration.SelectionStart = 0;
            this.Duration.ShortcutsEnabled = true;
            this.Duration.Size = new System.Drawing.Size(138, 23);
            this.Duration.TabIndex = 80;
            this.Duration.UseSelectable = true;
            this.Duration.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Duration.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 79;
            this.label6.Text = "Duration";
            // 
            // No_Of_Students
            // 
            // 
            // 
            // 
            this.No_Of_Students.CustomButton.Image = null;
            this.No_Of_Students.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.No_Of_Students.CustomButton.Name = "";
            this.No_Of_Students.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.No_Of_Students.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.No_Of_Students.CustomButton.TabIndex = 1;
            this.No_Of_Students.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.No_Of_Students.CustomButton.UseSelectable = true;
            this.No_Of_Students.CustomButton.Visible = false;
            this.No_Of_Students.Lines = new string[0];
            this.No_Of_Students.Location = new System.Drawing.Point(451, 66);
            this.No_Of_Students.MaxLength = 32767;
            this.No_Of_Students.Name = "No_Of_Students";
            this.No_Of_Students.PasswordChar = '\0';
            this.No_Of_Students.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.No_Of_Students.SelectedText = "";
            this.No_Of_Students.SelectionLength = 0;
            this.No_Of_Students.SelectionStart = 0;
            this.No_Of_Students.ShortcutsEnabled = true;
            this.No_Of_Students.Size = new System.Drawing.Size(168, 23);
            this.No_Of_Students.TabIndex = 78;
            this.No_Of_Students.UseSelectable = true;
            this.No_Of_Students.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.No_Of_Students.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(340, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 77;
            this.label5.Text = "No Of Students";
            // 
            // Subject
            // 
            this.Subject.FormattingEnabled = true;
            this.Subject.ItemHeight = 23;
            this.Subject.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.Subject.Location = new System.Drawing.Point(145, 111);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(168, 29);
            this.Subject.TabIndex = 76;
            this.Subject.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Select Subject";
            // 
            // Group
            // 
            this.Group.FormattingEnabled = true;
            this.Group.ItemHeight = 23;
            this.Group.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.Group.Location = new System.Drawing.Point(145, 60);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(168, 29);
            this.Group.TabIndex = 74;
            this.Group.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 73;
            this.label4.Text = "Select Group";
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
            // AddSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 488);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel1);
            this.HelpButton = true;
            this.Name = "AddSession";
            this.Resizable = false;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroFramework.Controls.MetroComboBox Tag;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox Lecturer;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroTextBox lecNameText;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox Duration;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox No_Of_Students;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox Subject;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox Group;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroComboBox Session_Type;
        private System.Windows.Forms.Label label8;
    }
}

