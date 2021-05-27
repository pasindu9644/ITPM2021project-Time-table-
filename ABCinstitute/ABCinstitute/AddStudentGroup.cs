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
    public partial class AddStudentGroup : MetroFramework.Forms.MetroForm
    {
        public AddStudentGroup()
        {
           
            InitializeComponent();
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (VerificationFunction())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("insertGroupDetails", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@academicYrSem", Academic_Year_Semester.Text.Trim());
                        cmd.Parameters.AddWithValue("@programmeId", Programme.SelectedValue);
                        cmd.Parameters.AddWithValue("@groupNo", groupNoText.Text.Trim());
                        cmd.Parameters.AddWithValue("@subGrpNo", subGroupNoText.Text.Trim());
                        cmd.Parameters.AddWithValue("@groupId", Group_Id.Text.Trim());
                        cmd.Parameters.AddWithValue("@subGrpId", Sub_Group_Id.Text.Trim());
                        con.Open();


                        cmd.ExecuteScalar();
                        MessageBox.Show("Student Group Added Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clerTextFields();


                    }
                }
            }
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
            clerTextFields();
        }

        private void clerTextFields()
        {
            Academic_Year_Semester.Text= "";
            Programme.SelectedIndex = -1;
            groupNoText.Text = "";
            subGroupNoText.Text = "";
            Group_Id.Text = "";
            Sub_Group_Id.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenu df = new MainMenu();
            df.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Group_Id.Text = Academic_Year_Semester.Text.Trim() + "." + Programme.Text.Trim() + "." + groupNoText.Text.Trim();
            Sub_Group_Id.Text = Group_Id.Text.Trim()+"."+ subGroupNoText.Text.Trim();
            DataTable dt = getGroupListListData();
            foreach (DataRow row in dt.Rows)
            {
                if (Sub_Group_Id.Text == row["SubGroupID"].ToString()) {
                    MessageBox.Show("Sub group Id Cannot duplicate", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clerTextFields();
                }
            }
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
    }
}
