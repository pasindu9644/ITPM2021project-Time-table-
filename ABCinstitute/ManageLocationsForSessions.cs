using MetroFramework.Controls;
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
    public partial class ManageLocationsForSessions : MetroFramework.Forms.MetroForm
    {
        public ManageLocationsForSessions()
        {
            InitializeComponent();
            LoadAllSessionData();
            loadLocationComboData();
        }

        private void loadLocationComboData()
        {
            Location.DataSource = getLocationListData();
            Location.DisplayMember = "Room";
            Location.ValueMember = "ID";
        }

        private object getLocationListData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getLocationCombo", con))
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
                    using (SqlCommand cmd = new SqlCommand("loadLocationSessions", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                    }               
            }
            return dt;
        }

        private DataTable GetConcectiveSessionData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                    using (SqlCommand cmd = new SqlCommand("getConcectiveSessions", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
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
            sessionDataGrid.Columns[0].Width = 20;

        }
        private void LoadAllConsectiveSessionData()
        {
            consectiveSessionDataGrid.DataSource = GetConcectiveSessionData();
            consectiveSessionDataGrid.Columns[0].Width = 20;

        }
        

        private DataTable GetLocationData(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getLocationDetailsById", con))
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

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            AddLocationForSessions df = new AddLocationForSessions();
            df.Show();
            this.Hide();
        }

        private void clerTextFields()
        {
            Location.SelectedIndex = -1;
            Time_From.Text = "";
            Time_To.Text = "";
            dateCombo.Value = DateTime.Now;

        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenu df = new MainMenu();
            df.Show();
            this.Hide();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            AddLocationForConsectiveSessions df = new AddLocationForConsectiveSessions();
            df.Show();
            this.Hide();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            if (VerificationFunction())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                {

                    using (SqlCommand cmd = new SqlCommand("insertLocationNotAvailableTime", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@date", dateCombo.Value);
                        cmd.Parameters.AddWithValue("@timeFrom", Time_From.Text.Trim());
                        cmd.Parameters.AddWithValue("@timeTo", Time_To.Text.Trim());
                        cmd.Parameters.AddWithValue("@locationId", Location.SelectedValue);
                        con.Open();
                        cmd.ExecuteScalar();
                        MessageBox.Show("Not Available Time Added Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clerTextFields();
                    }
                }
            }
        }

        private bool VerificationFunction()
        {
            if (
            CheckCombo(Location)&&
            CheckTextBox(Time_From) &&
            CheckTextBox(Time_To)
            )
            {
                return true;
            }

            else
                return false;
        }

        private bool CheckTextBox(MetroTextBox tb)
        {
            if (string.IsNullOrEmpty(tb.Text))
            {
                MessageBox.Show(tb.Name + " must be Filled", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private bool CheckCombo(MetroComboBox cb)
        {
            if (cb.SelectedIndex == -1)
            {
                MessageBox.Show(cb.Name + " must be Selected", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {

                sessionDataGrid.DataSource = GetData();

            }
            if (tabControl1.SelectedIndex == 1)
            {

                LoadAllConsectiveSessionData();

            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            clerTextFields();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
