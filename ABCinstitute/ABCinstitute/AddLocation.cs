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

namespace Student_Management_System
{
    public partial class AddLocation : MetroFramework.Forms.MetroForm
    {
        public AddLocation()
        {
           
            InitializeComponent();
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (VerificationFunction())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("insertLocationDetails", con))
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

                        con.Open();


                        cmd.ExecuteScalar();
                        MessageBox.Show("Location Added Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clerTextFields();


                    }
                }
            }
        }

        private bool VerificationFunction()
        {
            if (
            CheckTextBox(Building_Name) &&
            CheckTextBox(Room_Name)&&
            CheckRadioBtn(metroRadioButton1,metroRadioButton2) &&
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
        private bool CheckRadioBtn(RadioButton rb1,RadioButton rb2)
        {
            if (rb1.Checked||rb2.Checked)
                return true;
            else
            {
                MessageBox.Show("Room Type must be Selected", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            clerTextFields();
        }

        private void clerTextFields()
        {
            Building_Name.Text = "";
            Room_Name.Text = "";
            Capacity.Text = "";
            metroRadioButton1.Checked = false;
            metroRadioButton2.Checked = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenu df = new MainMenu();
            df.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void offeredYearCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
