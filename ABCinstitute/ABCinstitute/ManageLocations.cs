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
    public partial class ManageLocations : MetroFramework.Forms.MetroForm
    {
        private int locationId = 0;
        public ManageLocations()
        {
            InitializeComponent();
            LoadAllLocationsData();
        }

        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                    using (SqlCommand cmd = new SqlCommand("loadLocationList", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                    }               
            }
            return dt;
        }

        private void LoadAllLocationsData()
        {
            locationDataGrid.DataSource = GetData();
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            locationDataGrid.DataSource = GetData();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
          
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            locationDataGrid.DataSource = GetData();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
            
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
            if (VerificationFunction())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("updateLocation", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@buildingName", Building_Name.Text.Trim());
                        cmd.Parameters.AddWithValue("@roomName", Room_Name.Text.Trim());
                        cmd.Parameters.AddWithValue("@capacity", Capacity.Text.Trim());

                        if (metroRadioButton1.Checked)
                        {
                            cmd.Parameters.AddWithValue("@roomType", "Lecture Hall");
                        }
                        else
                            cmd.Parameters.AddWithValue("@roomType", "Laboratory");

                        cmd.Parameters.AddWithValue("@id", locationId);



                        con.Open();


                        cmd.ExecuteScalar();
                        MessageBox.Show("Location Updated Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clerTextFields();
                        locationDataGrid.DataSource = GetData();


                    }
                }
            }
        }

        private void clerTextFields()
        {
            
            Room_Name.Text = "";
            Building_Name.Text = "";
            Capacity.Text = "";
            metroRadioButton1.Checked = false;
            metroRadioButton2.Checked = false;
        }
        private bool VerificationFunction()
        {
            if (
            CheckTextBox(Building_Name) &&
            CheckTextBox(Room_Name) &&
            CheckRadioBtn(metroRadioButton1, metroRadioButton2) &&
            CheckTextBox(Capacity))
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
        private bool CheckRadioBtn(RadioButton rb1, RadioButton rb2)
        {
            if (rb1.Checked || rb2.Checked)
                return true;
            else
            {
                MessageBox.Show("Room Type must be Selected", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void metroButton4_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this Location ??",
                               "Confirm Delete!!",
                               MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("deleteLocation", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", locationId);
                        con.Open();


                        cmd.ExecuteScalar();
                        MessageBox.Show("Location Deleted Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clerTextFields();
                        locationDataGrid.DataSource = GetData();


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

        private void locationDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.locationDataGrid.CurrentRow;
            locationId = Convert.ToInt32(row.Cells[0].Value);
            DataTable locationDetails = GetLocationData(locationId);
            DataRow dr;
            dr = locationDetails.Rows[0];

            Building_Name.Text = dr["buildingName"].ToString();
            Room_Name.Text = dr["roomName"].ToString();
            if (dr["roomType"].ToString() == "Lecture Hall")
            {
                metroRadioButton1.Checked = true;
            }
            else
            {
                metroRadioButton2.Checked = true;
            }

            Capacity.Text = dr["capacity"].ToString();
         
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            clerTextFields();
        }
    }
}
