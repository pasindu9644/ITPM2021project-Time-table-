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
    public partial class AddSubjects : MetroFramework.Forms.MetroForm
    {
        public AddSubjects()
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
                    using (SqlCommand cmd = new SqlCommand("insertSubjectDetails", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@offeredYear", Offered_Year.Text.Trim());
                        cmd.Parameters.AddWithValue("@subjectName", Subject_Name.Text.Trim());
                        cmd.Parameters.AddWithValue("@subjectCode", Subject_Code.Text.Trim());
                        cmd.Parameters.AddWithValue("@noOfLecHrs", noOfLecHorsText.Text.Trim());
                        cmd.Parameters.AddWithValue("@noOfTutHrs", noOfTutHorsText.Text.Trim());
                        cmd.Parameters.AddWithValue("@noOfLabHrs", noOfLabHorsText.Text.Trim());
                        cmd.Parameters.AddWithValue("@noOfEvaHrs", noOfEvoHorsText.Text.Trim());
                        if (metroRadioButton1.Checked)
                        {
                            cmd.Parameters.AddWithValue("@offeredSemester", "1st Semester");
                        }
                        else
                            cmd.Parameters.AddWithValue("@offeredSemester", "2nd Semester");

                        con.Open();


                        cmd.ExecuteScalar();
                        MessageBox.Show("Subject Added Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clerTextFields();


                    }
                }
            }
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
            clerTextFields();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenu df = new MainMenu();
            df.Show();
            this.Hide();
        }
    }
}
