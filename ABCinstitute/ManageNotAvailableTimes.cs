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
    public partial class ManageNotAvailableTimes : MetroFramework.Forms.MetroForm
    {
        private int Id = 0;
        private int GlobalId = 0;
        string type = "";
        public ManageNotAvailableTimes(string Type,int id)
        {
            InitializeComponent();
            type = Type;
            GlobalId = id;
            switch (Type)
            {
                case "lecturer":
                    getNotAvailableLectureList();
                    break;
                case "group":
                    getNotAvailableGroupList();
                    break;
                case "subGroup":
                    getNotAvailableSubGroupList();
                    break;
                case "session":
                    getNotAvailableSessionList();
                    break;
            }

        }

        private void getNotAvailableSessionList()
        {
            DataGrid.DataSource = GetSessionData(GlobalId);
        }

        private object GetSessionData(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getNotAvailabeSessionDetailsById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private void getNotAvailableSubGroupList()
        {
            DataGrid.DataSource = GetSubGroupData(GlobalId);
        }

        private object GetSubGroupData(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getNotAvailabeSubGroupDetailsById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private void getNotAvailableGroupList()
        {
            DataGrid.DataSource = GetGroupData(GlobalId);
        }

        private object GetGroupData(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getNotAvailabeGroupDetailsById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private void getNotAvailableLectureList()
        {
            DataGrid.DataSource = GetLecturerData(GlobalId);
        }

        private object GetLecturerData(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getNotAvailabeLecturerDetailsById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

  
        private void metroButton4_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this Record ??",
                               "Confirm Delete!!",
                               MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                {
                    switch (type)
                    {
                        case "lecturer":
                            using (SqlCommand cmd = new SqlCommand("deleteNotAvailabeLecturer", con))
                            {

                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id", Id);
                                con.Open();
                                cmd.ExecuteScalar();
                                MessageBox.Show("Record Deleted Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                getNotAvailableLectureList();
                            }
                            break;
                        case "group":
                            using (SqlCommand cmd = new SqlCommand("deleteNotAvailabeGroup", con))
                            {

                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id", Id);
                                con.Open();
                                cmd.ExecuteScalar();
                                MessageBox.Show("Record Deleted Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                getNotAvailableGroupList();
                            }
                            break;
                        case "subGroup":
                            using (SqlCommand cmd = new SqlCommand("deleteNotAvailabeSubGroup", con))
                            {

                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id", Id);
                                con.Open();
                                cmd.ExecuteScalar();
                                MessageBox.Show("Record Deleted Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                getNotAvailableSubGroupList();
                            }
                            break;
                        case "session":
                            using (SqlCommand cmd = new SqlCommand("deleteNotAvailabeSession", con))
                            {

                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id", Id);
                                con.Open();
                                cmd.ExecuteScalar();
                                MessageBox.Show("Record Deleted Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                getNotAvailableSessionList();
                            }
                            break;
                    }
                    
                }
            }
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenu df = new MainMenu();
            df.Show();
            this.Hide();
        }

     

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.DataGrid.CurrentRow;
            Id = Convert.ToInt32(row.Cells[0].Value);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            MainMenu df = new MainMenu();
            df.Show();
            this.Hide();
        }
    }
}
