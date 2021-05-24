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
    public partial class ManageLecturers : MetroFramework.Forms.MetroForm
    {
        private int lectureId = 0;
        public ManageLecturers()
        {
            InitializeComponent();
            LoadAllLecturersData();
            setFacComboData();
            setDeptComboData();
            setCenterComboData();
            setBuildingComboData();
            setLevelComboData();
        }

        private void setLevelComboData()
        {
            Level.DataSource = getLevelList();
            Level.DisplayMember = "level";
            Level.ValueMember = "ID";
        }

        private void setBuildingComboData()
        {
            Building.DataSource = getLocationList();
            Building.DisplayMember = "RoomName";
            Building.ValueMember = "ID";
        }

        private void setCenterComboData()
        {
            Center.DataSource = getCenterList();
            Center.DisplayMember = "center";
            Center.ValueMember = "ID";
        }

        private void setDeptComboData()
        {

            Department.DataSource = getDeptList();
            Department.DisplayMember = "deptName";
            Department.ValueMember = "ID";
        }

        private void setFacComboData()
        {
            Faculty.DataSource = getFacList();
            Faculty.DisplayMember = "facultyName";
            Faculty.ValueMember = "ID";
        }

        private object getLevelList()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("loadLevelList", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private object getLocationList()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("loadComboLocationList", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private object getCenterList()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("loadCenterList", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private object getDeptList()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("loadDeptList", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private object getFacList()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("loadFacList", con))
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
        private DataTable GetSearchData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("searchLecturerList", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@searchText", searchText.Text.Trim());
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private void searchLecturesData()
        {
            lecturerDataGrid.DataSource = GetSearchData();

        }

        private void LoadAllLecturersData()
        {
            lecturerDataGrid.DataSource = GetData();
            
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

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            if (VerificationFunction())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("updateLecturer", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@LecturerName", Lecturer_Name.Text.Trim());
                        cmd.Parameters.AddWithValue("@centerId", Center.SelectedValue);
                        cmd.Parameters.AddWithValue("@empId", Employee_Id.Text.Trim());
                        cmd.Parameters.AddWithValue("@locationId", Building.SelectedValue);
                        cmd.Parameters.AddWithValue("@facId", Faculty.SelectedValue);
                        cmd.Parameters.AddWithValue("@levelId", Level.SelectedValue);
                        cmd.Parameters.AddWithValue("@deptId", Department.SelectedValue);
                        cmd.Parameters.AddWithValue("@rank", Rank.Text.Trim());

                        cmd.Parameters.AddWithValue("@id", lectureId);



                        con.Open();


                        cmd.ExecuteScalar();
                        MessageBox.Show("Lecturer Details Updated Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clerTextFields();
                        lecturerDataGrid.DataSource = GetData();


                    }
                }
            }
        }

        private void clerTextFields()
        {
            Lecturer_Name.Text = "";
            Center.SelectedIndex = -1;
            Employee_Id.Text = "";
            Building.SelectedIndex = -1;
            Faculty.SelectedIndex = -1;
            Level.SelectedIndex = -1;
            Department.SelectedIndex = -1;
            Rank.Text = "";

        }

        private bool VerificationFunction()
        {
            if (
            CheckTextBox(Lecturer_Name) &&
            CheckTextBox(Employee_Id) &&
            CheckTextBox(Rank) &&
            CheckCombo(Center) &&
            CheckCombo(Building) &&
            CheckCombo(Faculty) &&
            CheckCombo(Level) &&
            CheckCombo(Department))
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

        private void metroButton4_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this Lecturer ??",
                               "Confirm Delete!!",
                               MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("deleteLecturer", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", lectureId);
                        con.Open();


                        cmd.ExecuteScalar();
                        MessageBox.Show("Lecturer Deleted Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clerTextFields();
                        lecturerDataGrid.DataSource = GetData();


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

        private void lecturerDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.lecturerDataGrid.CurrentRow;
            lectureId = Convert.ToInt32(row.Cells[0].Value);
            DataTable lecturerDetails = getLecturerData(lectureId);
            DataRow dr;
            dr = lecturerDetails.Rows[0];

            Lecturer_Name.Text = dr["LecturerName"].ToString();
            Center.SelectedValue = dr["centerId"].ToString();
            Employee_Id.Text = dr["empId"].ToString();
            Building.SelectedValue = dr["locationId"].ToString();
            Faculty.SelectedValue = dr["facId"].ToString();
            Level.SelectedValue = dr["levelId"].ToString();
            Department.SelectedValue = dr["deptId"].ToString();
            Rank.Text = dr["rank"].ToString();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            clerTextFields();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            searchLecturesData();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            LoadAllLecturersData();
        }
    }
}
