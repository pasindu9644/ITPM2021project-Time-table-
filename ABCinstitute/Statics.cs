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
    public partial class Statics : MetroFramework.Forms.MetroForm
    {
        public Statics()
        {
            InitializeComponent();
            getLecsCount();
            getStudentsCount();
            getSubsCount();
            getRoomsCount();
            getStudentTop();
            getLecTop();
            getSubjectTop();
            setChart();
        }

        private void setChart()
        {
            DataTable dt = getLecHallCnt();
            DataRow dr;
            dr = dt.Rows[0];
            string LecHallCnt = dr["count"].ToString();
            chart1.Series["Lecture Rooms"].Points.AddXY("Location", LecHallCnt);

            dt = getLabCnt();
            dr = dt.Rows[0];
            string LabCnt = dr["count"].ToString();
            chart1.Series["Laboratories"].Points.AddXY("Location", LabCnt);
            
        }

        private DataTable getLabCnt()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getLabCnt", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private DataTable getLecHallCnt()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getLecHallCnt", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private void getSubjectTop()
        {
            DataTable dt = getSubjectTopData();
            DataRow dr;
            dr = dt.Rows[0];

            latestSubText.Text = dr["subjectName"].ToString();
        }

        private DataTable getSubjectTopData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getSubjectTop", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private void getLecTop()
        {
            DataTable dt = getLecTopData();
            DataRow dr;
            dr = dt.Rows[0];

            latestLecText.Text = dr["LecturerName"].ToString();
        }

        private DataTable getLecTopData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getLecturerTop", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private void getStudentTop()
        {
            DataTable dt = getStudentTopData();
            DataRow dr;
            dr = dt.Rows[0];

            latestGrpText.Text = dr["subGrpId"].ToString();
        }

        private DataTable getStudentTopData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getStudentTop", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private void getRoomsCount()
        {
            DataTable dt = getRoomsCountData();
            DataRow dr;
            dr = dt.Rows[0];

            registeredRooms.Text = dr["count"].ToString();
        }

        private DataTable getRoomsCountData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getRoomsCount", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private void getSubsCount()
        {
            DataTable dt = getSubsCountData();
            DataRow dr;
            dr = dt.Rows[0];

            registeredSubs.Text = dr["count"].ToString();
        }

        private DataTable getSubsCountData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getSubjectCount", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private void getStudentsCount()
        {
            DataTable dt = getStudentData();
            DataRow dr;
            dr = dt.Rows[0];

            registeredStudents.Text = dr["count"].ToString();
        }

        private DataTable getStudentData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getStudentCount", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private void getLecsCount()
        {
            DataTable dt = getLecsCountData();
            DataRow dr;
            dr = dt.Rows[0];

            registeredLecs.Text = dr["count"].ToString();
        }

        private DataTable getLecsCountData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getLecturerCount", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
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
