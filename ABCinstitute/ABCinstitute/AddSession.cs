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
    public partial class AddSession : MetroFramework.Forms.MetroForm
    {
        ArrayList lecturers = new ArrayList();
        int inc = 0;
        bool updateMode = false;
        int sessionId = 0;
        public AddSession(int id)
        {

            InitializeComponent();
            getLectureList();
            getTagList();
            getSubjectList();
            getSessionTypesList();
            if (id != 0) {
                loadSessionDetails(id);
                metroButton4.Text = "Update";
                metroLabel1.Text = "Update Session";
                updateMode = true;
                sessionId = id;
            }

        }

        private void getSessionTypesList()
        {
            Session_Type.DataSource = getSessionTypeListData();
            Session_Type.DisplayMember = "sessionType";
            Session_Type.ValueMember = "Id";
        }

        private object getSessionTypeListData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("loadSessionTypes", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private void loadSessionDetails(int id)
        {
            DataTable sessionDetails = getSessionData(id);
            DataRow dr;
            dr = sessionDetails.Rows[0];
            lecturers.Add(dr["lecturer1Id"].ToString());
            lecturers.Add(dr["lecturer2Id"].ToString());
            Tag.SelectedValue = dr["tagId"].ToString();
            Group.SelectedValue = dr["groupId"].ToString();
            Subject.SelectedValue = dr["subjectId"].ToString();
            Session_Type.SelectedValue = dr["sessionTypeId"].ToString();
            No_Of_Students.Text= dr["noOfStudents"].ToString();
            Duration.Text = dr["duration"].ToString();

            DataTable lecturerDetails = getLecturerData(Convert.ToInt32(lecturers[0]));
            dr = lecturerDetails.Rows[0];

            lecNameText.Text = dr["LecturerName"].ToString();

            lecturerDetails = getLecturerData(Convert.ToInt32(lecturers[1]));
            dr = lecturerDetails.Rows[0];
            lecNameText.Text +=","+ dr["LecturerName"].ToString();
        }


        private DataTable getSessionData(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getsessionDetailsById", con))
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

        
        private void getSubjectList()
        {
            Subject.DataSource = getSubjectListData();
            Subject.DisplayMember = "SubjectName";
            Subject.ValueMember = "ID";
        }

        private void getGroupList()
        {
            Group.DataSource = getGroupListListData();
            Group.DisplayMember = "GroupID";
            Group.ValueMember = "ID";
        }
        private void getSubGroupList()
        {
            Group.DataSource = getGroupListListData();
            Group.DisplayMember = "SubGroupID";
            Group.ValueMember = "ID";
        }

        private void getTagList()
        {
            Tag.DataSource = getTagListData();
            Tag.DisplayMember = "TagName";
            Tag.ValueMember = "ID";
        }

        private void getLectureList()
        {
            Lecturer.DataSource = getLectureListData();
            Lecturer.DisplayMember = "Name";
            Lecturer.ValueMember = "ID";
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
        private DataTable getSubjectListData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("loadSubjectList", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }
        private DataTable getTagListData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("loadTagList", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }
        private DataTable getGroupListListData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("loadStudentGroupList", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private DataTable getLecturerData(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getLecturerDetailsById", con))
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (inc == 2)
            {
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("add 2 Lecturers ", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void metroButton6_Click(object sender, EventArgs e)
        {
            if (inc < 2)
            {
                int licId = Convert.ToInt32(Lecturer.SelectedValue);
                lecturers.Add(licId);
                DataTable lecturerDetails = getLecturerData(licId);
                DataRow dr;
                dr = lecturerDetails.Rows[0];
                if (inc == 1)
                {
                    lecNameText.Text += ",";
                }
                lecNameText.Text += dr["LecturerName"].ToString();

                
                inc++;
            }
            else
            {
                MessageBox.Show("Only 2 Lecturers Allowed", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            Lecturer.SelectedIndex = -1;
            Tag.SelectedIndex = -1;
            lecturers.Clear();
            lecNameText.Text = "";
        }

        private void metroButton5_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Group.SelectedIndex = -1;
            Subject.SelectedIndex = -1;
            No_Of_Students.Text = "";
            Duration.Text = "";
        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            if (VerificationFunction())
            {
                if (updateMode)
                {
                    using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("updateSessionDetails", con))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@lecturer1Id", lecturers[0]);
                            cmd.Parameters.AddWithValue("@lecturer2Id", lecturers[1]);
                            cmd.Parameters.AddWithValue("@subjectId", Subject.SelectedValue);
                            cmd.Parameters.AddWithValue("@sessionTypeId", Session_Type.SelectedValue);
                            cmd.Parameters.AddWithValue("@groupId", Group.SelectedValue);
                            cmd.Parameters.AddWithValue("@tagId", Tag.SelectedValue);
                            cmd.Parameters.AddWithValue("@noOfStudents", No_Of_Students.Text.Trim());
                            cmd.Parameters.AddWithValue("@duration", Duration.Text.Trim());
                            cmd.Parameters.AddWithValue("@id", sessionId);

                            con.Open();

                            cmd.ExecuteScalar();
                            MessageBox.Show("Session Updated Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ManageSessions df = new ManageSessions();
                            df.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("insertSessionDetails", con))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@lecturer1Id", lecturers[0]);
                            cmd.Parameters.AddWithValue("@lecturer2Id", lecturers[1]);
                            cmd.Parameters.AddWithValue("@subjectId", Subject.SelectedValue);
                            cmd.Parameters.AddWithValue("@sessionTypeId", Session_Type.SelectedValue);
                            cmd.Parameters.AddWithValue("@groupId", Group.SelectedValue);
                            cmd.Parameters.AddWithValue("@tagId", Tag.SelectedValue);
                            cmd.Parameters.AddWithValue("@noOfStudents", No_Of_Students.Text.Trim());
                            cmd.Parameters.AddWithValue("@duration", Duration.Text.Trim());

                            con.Open();

                            cmd.ExecuteScalar();
                            MessageBox.Show("Session Added Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            tabControl1.SelectedIndex = 0;
                            Group.SelectedIndex = -1;
                            Subject.SelectedIndex = -1;
                            No_Of_Students.Text = "";
                            Duration.Text = "";
                            Lecturer.SelectedIndex = -1;
                            Tag.SelectedIndex = -1;
                            lecturers.Clear();
                            lecNameText.Text = "";
                            inc = 0;
                        }
                    }
                }
            }
        }
        private bool VerificationFunction()
        {
            if (
            CheckCombo(Lecturer) &&
            CheckCombo(Tag) &&
            CheckCombo(Group) &&
            CheckCombo(Subject) &&
            CheckCombo(Session_Type)&& 
            CheckTextBox(No_Of_Students) &&
            CheckTextBox(Duration))
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
        private void tagsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tag.Text.ToString() == "Lab")
            {
                getSubGroupList();
            }
            else {
                getGroupList();
            }
        }
    }
}

