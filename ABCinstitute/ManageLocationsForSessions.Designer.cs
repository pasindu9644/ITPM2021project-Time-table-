namespace Student_Management_System
{
    partial class ManageLocationsForSessions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sessionDataGrid = new MetroFramework.Controls.MetroGrid();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.consectiveSessionDataGrid = new MetroFramework.Controls.MetroGrid();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Time_To = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateCombo = new MetroFramework.Controls.MetroDateTime();
            this.Time_From = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.Location = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consectiveSessionDataGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Green;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.ForeColor = System.Drawing.Color.White;
            this.metroButton2.Location = new System.Drawing.Point(202, 247);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(111, 29);
            this.metroButton2.TabIndex = 79;
            this.metroButton2.Text = "Add Room";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton4.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroButton4.Location = new System.Drawing.Point(341, 247);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(112, 29);
            this.metroButton4.TabIndex = 80;
            this.metroButton4.Text = "Refresh";
            this.metroButton4.UseCustomBackColor = true;
            this.metroButton4.UseCustomForeColor = true;
            this.metroButton4.UseSelectable = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(38, 128);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 321);
            this.tabControl1.TabIndex = 83;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sessionDataGrid);
            this.tabPage1.Controls.Add(this.metroButton2);
            this.tabPage1.Controls.Add(this.metroButton4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(650, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sessions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sessionDataGrid
            // 
            this.sessionDataGrid.AllowUserToResizeRows = false;
            this.sessionDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sessionDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sessionDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sessionDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sessionDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.sessionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sessionDataGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.sessionDataGrid.EnableHeadersVisualStyles = false;
            this.sessionDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sessionDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sessionDataGrid.Location = new System.Drawing.Point(12, 11);
            this.sessionDataGrid.Name = "sessionDataGrid";
            this.sessionDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sessionDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.sessionDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.sessionDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sessionDataGrid.Size = new System.Drawing.Size(626, 226);
            this.sessionDataGrid.TabIndex = 86;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.consectiveSessionDataGrid);
            this.tabPage2.Controls.Add(this.metroButton1);
            this.tabPage2.Controls.Add(this.metroButton3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(650, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consective";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // consectiveSessionDataGrid
            // 
            this.consectiveSessionDataGrid.AllowUserToResizeRows = false;
            this.consectiveSessionDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.consectiveSessionDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consectiveSessionDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.consectiveSessionDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.consectiveSessionDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.consectiveSessionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.consectiveSessionDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.consectiveSessionDataGrid.EnableHeadersVisualStyles = false;
            this.consectiveSessionDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.consectiveSessionDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.consectiveSessionDataGrid.Location = new System.Drawing.Point(12, 15);
            this.consectiveSessionDataGrid.Name = "consectiveSessionDataGrid";
            this.consectiveSessionDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.consectiveSessionDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.consectiveSessionDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.consectiveSessionDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.consectiveSessionDataGrid.Size = new System.Drawing.Size(626, 226);
            this.consectiveSessionDataGrid.TabIndex = 89;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Green;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(202, 251);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(111, 29);
            this.metroButton1.TabIndex = 87;
            this.metroButton1.Text = "Add Room";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroButton3.Location = new System.Drawing.Point(341, 251);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(112, 29);
            this.metroButton3.TabIndex = 88;
            this.metroButton3.Text = "Refresh";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseCustomForeColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Time_To);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.dateCombo);
            this.tabPage3.Controls.Add(this.Time_From);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.metroButton5);
            this.tabPage3.Controls.Add(this.metroButton6);
            this.tabPage3.Controls.Add(this.Location);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(650, 295);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Not Availble Times";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Time_To
            // 
            // 
            // 
            // 
            this.Time_To.CustomButton.Image = null;
            this.Time_To.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.Time_To.CustomButton.Name = "";
            this.Time_To.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Time_To.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Time_To.CustomButton.TabIndex = 1;
            this.Time_To.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Time_To.CustomButton.UseSelectable = true;
            this.Time_To.CustomButton.Visible = false;
            this.Time_To.Lines = new string[0];
            this.Time_To.Location = new System.Drawing.Point(433, 128);
            this.Time_To.MaxLength = 32767;
            this.Time_To.Name = "Time_To";
            this.Time_To.PasswordChar = '\0';
            this.Time_To.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Time_To.SelectedText = "";
            this.Time_To.SelectionLength = 0;
            this.Time_To.SelectionStart = 0;
            this.Time_To.ShortcutsEnabled = true;
            this.Time_To.Size = new System.Drawing.Size(181, 23);
            this.Time_To.TabIndex = 107;
            this.Time_To.UseSelectable = true;
            this.Time_To.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Time_To.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 106;
            this.label2.Text = "Time To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 105;
            this.label1.Text = "Date";
            // 
            // dateCombo
            // 
            this.dateCombo.Location = new System.Drawing.Point(134, 122);
            this.dateCombo.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateCombo.Name = "dateCombo";
            this.dateCombo.Size = new System.Drawing.Size(181, 29);
            this.dateCombo.TabIndex = 104;
            // 
            // Time_From
            // 
            // 
            // 
            // 
            this.Time_From.CustomButton.Image = null;
            this.Time_From.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.Time_From.CustomButton.Name = "";
            this.Time_From.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Time_From.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Time_From.CustomButton.TabIndex = 1;
            this.Time_From.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Time_From.CustomButton.UseSelectable = true;
            this.Time_From.CustomButton.Visible = false;
            this.Time_From.Lines = new string[0];
            this.Time_From.Location = new System.Drawing.Point(433, 54);
            this.Time_From.MaxLength = 32767;
            this.Time_From.Name = "Time_From";
            this.Time_From.PasswordChar = '\0';
            this.Time_From.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Time_From.SelectedText = "";
            this.Time_From.SelectionLength = 0;
            this.Time_From.SelectionStart = 0;
            this.Time_From.ShortcutsEnabled = true;
            this.Time_From.Size = new System.Drawing.Size(181, 23);
            this.Time_From.TabIndex = 103;
            this.Time_From.UseSelectable = true;
            this.Time_From.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Time_From.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(350, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 102;
            this.label8.Text = "Time From";
            // 
            // metroButton5
            // 
            this.metroButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metroButton5.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton5.ForeColor = System.Drawing.Color.White;
            this.metroButton5.Location = new System.Drawing.Point(329, 220);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(111, 29);
            this.metroButton5.TabIndex = 100;
            this.metroButton5.Text = "Clear";
            this.metroButton5.UseCustomBackColor = true;
            this.metroButton5.UseCustomForeColor = true;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton6.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroButton6.Location = new System.Drawing.Point(185, 220);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(112, 29);
            this.metroButton6.TabIndex = 101;
            this.metroButton6.Text = "Add";
            this.metroButton6.UseCustomBackColor = true;
            this.metroButton6.UseCustomForeColor = true;
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // Location
            // 
            this.Location.FormattingEnabled = true;
            this.Location.ItemHeight = 23;
            this.Location.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.Location.Location = new System.Drawing.Point(134, 53);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(181, 29);
            this.Location.TabIndex = 93;
            this.Location.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 92;
            this.label3.Text = "Select Room";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel1.Location = new System.Drawing.Point(38, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(275, 25);
            this.metroLabel1.TabIndex = 85;
            this.metroLabel1.Text = "Manage Locations For Sessions";
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
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ManageLocationsForSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 488);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManageLocationsForSessions";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sessionDataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.consectiveSessionDataGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MetroFramework.Controls.MetroGrid sessionDataGrid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MetroFramework.Controls.MetroComboBox Location;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid consectiveSessionDataGrid;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroTextBox Time_To;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime dateCombo;
        private MetroFramework.Controls.MetroTextBox Time_From;
        private System.Windows.Forms.Label label8;
    }
}