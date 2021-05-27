
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class MainMenu : MetroFramework.Forms.MetroForm
    {
        
        public MainMenu()
        {
            InitializeComponent();
            metroDateTime1.Value = DateTime.Now;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            AddWorkingHoursDays df = new AddWorkingHoursDays();
            df.Show();
            this.Hide();
        }

      

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AddLecturers df = new AddLecturers();
            df.Show();
            this.Hide();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            AddSubjects df = new AddSubjects();
            df.Show();
            this.Hide();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            ManageSubjects df = new ManageSubjects();
            df.Show();
            this.Hide();
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            AddLocation df = new AddLocation();
            df.Show();
            this.Hide();
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            ManageLocations df = new ManageLocations();
            df.Show();
            this.Hide();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            AddStudentGroup df = new AddStudentGroup();
            df.Show();
            this.Hide();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            AddTag df = new AddTag();
            df.Show();
            this.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ManageLecturers df = new ManageLecturers();
            df.Show();
            this.Hide();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            ManageStudentGroups df = new ManageStudentGroups();
            df.Show();
            this.Hide();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            ManageTags df = new ManageTags();
            df.Show();
            this.Hide();
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            Statics df = new Statics();
            df.Show();
            this.Hide();
        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            AddSession df = new AddSession(0);
            df.Show();
            this.Hide();
        }

        private void metroButton15_Click(object sender, EventArgs e)
        {
            ManageSessions df = new ManageSessions();
            df.Show();
            this.Hide();
        }

        private void metroButton16_Click(object sender, EventArgs e)
        {
            SessionAndNotAvailableTimeAllocation df = new SessionAndNotAvailableTimeAllocation();
            df.Show();
            this.Hide();
        }

        private void metroButton19_Click(object sender, EventArgs e)
        {
            ManageLocationsForSessions df = new ManageLocationsForSessions();
            df.Show();
            this.Hide();
        }

        private void metroButton17_Click(object sender, EventArgs e)
        {
            GenerateTimeTables df = new GenerateTimeTables();
            df.Show();
            this.Hide();
        }

        private void metroButton20_Click(object sender, EventArgs e)
        {

        }

        private void metroButton21_Click(object sender, EventArgs e)
        {
            AddTimeForSessions df = new AddTimeForSessions();
            df.Show();
            this.Hide();
        }
    }
}
