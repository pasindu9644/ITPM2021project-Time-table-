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
    public partial class ManageStudentGroups : MetroFramework.Forms.MetroForm
    {
        private int studentGrpId=0;
        public ManageStudentGroups()
        {
            InitializeComponent();
            LoadAllStudentsData();
            Programme.DataSource = getProgrammeComboData();
            Programme.DisplayMember = "programmeDescription";
            Programme.ValueMember = "ID";
        }
        private object getProgrammeComboData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("loadProgrammeList", con))
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
        private DataTable GetSearchData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                    using (SqlCommand cmd = new SqlCommand("searchStudentGroupList", con))
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

        private void LoadAllStudentsData()
        {
            studentDataGrid.DataSource = GetData();
            
        }
         private void searchStudentsData()
        {
            studentDataGrid.DataSource = GetSearchData();
            
        }

 


        private DataTable GetstudentGrpData(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getstudentGrpDetailsById", con))
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
                    using (SqlCommand cmd = new SqlCommand("updateStudentGrp", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@academicYrSem", Academic_Year_Semester.Text.Trim());
                        cmd.Parameters.AddWithValue("@programmeId", Programme.SelectedValue);
                        cmd.Parameters.AddWithValue("@groupNo", groupNoText.Text.Trim());
                        cmd.Parameters.AddWithValue("@subGrpNo", subGroupNoText.Text.Trim());
                        cmd.Parameters.AddWithValue("@groupId", Group_Id.Text.Trim());
                        cmd.Parameters.AddWithValue("@subGrpId", Sub_Group_Id.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", studentGrpId);
                        con.Open();


                        cmd.ExecuteScalar();
                        MessageBox.Show("Student Group Updated Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clerTextFields();
                        studentDataGrid.DataSource = GetData();


                    }
                }
            }
        }

        private void clerTextFields()
        {
            Academic_Year_Semester.Text = "";
            Programme.SelectedIndex = -1;
            groupNoText.Text = "";
            subGroupNoText.Text = "";
            Group_Id.Text = "";
            Sub_Group_Id.Text = "";


        }
        private bool VerificationFunction()
        {
            if (
            CheckTextBox(Academic_Year_Semester) &&
            CheckCombo(Programme) &&
            CheckTextBox(Group_Id) &&
            CheckTextBox(Sub_Group_Id))
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
            var confirmResult = MessageBox.Show("Are you sure to delete this student Group ??",
                               "Confirm Delete!!",
                               MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("deleteStudentGrp", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", studentGrpId);
                        con.Open();


                        cmd.ExecuteScalar();
                        MessageBox.Show("student Group Deleted Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clerTextFields();
                        studentDataGrid.DataSource = GetData();


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

        private void studentDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.studentDataGrid.CurrentRow;
            studentGrpId = Convert.ToInt32(row.Cells[0].Value);
            DataTable studentGrpDetails = GetstudentGrpData(studentGrpId);
            DataRow dr;
            dr = studentGrpDetails.Rows[0];

            Academic_Year_Semester.Text = dr["academicYrSem"].ToString();
            Programme.SelectedValue = dr["programmeId"].ToString();
            groupNoText.Text = dr["groupNo"].ToString();
            subGroupNoText.Text = dr["subGrpNo"].ToString();
            Group_Id.Text = dr["groupId"].ToString();
            Sub_Group_Id.Text = dr["subGrpId"].ToString();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            searchStudentsData();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            clerTextFields();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            LoadAllStudentsData();
        }
    }
}
