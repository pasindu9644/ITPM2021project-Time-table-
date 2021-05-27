using Student_Management_System.general;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Student_Management_System
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
       

        public Login()
        {
            InitializeComponent();
            metroDateTime1.Value = DateTime.Now;
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (isValid()) {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString())) {
                    using (SqlCommand cmd = new SqlCommand("verifyLoginDetails", con)) {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserName", usernameTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", pwTextBox.Text.Trim());

                        con.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        if (sdr.Read())
                        {
                            MainMenu df = new MainMenu();
                            df.Show();
                            this.Hide();
                        }
                        else {
                            MessageBox.Show("Invalid user name passsword", "login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private bool isValid()
        {
            if (usernameTextBox.Text.Trim() == string.Empty) {
                MessageBox.Show("user name is required", "login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (pwTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("password is required", "login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }


        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
