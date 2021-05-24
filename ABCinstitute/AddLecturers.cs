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
    public partial class AddLecturers : MetroFramework.Forms.MetroForm
    {
        public AddLecturers()
        {
           
            InitializeComponent();
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (VerificationFunction())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("insertLecturerDetails", con))
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

                        con.Open();


                        cmd.ExecuteScalar();
                        MessageBox.Show("Lecturer Added Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clerTextFields();


                    }
                }
            }
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
            if (cb.SelectedIndex==-1)
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
            Lecturer_Name.Text = "";
            Center.SelectedIndex = -1;
            Employee_Id.Text = "";
            Building.SelectedIndex = -1;
            Faculty.SelectedIndex = -1;
            Level.SelectedIndex = -1;
            Department.SelectedIndex = -1;
            Rank.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenu df = new MainMenu();
            df.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Rank.Text= Level.Text.Trim()+"." +Employee_Id.Text.Trim();
        }


        private void empIdText_TextChanged(object sender, EventArgs e)
        {
            if (Employee_Id.Text.Length > 6) {
                MessageBox.Show("Emp ID  should be 6 digit number (Eg: 000150)", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Employee_Id.Text = Employee_Id.Text.Trim().Remove(Employee_Id.Text.Trim().Length - 1, 1);
            }
        }

     
    }
}
