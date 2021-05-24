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
    public partial class AddWorkingHoursDays : MetroFramework.Forms.MetroForm
    {
        bool isUpdate;
        public AddWorkingHoursDays()
        {
           
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getLectureList();
            metroButton4.Text = "Add";
            isUpdate = false;
        }

        private void getLectureList()
        {
            Lecturer.DataSource = getLectureListData();
            Lecturer.DisplayMember = "Name";
            Lecturer.ValueMember = "ID";
            Lecturer.SelectedIndex = -1;
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
     

        private void metroButton4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                if (isUpdate)
                {
                    using (SqlCommand cmd = new SqlCommand("updateWorkingDaysHrsDetails", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@noOfWorkingDays", noOfWorkingDays.Text.Trim());

                        if (checkBox1.Checked)
                        {
                            cmd.Parameters.AddWithValue("@monday", 1);
                        }
                        else
                            cmd.Parameters.AddWithValue("@monday", 0);

                        if (checkBox2.Checked)
                        {
                            cmd.Parameters.AddWithValue("@tuesday", 1);
                        }
                        else
                            cmd.Parameters.AddWithValue("@tuesday", 0);

                        if (checkBox3.Checked)
                        {
                            cmd.Parameters.AddWithValue("@wednesday", 1);
                        }
                        else
                            cmd.Parameters.AddWithValue("@wednesday", 0);

                        if (checkBox4.Checked)
                        {
                            cmd.Parameters.AddWithValue("@thursday", 1);
                        }
                        else
                            cmd.Parameters.AddWithValue("@thursday", 0);

                        if (checkBox5.Checked)
                        {
                            cmd.Parameters.AddWithValue("@friday", 1);
                        }
                        else
                            cmd.Parameters.AddWithValue("@friday", 0);

                        if (checkBox6.Checked)
                        {
                            cmd.Parameters.AddWithValue("@satday", 1);
                        }
                        else
                            cmd.Parameters.AddWithValue("@satday", 0);

                        if (checkBox7.Checked)
                        {
                            cmd.Parameters.AddWithValue("@sunday", 1);
                        }
                        else
                            cmd.Parameters.AddWithValue("@sunday", 0);

                        cmd.Parameters.AddWithValue("@hrs", HorsText.Text.Trim());
                        cmd.Parameters.AddWithValue("@mins", minsText.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", Lecturer.SelectedValue);


                        con.Open();


                        cmd.ExecuteScalar();
                        MessageBox.Show("WorkingDays And Hours Updated Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Lecturer.SelectedIndex = -1;
                        clearFields();
                    }
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand("addWorkingDaysHrsDetails", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@noOfWorkingDays", noOfWorkingDays.Text.Trim());

                        if (checkBox1.Checked)
                        {
                            cmd.Parameters.AddWithValue("@monday", 1);
                        }
                        else
                            cmd.Parameters.AddWithValue("@monday", 0);

                        if (checkBox2.Checked)
                        {
                            cmd.Parameters.AddWithValue("@tuesday", 1);
                        }
                        else
                            cmd.Parameters.AddWithValue("@tuesday", 0);

                        if (checkBox3.Checked)
                        {
                            cmd.Parameters.AddWithValue("@wednesday", 1);
                        }
                        else
                            cmd.Parameters.AddWithValue("@wednesday", 0);

                        if (checkBox4.Checked)
                        {
                            cmd.Parameters.AddWithValue("@thursday", 1);
                        }
                        else
                            cmd.Parameters.AddWithValue("@thursday", 0);

                        if (checkBox5.Checked)
                        {
                            cmd.Parameters.AddWithValue("@friday", 1);
                        }
                        else
                            cmd.Parameters.AddWithValue("@friday", 0);

                        if (checkBox6.Checked)
                        {
                            cmd.Parameters.AddWithValue("@satday", 1);
                        }
                        else
                            cmd.Parameters.AddWithValue("@satday", 0);

                        if (checkBox7.Checked)
                        {
                            cmd.Parameters.AddWithValue("@sunday", 1);
                        }
                        else
                            cmd.Parameters.AddWithValue("@sunday", 0);

                        cmd.Parameters.AddWithValue("@hrs", HorsText.Text.Trim());
                        cmd.Parameters.AddWithValue("@mins", minsText.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", Lecturer.SelectedValue);

                        con.Open();


                        cmd.ExecuteScalar();
                        MessageBox.Show("WorkingDays And Hours Added Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Lecturer.SelectedIndex = -1;
                        clearFields();
                    }
                }
            }
        }

        private void clearFields()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            noOfWorkingDays.ResetText();
            HorsText.ResetText();
            minsText.ResetText();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenu df = new MainMenu();
            df.Show();
            this.Hide();
        }

        private void resetCheckBoxes() {

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
        }

        private void Lecturer_SelectionChangeCommitted(object sender, EventArgs e)
        {

            resetCheckBoxes();
            int lectureId = Convert.ToInt32(Lecturer.SelectedValue);
            DataTable Details = getData(lectureId);
            DataRow dr;
            if (Details.Rows.Count > 0)
            {
                isUpdate = true;
                metroButton4.Text = "Update";
                dr = Details.Rows[0];

                noOfWorkingDays.Text = dr["noOfWorkingDays"].ToString();
                if (dr["monday"].ToString() == "1")
                {
                    checkBox1.Checked = true;
                }
                if (dr["tuesday"].ToString() == "1")
                {
                    checkBox2.Checked = true;
                }
                if (dr["wednesday"].ToString() == "1")
                {
                    checkBox3.Checked = true;
                }
                if (dr["thursday"].ToString() == "1")
                {
                    checkBox4.Checked = true;
                }
                if (dr["friday"].ToString() == "1")
                {
                    checkBox5.Checked = true;
                }
                if (dr["satday"].ToString() == "1")
                {
                    checkBox6.Checked = true;
                }
                if (dr["sunday"].ToString() == "1")
                {
                    checkBox7.Checked = true;
                }

                HorsText.Text = dr["hrs"].ToString();
                minsText.Text = dr["mins"].ToString();
            }
            else {
                clearFields();
                metroButton4.Text = "Add";
                isUpdate = false;
            }
            
        }

        private DataTable getData(int lectureId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("loadWorkingDaysHrs", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", lectureId);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete All Records ??",
                              "Confirm Delete!!",
                              MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("deleteWorkingDaysHrsDetails", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();


                        cmd.ExecuteScalar();
                        MessageBox.Show("All Reecords Deleted Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                    }
                }
            }
        }
    }
}
