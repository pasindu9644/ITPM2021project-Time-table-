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
    public partial class AddTimeForSessions : MetroFramework.Forms.MetroForm
    {
        ArrayList SessionList = new ArrayList();
        int Inc = 0;
        public AddTimeForSessions()
        {
           
            InitializeComponent();
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            Session.DataSource = getSessionList();
            Session.DisplayMember = "session";
            Session.ValueMember = "ID";
            
        }

        private DataTable getSessionList()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getTimeSessions", con))
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
                if (checkAvailability())
                {
                    foreach (object session in SessionList)
                    {

                        using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("insertTimeSession", con))
                            {

                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@timeFrom", Time_From.Text.Trim());
                                cmd.Parameters.AddWithValue("@timeTo", Time_To.Text.Trim());
                                cmd.Parameters.AddWithValue("@day", dateCombo.Value);
                                cmd.Parameters.AddWithValue("@sessionId", session);
                                con.Open();
                                cmd.ExecuteScalar();
                                Session.DataSource = getSessionList();
                                Session.DisplayMember = "session";
                                Session.ValueMember = "ID";
                            }
                        }

                    }
                    MessageBox.Show("Session For Time Added Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clerTextFields();

                }
            }
        }

        private bool checkAvailability() {
            bool result = true;
            string sessionDate = Convert.ToDateTime(dateCombo.Value).ToString("yyyy-MM-dd");
            string timeFromTextAmPm = Time_From.Text.Trim().Substring(Time_From.Text.Trim().Length - 2);
            string timeToTextAmPm = Time_To.Text.Trim().Substring(Time_To.Text.Trim().Length - 2);
            string timefromText = Time_From.Text.Trim().Remove(Time_From.Text.Trim().Length - 2);
            string timetoText = Time_To.Text.Trim().Remove(Time_To.Text.Trim().Length - 2);

            foreach (object session in SessionList)
            {
                
               
                DataTable sessionDetails = GetsessionData(Convert.ToInt16(session));
                DataTable sessionLocationDetails = GetsessionLocationData(Convert.ToInt16(session));

                DataRow dr;
                dr = sessionDetails.Rows[0];
                DataRow dr2;
                dr2 = sessionLocationDetails.Rows[0];

                DataTable assignedSessions = checkSessionDuplication();
                if (assignedSessions.Rows.Count > 0)
                {
                    foreach (DataRow Asession in assignedSessions.Rows)
                    {
                        string lecFromTime = Asession["timeFrom"].ToString();
                        string lecToTime = Asession["timeTo"].ToString();
                        string sessionFromTextAmPm = lecFromTime.Substring(lecFromTime.Length - 2);
                        string sessionToTextAmPm = lecToTime.Substring(lecToTime.Length - 2);
                        string sessionfromText = lecFromTime.Remove(lecFromTime.Length - 2);
                        string sessiontoText = lecToTime.Remove(lecToTime.Length - 2);
                        string lecDay = Convert.ToDateTime(Asession["day"]).ToString("yyyy-MM-dd");
                        if (lecDay == sessionDate)
                        {
                            if (timeFromTextAmPm == sessionFromTextAmPm && timeToTextAmPm == sessionToTextAmPm)
                            {
                                bool DateRangesOverlap = Math.Max(Convert.ToDouble(timefromText), Convert.ToDouble(sessionfromText)) < Math.Min(Convert.ToDouble(timetoText), Convert.ToDouble(sessiontoText));
                                if (DateRangesOverlap)
                                {
                                    result = false;
                                    MessageBox.Show("Session is Overlaping with another Session", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                            }
                        }
                    }
                    
                    
                }



                int lec1Id = Convert.ToInt16(dr["lecturer1Id"]);
                DataTable LecDetails = checkLecAvailability(lec1Id);
                if (LecDetails.Rows.Count > 0)
                {
                    foreach (DataRow dr3 in LecDetails.Rows)
                    {
                        string lecFromTime = dr3["timeFrom"].ToString();
                        string lecToTime = dr3["timeTo"].ToString();
                        string sessionFromTextAmPm = lecFromTime.Substring(lecFromTime.Length - 2);
                        string sessionToTextAmPm = lecToTime.Substring(lecToTime.Length - 2);
                        string sessionfromText = lecFromTime.Remove(lecFromTime.Length - 2);
                        string sessiontoText = lecToTime.Remove(lecToTime.Length - 2);
                        string lecDay = Convert.ToDateTime(dr3["day"]).ToString("yyyy-MM-dd");
                        if (lecDay == sessionDate)
                        {
                            if (timeFromTextAmPm == sessionFromTextAmPm && timeToTextAmPm == sessionToTextAmPm)
                            {
                                bool DateRangesOverlap = Math.Max(Convert.ToDouble(timefromText), Convert.ToDouble(sessionfromText)) < Math.Min(Convert.ToDouble(timetoText), Convert.ToDouble(sessiontoText));
                                if (DateRangesOverlap)
                                {
                                    result = false;
                                    MessageBox.Show("Session's Lecturer Assigned Date/Time is Overlaped with Not Available Date/Time", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                            }
                        }
                    }
                    
                }

                int lec2Id = Convert.ToInt16(dr["lecturer2Id"]);
                DataTable Lec2Details = checkLecAvailability(lec2Id);

                if (Lec2Details.Rows.Count > 0)
                {
                    foreach (DataRow dr4 in Lec2Details.Rows)
                    {
                        string lecFromTime = dr4["timeFrom"].ToString();
                        string lecToTime = dr4["timeTo"].ToString();
                        string sessionFromTextAmPm = lecFromTime.Substring(lecFromTime.Length - 2);
                        string sessionToTextAmPm = lecToTime.Substring(lecToTime.Length - 2);
                        string sessionfromText = lecFromTime.Remove(lecFromTime.Length - 2);
                        string sessiontoText = lecToTime.Remove(lecToTime.Length - 2);
                        string lecDay = Convert.ToDateTime(dr4["day"]).ToString("yyyy-MM-dd");
                        if (lecDay == sessionDate)
                        {
                            if (timeFromTextAmPm == sessionFromTextAmPm && timeToTextAmPm == sessionToTextAmPm)
                            {
                                bool DateRangesOverlap = Math.Max(Convert.ToDouble(timefromText), Convert.ToDouble(sessionfromText)) < Math.Min(Convert.ToDouble(timetoText), Convert.ToDouble(sessiontoText));
                                if (DateRangesOverlap)
                                {
                                    result = false;
                                    MessageBox.Show("Session's Lecturer Assigned Date/Time is Overlaped with Not Available Date/Time", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                            }
                        }
                    }
                }

                int sessionId = Convert.ToInt16(dr["id"]);
                DataTable SessionDetails = checkSessionAvailability(sessionId);
                if (SessionDetails.Rows.Count > 0)
                {
                    foreach (DataRow dr5 in SessionDetails.Rows)
                    {
                        string lecFromTime = dr5["timeFrom"].ToString();
                        string lecToTime = dr5["timeTo"].ToString();
                        string sessionFromTextAmPm = lecFromTime.Substring(lecFromTime.Length - 2);
                        string sessionToTextAmPm = lecToTime.Substring(lecToTime.Length - 2);
                        string sessionfromText = lecFromTime.Remove(lecFromTime.Length - 2);
                        string sessiontoText = lecToTime.Remove(lecToTime.Length - 2);
                        string lecDay = Convert.ToDateTime(dr5["day"]).ToString("yyyy-MM-dd");
                        if (lecDay == sessionDate)
                        {
                            if (timeFromTextAmPm == sessionFromTextAmPm && timeToTextAmPm == sessionToTextAmPm)
                            {
                                bool DateRangesOverlap = Math.Max(Convert.ToDouble(timefromText), Convert.ToDouble(sessionfromText)) < Math.Min(Convert.ToDouble(timetoText), Convert.ToDouble(sessiontoText));
                                if (DateRangesOverlap)
                                {
                                    result = false;
                                    MessageBox.Show("Session Assigned Date/Time is Overlaped with Not Available Date/Time", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                            }
                        }
                    }
                }

                int grpId = Convert.ToInt16(dr["groupId"]);
                DataTable grpDetails = checkGrpAvailability(grpId);
                if (grpDetails.Rows.Count > 0)
                {
                    foreach (DataRow dr6 in grpDetails.Rows)
                    {
                        string lecFromTime = dr6["timeFrom"].ToString();
                        string lecToTime = dr6["timeTo"].ToString();
                        string sessionFromTextAmPm = lecFromTime.Substring(lecFromTime.Length - 2);
                        string sessionToTextAmPm = lecToTime.Substring(lecToTime.Length - 2);
                        string sessionfromText = lecFromTime.Remove(lecFromTime.Length - 2);
                        string sessiontoText = lecToTime.Remove(lecToTime.Length - 2);
                        string lecDay = Convert.ToDateTime(dr6["day"]).ToString("yyyy-MM-dd");
                        if (lecDay == sessionDate)
                        {
                            if (timeFromTextAmPm == sessionFromTextAmPm && timeToTextAmPm == sessionToTextAmPm)
                            {
                                bool DateRangesOverlap = Math.Max(Convert.ToDouble(timefromText), Convert.ToDouble(sessionfromText)) < Math.Min(Convert.ToDouble(timetoText), Convert.ToDouble(sessiontoText));
                                if (DateRangesOverlap)
                                {
                                    result = false;
                                    MessageBox.Show("Session's Student Group Assigned Date/Time is Overlaped with Not Available Date/Time", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                            }
                        }
                    }
                }

                int locationId = Convert.ToInt16(dr2["locationId"]);
                DataTable locationDetails = checkLocationAvailability(locationId);
                if (locationDetails.Rows.Count > 0)
                {
                    foreach (DataRow dr7 in locationDetails.Rows)
                    {
                        string lecFromTime = dr7["timeFrom"].ToString();
                        string lecToTime = dr7["timeTo"].ToString();
                        string sessionFromTextAmPm = lecFromTime.Substring(lecFromTime.Length - 2);
                        string sessionToTextAmPm = lecToTime.Substring(lecToTime.Length - 2);
                        string sessionfromText = lecFromTime.Remove(lecFromTime.Length - 2);
                        string sessiontoText = lecToTime.Remove(lecToTime.Length - 2);
                        string lecDay = Convert.ToDateTime(dr7["day"]).ToString("yyyy-MM-dd");
                        if (lecDay == sessionDate)
                        {
                            if (timeFromTextAmPm == sessionFromTextAmPm && timeToTextAmPm == sessionToTextAmPm)
                            {
                                bool DateRangesOverlap = Math.Max(Convert.ToDouble(timefromText), Convert.ToDouble(sessionfromText)) < Math.Min(Convert.ToDouble(timetoText), Convert.ToDouble(sessiontoText));
                                if (DateRangesOverlap)
                                {
                                    result = false;
                                    MessageBox.Show("Session's Location Assigned Date/Time is Overlaped with Not Available Date/Time", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                            }
                        }
                    }
                }
            }
            return result;
        }

        private DataTable checkLecAvailability(int lecId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getNotAvailabeLecturerById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", lecId);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }
        private DataTable checkSessionAvailability(int sessionId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getNotAvailabeSessionById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", sessionId);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }
        private DataTable checkGrpAvailability(int lec1Id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getNotAvailableStuGrpsById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", lec1Id);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }
        private DataTable checkLocationAvailability(int lec1Id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getNotAvailableLocationById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", lec1Id);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private DataTable checkSessionDuplication()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getDuplicateLocationTimeSessions", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private DataTable GetsessionLocationData(int sessionId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getSessionLocationDetailsById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", sessionId);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            clerTextFields();
        }

        private void clerTextFields()
        {
           
            Session.SelectedIndex = -1;
            selectedSessions.Text = "";
            SessionList.Clear();
            sessionGrid.DataSource = null;
            Time_From.Text = "";
            Time_To.Text = "";
            dateCombo.Value = DateTime.Now;
            Inc = 0;
        }

        private bool VerificationFunction()
        {
            if (
            CheckCombo(Session)&&
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenu df = new MainMenu();
            df.Show();
            this.Hide();
        }

        private DataTable getComboSessionsById(int sessionId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getComboSessionsById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", sessionId);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private DataTable getParelellSessionsById(int sessionId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getParelellSessions", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", sessionId);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }


        private void sessionCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            int sessionId = Convert.ToInt16(Session.SelectedValue);
            sessionGrid.DataSource = getParelellSessionsById(sessionId);
            sessionGrid.Columns[1].Width = 335;
            SessionList.Add(sessionId);
        }

        private DataTable GetsessionData(int sessionId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getsessionDetailsById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", sessionId);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                }
            }
            return dt;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var row = sessionGrid.CurrentRow;
            if (row != null)
            {
                int SessionId = Convert.ToInt32(row.Cells[0].Value);
                DataTable sessionDetails = getComboSessionsById(SessionId);
                DataRow dr;
                dr = sessionDetails.Rows[0];
                if (Inc != 0)
                {
                    selectedSessions.Text += "," + Environment.NewLine;
                }
                selectedSessions.Text += dr["session"].ToString();
                SessionList.Add(Convert.ToInt16(dr["ID"]));
                Inc++;
            }
            else {
                MessageBox.Show("no Parellel Sesiions ! ", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
