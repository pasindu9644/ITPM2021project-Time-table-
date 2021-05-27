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
    public partial class ManageSubjects : MetroFramework.Forms.MetroForm
    {
        private int subjectId=0;
        public ManageSubjects()
        {
            InitializeComponent();
            LoadAllSubjectsData();
        }

        private DataTable GetData()
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

        private void LoadAllSubjectsData()
        {
            subjectDataGrid.DataSource = GetData();
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            subjectDataGrid.DataSource = GetData();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
          
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            subjectDataGrid.DataSource = GetData();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void subjectDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.subjectDataGrid.CurrentRow;
            subjectId = Convert.ToInt32(row.Cells[0].Value);
            DataTable subjectDetails = GetSubjectData(subjectId);
            DataRow dr;
            dr = subjectDetails.Rows[0];

            Offered_Year.SelectedItem = dr["offeredYear"].ToString();
            Subject_Name.Text = dr["subjectName"].ToString(); 
            Subject_Code.Text = dr["subjectCode"].ToString(); 
            noOfLecHorsText.Text = dr["noOfLecHrs"].ToString(); 
            noOfTutHorsText.Text = dr["noOfTutHrs"].ToString(); 
            noOfLabHorsText.Text = dr["noOfLabHrs"].ToString(); 
            noOfEvoHorsText.Text = dr["noOfEvaHrs"].ToString();
            if (dr["offeredSemester"].ToString()== "1st Semester") {
                metroRadioButton1.Checked = true;
            }
            else
            metroRadioButton2.Checked = true;


        }

        private DataTable GetSubjectData(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getSubjectDetailsById", con))
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
                    using (SqlCommand cmd = new SqlCommand("updateSubject", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@offeredYear", Offered_Year.Text.Trim());
                        cmd.Parameters.AddWithValue("@subjectName", Subject_Name.Text.Trim());
                        cmd.Parameters.AddWithValue("@subjectCode", Subject_Code.Text.Trim());
                        cmd.Parameters.AddWithValue("@noOfLecHrs", noOfLecHorsText.Text.Trim());
                        cmd.Parameters.AddWithValue("@noOfTutHrs", noOfTutHorsText.Text.Trim());
                        cmd.Parameters.AddWithValue("@noOfLabHrs", noOfLabHorsText.Text.Trim());
                        cmd.Parameters.AddWithValue("@noOfEvaHrs", noOfEvoHorsText.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", subjectId);


                        if (metroRadioButton1.Checked)
                        {
                            cmd.Parameters.AddWithValue("@offeredSemester", "1st Semester");
                        }
                        else
                            cmd.Parameters.AddWithValue("@offeredSemester", "2nd Semester");

                        con.Open();


                        cmd.ExecuteScalar();
                        MessageBox.Show("Subject Updated Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clerTextFields();
                        subjectDataGrid.DataSource = GetData();


                    }
                }
            }
        }

        private void clerTextFields()
        {
            Offered_Year.SelectedIndex = -1;
            Subject_Name.Text = "";
            Subject_Code.Text = "";
            noOfLecHorsText.Text = "";
            noOfTutHorsText.Text = "";
            noOfLabHorsText.Text = "";
            noOfEvoHorsText.Text = "";
            metroRadioButton1.Checked = false;
            metroRadioButton2.Checked = false;
        }
        private bool VerificationFunction()
        {
            if (
            CheckCombo(Offered_Year) &&
            CheckRadioBtn(metroRadioButton1, metroRadioButton2) &&
            CheckTextBox(Subject_Name) &&
            CheckTextBox(Subject_Code)
            )
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
        private bool CheckRadioBtn(RadioButton rb1, RadioButton rb2)
        {
            if (rb1.Checked || rb2.Checked)
                return true;
            else
            {
                MessageBox.Show("Offered Semester must be Selected", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void metroButton4_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this Subject ??",
                               "Confirm Delete!!",
                               MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("deleteSubject", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", subjectId);
                        con.Open();


                        cmd.ExecuteScalar();
                        MessageBox.Show("Subject Deleted Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clerTextFields();
                        subjectDataGrid.DataSource = GetData();


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

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            clerTextFields();
        }
    }
}
