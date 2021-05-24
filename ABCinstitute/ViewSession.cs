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
    public partial class ViewSession : MetroFramework.Forms.MetroForm
    {
        ArrayList lecturers = new ArrayList();
        int sessionId = 0;
        public ViewSession(int id)
        {

            InitializeComponent();
            if (id != 0) {
                loadSessionDetails(id);
            }

        }

        private void loadSessionDetails(int id)
        {
            DataTable sessionDetails = getSessionData(id);
            DataRow dr;
            dr = sessionDetails.Rows[0];
            noOfStudentsText.Text = dr["noOfStudents"].ToString();
            tagText.Text = dr["Tag"].ToString();
            subjectText.Text = dr["SubjectName"].ToString();
            groupText.Text= dr["GroupID"].ToString();
            durationText.Text = dr["duration"].ToString();


            lecNameText.Text = dr["Lecturer1"].ToString();
            lecNameText.Text += "," + dr["Lecture2"].ToString();
        }


        private DataTable getSessionData(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getsessionViewDetailsById", con))
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


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenu df = new MainMenu();
            df.Show();
            this.Hide();
        }
    }
}

