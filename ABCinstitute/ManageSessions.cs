using Student_Management_System.general;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class ManageSessions : MetroFramework.Forms.MetroForm
    {
        private int sessionId = 0;
        public ManageSessions()
        {
            InitializeComponent();
            LoadAllSessionData();
            getLectureList();
            searchLecNameCombo.SelectedIndex = -1;

        }

        private void getLectureList()
        {
            searchLecNameCombo.DataSource = getLectureListData();
            searchLecNameCombo.DisplayMember = "Name";
            searchLecNameCombo.ValueMember = "ID";
        }

        private DataTable getLectureListData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("loadLecturerList", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }
        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                    using (SqlCommand cmd = new SqlCommand("loadSessions", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                    }               
            }
            return dt;
        }
        private DataTable GetSearchData()
        {
            int lecId;
            string Yr;
            if (searchLecNameCombo.Text == "")
            {
                lecId = 0;
            }
            else
                lecId = Convert.ToInt32(searchLecNameCombo.SelectedValue);
            if (searchYrText.Text == "")
            {
                Yr = "0";
            }
            else
                Yr = searchYrText.Text;
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("searchSessionDetails", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@LecId", lecId);
                    cmd.Parameters.AddWithValue("@year", Yr);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private void LoadAllSessionData()
        {
            sessionDataGrid.DataSource = GetData();
            
        }

    


        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            sessionDataGrid.DataSource = GetSearchData();
        }

        private void clerTextFields()
        {
            searchYrText.Text = "";
            searchLecNameCombo.SelectedIndex = -1;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenu df = new MainMenu();
            df.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            sessionDataGrid.DataSource = GetData();
            searchLecNameCombo.SelectedIndex = -1;
            searchYrText.Text = "";

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            AddSession df = new AddSession(sessionId);
            df.Show();
            this.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this Session ??",
                               "Confirm Delete!!",
                               MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("deleteSession", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", sessionId);
                        con.Open();


                        cmd.ExecuteScalar();
                        MessageBox.Show("Session Deleted Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clerTextFields();
                        sessionDataGrid.DataSource = GetData();


                    }
                }
            }

        }

        private void sessionDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.sessionDataGrid.CurrentRow;
            sessionId = Convert.ToInt32(row.Cells[0].Value);
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            ViewSession df = new ViewSession(sessionId);
            df.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            AddSession df = new AddSession(0);
            df.Show();
            this.Hide();
        }
    }
}
