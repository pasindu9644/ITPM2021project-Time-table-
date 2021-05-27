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
    public partial class SessionAndNotAvailableTimeAllocation : MetroFramework.Forms.MetroForm
    {
        int sessionId = 0;
        public SessionAndNotAvailableTimeAllocation()
        {
           
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllSessionData();
        }
        private void LoadAllSessionData()
        {

            addConsectiveCheckBoxes();
            addParellelCheckBoxes();
            addNonOverLpCheckBoxes();
            consectiveSessionDataGrid.DataSource = GetData();
            setConsectiveCheckBoxes();
        }

        private void addConsectiveCheckBoxes() {
            DataGridViewCheckBoxColumn chBox = new DataGridViewCheckBoxColumn();
            chBox.HeaderText = "";
            chBox.Width = 30;
            chBox.Name = "chBox";
            consectiveSessionDataGrid.Columns.Insert(0, chBox);
        }
        private void addParellelCheckBoxes()
        {
            DataGridViewCheckBoxColumn chBox2 = new DataGridViewCheckBoxColumn();
            chBox2.HeaderText = "";
            chBox2.Width = 30;
            chBox2.Name = "chBox2";
            parellelSessionDataGrid.Columns.Insert(0, chBox2);
        }
        private void addNonOverLpCheckBoxes()
        {
            DataGridViewCheckBoxColumn chBox3 = new DataGridViewCheckBoxColumn();
            chBox3.HeaderText = "";
            chBox3.Width = 30;
            chBox3.Name = "chBox3";
            NonOvvrLpSessionDataGrid.Columns.Insert(0, chBox3);
        }
        
        private void setConsectiveCheckBoxes() {
            foreach (DataGridViewRow dr in consectiveSessionDataGrid.Rows)
            {

                if (Convert.ToInt16(dr.Cells["typeId"].Value) == 1)
                {
                    dr.Cells[0].Value = true;
                }

            }
        }


        private void setParellelCheckBoxes()
        {
            foreach (DataGridViewRow dr in parellelSessionDataGrid.Rows)
            {

                if (Convert.ToInt16(dr.Cells["typeId"].Value) == 2)
                {
                    dr.Cells[0].Value = true;
                }

            }
        }
        private void setNonOvrLpCheckBoxes()
        {
            foreach (DataGridViewRow dr in NonOvvrLpSessionDataGrid.Rows)
            {

                if (Convert.ToInt16(dr.Cells["typeId"].Value) == 3)
                {
                    dr.Cells[0].Value = true;
                }

            }
        }

        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("loadSessions", con))
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {

                consectiveSessionDataGrid.DataSource = GetData();
                setConsectiveCheckBoxes();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                
                parellelSessionDataGrid.DataSource = GetData();
                setParellelCheckBoxes();
            }
            if (tabControl1.SelectedIndex == 2)
            {

                NonOvvrLpSessionDataGrid.DataSource = GetData();
                setNonOvrLpCheckBoxes();
            }
            if (tabControl1.SelectedIndex == 3)
            {
                getLectureList();
                getGroupList();
                getSubGroupList();
                getComboSessions();
                Lecturer.SelectedIndex = -1;
                Group.SelectedIndex = -1;
                Sub_Group.SelectedIndex = -1;
                Session.SelectedIndex = -1; 
            }

        }
        private void getGroupList()
        {
            Group.DataSource = getGroupListData();
            Group.DisplayMember = "GroupID";
            Group.ValueMember = "ID";
        }
        private void getSubGroupList()
        {
            Sub_Group.DataSource = getGroupListData();
            Sub_Group.DisplayMember = "SubGroupID";
            Sub_Group.ValueMember = "ID";
        }
        private void getLectureList()
        {
            Lecturer.DataSource = getLectureListData();
            Lecturer.DisplayMember = "Name";
            Lecturer.ValueMember = "ID";
        }

        private void getComboSessions()
        {
            Session.DataSource = getComboSessionsData();
            Session.DisplayMember = "session";
            Session.ValueMember = "ID";
        }

        private object getComboSessionsData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getComboSessions", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
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

        private DataTable getGroupListData()
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

        private DataTable GetSessionData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("loadSessions", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            AddSession df = new AddSession(0);
            df.Show();
            this.Hide();

        }
        private void metroButton4_Click(object sender, EventArgs e)
        {
            AddSession df = new AddSession(0);
            df.Show();
            this.Hide();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            AddSession df = new AddSession(0);
            df.Show();
            this.Hide();
        }

        private void metroComboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Group.Enabled = false;
            Sub_Group.Enabled = false;
            Session.Enabled = false;
        }

        private void metroComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Lecturer.Enabled = false;
            Sub_Group.Enabled = false;
            Session.Enabled = false;
        }

        private void metroComboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Lecturer.Enabled = false;
            Group.Enabled = false;
            Session.Enabled = false;
        }

        private void metroComboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Lecturer.Enabled = false;
            Group.Enabled = false;
            Sub_Group.Enabled = false;
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            if (VerificationFunction())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                {
                    if (Lecturer.Enabled && Lecturer.SelectedIndex != -1)
                    {
                        using (SqlCommand cmd = new SqlCommand("insertLecturerNotAvailableTime", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@date", dateCombo.Value);
                            cmd.Parameters.AddWithValue("@timeFrom", Time_From.Text.Trim());
                            cmd.Parameters.AddWithValue("@timeTo", Time_To.Text.Trim());
                            cmd.Parameters.AddWithValue("@lectureId", Lecturer.SelectedValue);
                            con.Open();
                            cmd.ExecuteScalar();
                            MessageBox.Show("Not Available Time Added Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clerTextFields();
                        }
                    }
                    else if (Group.Enabled && Group.SelectedIndex != -1)
                    {
                        using (SqlCommand cmd = new SqlCommand("insertGroupNotAvailableTime", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@date", dateCombo.Value);
                            cmd.Parameters.AddWithValue("@timeFrom", Time_From.Text.Trim());
                            cmd.Parameters.AddWithValue("@timeTo", Time_To.Text.Trim());
                            cmd.Parameters.AddWithValue("@groupId", Group.SelectedValue);
                            con.Open();
                            cmd.ExecuteScalar();
                            MessageBox.Show("Not Available Time Added Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clerTextFields();
                        }
                    }
                    else if (Sub_Group.Enabled && Sub_Group.SelectedIndex != -1)
                    {
                        using (SqlCommand cmd = new SqlCommand("insertSubGrpNotAvailableTime", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@date", dateCombo.Value);
                            cmd.Parameters.AddWithValue("@timeFrom", Time_From.Text.Trim());
                            cmd.Parameters.AddWithValue("@timeTo", Time_To.Text.Trim());
                            cmd.Parameters.AddWithValue("@subGroupId", Sub_Group.SelectedValue);
                            con.Open();
                            cmd.ExecuteScalar();
                            MessageBox.Show("Not Available Time Added Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clerTextFields();
                        }
                    }
                    else if (Session.Enabled && Session.SelectedIndex != -1)
                    {
                        using (SqlCommand cmd = new SqlCommand("insertSessionNotAvailableTime", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@date", dateCombo.Value);
                            cmd.Parameters.AddWithValue("@timeFrom", Time_From.Text.Trim());
                            cmd.Parameters.AddWithValue("@timeTo", Time_To.Text.Trim());
                            cmd.Parameters.AddWithValue("@sessionId", Session.SelectedValue);
                            con.Open();
                            cmd.ExecuteScalar();
                            MessageBox.Show("Not Available Time Added Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clerTextFields();
                        }
                    }
                    else
                        MessageBox.Show("Select a Lecturer/Group/Sub-Group/Session First", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }

        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            clerTextFields();
            
        }

        private bool VerificationFunction()
        {
            if (
            CheckTextBox(Time_From) &&
            CheckTextBox(Time_To)
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

        private void clerTextFields() {
            Lecturer.Enabled = true;
            Lecturer.SelectedIndex = -1;
            Group.Enabled = true;
            Group.SelectedIndex = -1;
            Sub_Group.Enabled = true;
            Sub_Group.SelectedIndex = -1;
            Session.Enabled = true;
            Session.SelectedIndex = -1;
            Time_From.Text = "";
            Time_To.Text = "";
            dateCombo.Value= DateTime.Now;
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            if (Lecturer.Enabled && Lecturer.SelectedIndex!=-1)
            {
                ManageNotAvailableTimes df = new ManageNotAvailableTimes("lecturer",Convert.ToInt16(Lecturer.SelectedValue));
                df.Show();
            }
            else if (Group.Enabled && Group.SelectedIndex != -1)
            {
                ManageNotAvailableTimes df = new ManageNotAvailableTimes("group", Convert.ToInt16(Group.SelectedValue));
                df.Show();
                   
            }
            else if (Sub_Group.Enabled && Sub_Group.SelectedIndex != -1)
            {
                ManageNotAvailableTimes df = new ManageNotAvailableTimes("subGroup", Convert.ToInt16(Sub_Group.SelectedValue));
                df.Show();
                  
            }
            else if (Session.Enabled && Session.SelectedIndex != -1)
            {
                ManageNotAvailableTimes df = new ManageNotAvailableTimes("session", Convert.ToInt16(Session.SelectedValue));
                df.Show();
            }
            else
                MessageBox.Show("Select a Lecturer/Group/Sub-Group/Session First", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in consectiveSessionDataGrid.Rows)
            {

                if (Convert.ToBoolean(dr.Cells[0].Value) == true)
                {
                    using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("updateSessionType", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@sessionTypeId", 1);
                            cmd.Parameters.AddWithValue("@id", dr.Cells[1].Value);
                            con.Open();
                            cmd.ExecuteScalar();
                        }
                    }
                }

            }
            MessageBox.Show("Concective Sesssions Updated Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in parellelSessionDataGrid.Rows)
            {

                if (Convert.ToBoolean(dr.Cells[0].Value) == true)
                {
                    using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("updateSessionType", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@sessionTypeId", 2);
                            cmd.Parameters.AddWithValue("@id", dr.Cells[1].Value);
                            con.Open();
                            cmd.ExecuteScalar();
                        }
                    }
                }

            }
            MessageBox.Show("Parellel Sesssions Updated Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in NonOvvrLpSessionDataGrid.Rows)
            {

                if (Convert.ToBoolean(dr.Cells[0].Value) == true)
                {
                    using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("updateSessionType", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@sessionTypeId", 3);
                            cmd.Parameters.AddWithValue("@id", dr.Cells[1].Value);
                            con.Open();
                            cmd.ExecuteScalar();
                        }
                    }
                }

            }
            MessageBox.Show("Non Overlapping Sesssions Updated Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void consectiveSessionDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.consectiveSessionDataGrid.CurrentRow;
            sessionId = Convert.ToInt32(row.Cells[0].Value);
        }

        private void parellelSessionDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.parellelSessionDataGrid.CurrentRow;
            sessionId = Convert.ToInt32(row.Cells[0].Value);
        }

        private void NonOvvrLpSessionDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.NonOvvrLpSessionDataGrid.CurrentRow;
            sessionId = Convert.ToInt32(row.Cells[0].Value);
        }
    }
}
