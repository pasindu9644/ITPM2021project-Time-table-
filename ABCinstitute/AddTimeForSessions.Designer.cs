namespace Student_Management_System
{
    partial class AddTimeForSessions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.Session = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.selectedSessions = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Time_To = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateCombo = new MetroFramework.Controls.MetroDateTime();
            this.Time_From = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sessionGrid = new MetroFramework.Controls.MetroGrid();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 359);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "(Parelell Sessions)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(151, 186);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Select Session";
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.SystemColors.Highlight;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.ForeColor = System.Drawing.Color.White;
            this.metroButton2.Location = new System.Drawing.Point(344, 519);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(148, 36);
            this.metroButton2.TabIndex = 47;
            this.metroButton2.Text = "Submit";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.Color.Red;
            this.metroButton4.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroButton4.Location = new System.Drawing.Point(524, 519);
            this.metroButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(149, 36);
            this.metroButton4.TabIndex = 48;
            this.metroButton4.Text = "Clear";
            this.metroButton4.UseCustomBackColor = true;
            this.metroButton4.UseCustomForeColor = true;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // Session
            // 
            this.Session.FormattingEnabled = true;
            this.Session.ItemHeight = 24;
            this.Session.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.Session.Location = new System.Drawing.Point(344, 178);
            this.Session.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Session.Name = "Session";
            this.Session.Size = new System.Drawing.Size(445, 30);
            this.Session.TabIndex = 53;
            this.Session.UseSelectable = true;
            this.Session.SelectionChangeCommitted += new System.EventHandler(this.sessionCombo_SelectionChangeCommitted);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel1.Location = new System.Drawing.Point(51, 90);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(211, 25);
            this.metroLabel1.TabIndex = 60;
            this.metroLabel1.Text = "Manage Session Times";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // selectedSessions
            // 
            this.selectedSessions.Location = new System.Drawing.Point(344, 352);
            this.selectedSessions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectedSessions.Name = "selectedSessions";
            this.selectedSessions.Size = new System.Drawing.Size(445, 64);
            this.selectedSessions.TabIndex = 66;
            this.selectedSessions.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABCinstitute.Properties.Resources.backbtn;
            this.pictureBox1.Location = new System.Drawing.Point(-19, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Time_To
            // 
            // 
            // 
            // 
            this.Time_To.CustomButton.Image = null;
            this.Time_To.CustomButton.Location = new System.Drawing.Point(131, 2);
            this.Time_To.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Time_To.CustomButton.Name = "";
            this.Time_To.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.Time_To.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Time_To.CustomButton.TabIndex = 1;
            this.Time_To.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Time_To.CustomButton.UseSelectable = true;
            this.Time_To.CustomButton.Visible = false;
            this.Time_To.Lines = new string[0];
            this.Time_To.Location = new System.Drawing.Point(765, 447);
            this.Time_To.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Time_To.MaxLength = 32767;
            this.Time_To.Name = "Time_To";
            this.Time_To.PasswordChar = '\0';
            this.Time_To.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Time_To.SelectedText = "";
            this.Time_To.SelectionLength = 0;
            this.Time_To.SelectionStart = 0;
            this.Time_To.ShortcutsEnabled = true;
            this.Time_To.Size = new System.Drawing.Size(124, 28);
            this.Time_To.TabIndex = 99;
            this.Time_To.UseSelectable = true;
            this.Time_To.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Time_To.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(681, 450);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 98;
            this.label1.Text = "Time To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 454);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 97;
            this.label3.Text = "Date";
            // 
            // dateCombo
            // 
            this.dateCombo.Location = new System.Drawing.Point(136, 444);
            this.dateCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateCombo.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateCombo.Name = "dateCombo";
            this.dateCombo.Size = new System.Drawing.Size(235, 30);
            this.dateCombo.TabIndex = 96;
            // 
            // Time_From
            // 
            // 
            // 
            // 
            this.Time_From.CustomButton.Image = null;
            this.Time_From.CustomButton.Location = new System.Drawing.Point(131, 2);
            this.Time_From.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Time_From.CustomButton.Name = "";
            this.Time_From.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.Time_From.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Time_From.CustomButton.TabIndex = 1;
            this.Time_From.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Time_From.CustomButton.UseSelectable = true;
            this.Time_From.CustomButton.Visible = false;
            this.Time_From.Lines = new string[0];
            this.Time_From.Location = new System.Drawing.Point(549, 447);
            this.Time_From.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Time_From.MaxLength = 32767;
            this.Time_From.Name = "Time_From";
            this.Time_From.PasswordChar = '\0';
            this.Time_From.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Time_From.SelectedText = "";
            this.Time_From.SelectionLength = 0;
            this.Time_From.SelectionStart = 0;
            this.Time_From.ShortcutsEnabled = true;
            this.Time_From.Size = new System.Drawing.Size(124, 28);
            this.Time_From.TabIndex = 95;
            this.Time_From.UseSelectable = true;
            this.Time_From.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Time_From.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(445, 450);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 94;
            this.label8.Text = "Time From";
            // 
            // sessionGrid
            // 
            this.sessionGrid.AllowUserToResizeRows = false;
            this.sessionGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sessionGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sessionGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sessionGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sessionGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sessionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sessionGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.sessionGrid.EnableHeadersVisualStyles = false;
            this.sessionGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sessionGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sessionGrid.Location = new System.Drawing.Point(155, 241);
            this.sessionGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sessionGrid.Name = "sessionGrid";
            this.sessionGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sessionGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.sessionGrid.RowHeadersWidth = 51;
            this.sessionGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.sessionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sessionGrid.Size = new System.Drawing.Size(636, 84);
            this.sessionGrid.TabIndex = 100;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(799, 268);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(36, 28);
            this.metroButton1.TabIndex = 101;
            this.metroButton1.Text = "+";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // AddTimeForSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 601);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.sessionGrid);
            this.Controls.Add(this.Time_To);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateCombo);
            this.Controls.Add(this.Time_From);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.selectedSessions);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Session);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddTimeForSessions";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroComboBox Session;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox selectedSessions;
        private MetroFramework.Controls.MetroTextBox Time_To;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroDateTime dateCombo;
        private MetroFramework.Controls.MetroTextBox Time_From;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroGrid sessionGrid;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

