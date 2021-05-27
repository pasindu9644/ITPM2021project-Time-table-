using Student_Management_System.general;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MetroFramework.Controls;
using System.Collections;

namespace Student_Management_System
{
    public partial class AddLocationForSessions : MetroFramework.Forms.MetroForm
    {
        ArrayList SessionList = new ArrayList();
        int Inc = 0;
        public AddLocationForSessions()
        {
           
            InitializeComponent();
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            Session.DataSource = getSessionList();
            Session.DisplayMember = "session";
            Session.ValueMember = "ID";

            Location.DataSource = getRoomsList();
            Location.DisplayMember = "Room";
            Location.ValueMember = "ID";
            
        }

        private object getRoomsList()
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

        private DataTable getSessionList()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getLocationComboSessions", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (VerificationFunction())
            {
                foreach (object session in SessionList)
                {
                    using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("insertLocationSession", con))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;


                            cmd.Parameters.AddWithValue("@locationId", Location.SelectedValue);
                            cmd.Parameters.AddWithValue("@sessionId", session);


                            con.Open();


                            cmd.ExecuteScalar();



                        }
                    }
                }
                MessageBox.Show("Session Locations Added Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clerTextFields();
            }
        }

        private bool VerificationFunction()
        {
            if (
            CheckCombo(Session) &&
            CheckCombo(Location))
            {
                return true;
            }

            else
                return false;
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

        private void metroButton4_Click(object sender, EventArgs e)
        {
            clerTextFields();
        }

        private void clerTextFields()
        {
           
            Session.SelectedIndex = -1;
            Location.SelectedIndex = -1;
            selectedSessions.Text = "";
            SessionList.Clear();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageLocationsForSessions df = new ManageLocationsForSessions();
            df.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            int SessionId = Convert.ToInt32(Session.SelectedValue);
            SessionList.Add(SessionId);
            DataTable sessionDetails = getComboSessionsById(SessionId);
            DataRow dr;
            dr = sessionDetails.Rows[0];
            if (Inc !=0 )
            {
                selectedSessions.Text += ","+ Environment.NewLine;
            }
            selectedSessions.Text += dr["session"].ToString();
            Inc++;
        }
        private DataTable getComboSessionsById(int sessionId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getComboSessionsById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", sessionId);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }
    }
}
