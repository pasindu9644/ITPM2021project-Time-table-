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
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Student_Management_System
{
    public partial class GenerateTimeTables : MetroFramework.Forms.MetroForm
    {

        public GenerateTimeTables()
        {
           
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getLectureList();
            lecturersCombo.SelectedIndex = -1;
            getGroupList();
            stuGrpCombo.SelectedIndex = -1;
            getLocationList();
            locationCombo.SelectedIndex = -1;

            lectureGrid.RowTemplate.Height = 30;
            lectureGrid.AutoResizeColumns();
            lectureGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            lectureGrid.DataSource = createLecTable();

            groupGrid.RowTemplate.Height = 30;
            groupGrid.AutoResizeColumns();
            groupGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            groupGrid.DataSource = createLecTable();

            locationGrid.RowTemplate.Height = 30;
            locationGrid.AutoResizeColumns();
            locationGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            locationGrid.DataSource = createLecTable();
        }

        private void getLecturerTable(int id)
        {
 
            DataTable dt=getLecturerTableData(id);
            foreach (DataRow row in dt.Rows)
            {     
                DateTime enteredDate = DateTime.Parse(row["day"].ToString());
                DayOfWeek dow = enteredDate.DayOfWeek; //enum
                string str = dow.ToString();

                string lecFromTime = row["timeFrom"].ToString();
                string lecToTime = row["timeTo"].ToString();
                string sessionFromTextAmPm = lecFromTime.Substring(lecFromTime.Length - 2);
                string sessionToTextAmPm = lecToTime.Substring(lecToTime.Length - 2);
                string sessionfromText = lecFromTime.Remove(lecFromTime.Length - 2);
                string sessiontoText = lecToTime.Remove(lecToTime.Length - 2);
                DateTime lecDay = Convert.ToDateTime(row["day"]);

                if (lecDay.Month == DateTime.Now.Month && lecDay.Year == DateTime.Now.Year && DatesAreInTheSameWeek(lecDay, DateTime.Now))
                {
                    int rowNo = getRowNo(sessionfromText);
                    int diff = 0;
                    if (sessionFromTextAmPm == sessionToTextAmPm)
                    {
                        diff = Convert.ToInt16(decimal.Parse(sessiontoText) - decimal.Parse(sessionfromText));
                    }
                    else
                    {
                        diff = Convert.ToInt16(decimal.Parse(sessiontoText) - decimal.Parse(sessionfromText)) + 12;
                    }


                    for (int x = 0; x < diff; x++)
                    {
                        var row1 = this.lectureGrid.Rows[rowNo + x];
                        row1.Cells[str].Value = row["session"].ToString();

                    }
                }
            }
        }

        private void getGroupTable(int id)
        {

            DataTable dt = getGroupTableData(id);
            foreach (DataRow row in dt.Rows)
            {
                DateTime enteredDate = DateTime.Parse(row["day"].ToString());
                DayOfWeek dow = enteredDate.DayOfWeek; //enum
                string str = dow.ToString();

                string lecFromTime = row["timeFrom"].ToString();
                string lecToTime = row["timeTo"].ToString();
                string sessionFromTextAmPm = lecFromTime.Substring(lecFromTime.Length - 2);
                string sessionToTextAmPm = lecToTime.Substring(lecToTime.Length - 2);
                string sessionfromText = lecFromTime.Remove(lecFromTime.Length - 2);
                string sessiontoText = lecToTime.Remove(lecToTime.Length - 2);
                DateTime lecDay = Convert.ToDateTime(row["day"]);

                if (lecDay.Month == DateTime.Now.Month && lecDay.Year == DateTime.Now.Year && DatesAreInTheSameWeek(lecDay, DateTime.Now))
                {
                    int rowNo = getRowNo(sessionfromText);
                    int diff = 0;
                    if (sessionFromTextAmPm == sessionToTextAmPm)
                    {
                        diff = Convert.ToInt16(decimal.Parse(sessiontoText) - decimal.Parse(sessionfromText));
                    }
                    else
                    {
                        diff = Convert.ToInt16(decimal.Parse(sessiontoText) - decimal.Parse(sessionfromText)) + 12;
                    }


                    for (int x = 0; x < diff; x++)
                    {
                        var row1 = this.groupGrid.Rows[rowNo + x];
                        row1.Cells[str].Value = row["session"].ToString();

                    }
                }
            }
        }
        private void getLocationTable(int id)
        {

            DataTable dt = getLocationTableData(id);
            foreach (DataRow row in dt.Rows)
            {
                DateTime enteredDate = DateTime.Parse(row["day"].ToString());
                DayOfWeek dow = enteredDate.DayOfWeek; //enum
                string str = dow.ToString();

                string lecFromTime = row["timeFrom"].ToString();
                string lecToTime = row["timeTo"].ToString();
                string sessionFromTextAmPm = lecFromTime.Substring(lecFromTime.Length - 2);
                string sessionToTextAmPm = lecToTime.Substring(lecToTime.Length - 2);
                string sessionfromText = lecFromTime.Remove(lecFromTime.Length - 2);
                string sessiontoText = lecToTime.Remove(lecToTime.Length - 2);
                DateTime lecDay = Convert.ToDateTime(row["day"]);

                if (lecDay.Month == DateTime.Now.Month && lecDay.Year == DateTime.Now.Year && DatesAreInTheSameWeek(lecDay, DateTime.Now))
                {
                    int rowNo = getRowNo(sessionfromText);
                    int diff = 0;
                    if (sessionFromTextAmPm == sessionToTextAmPm)
                    {
                        diff = Convert.ToInt16(decimal.Parse(sessiontoText) - decimal.Parse(sessionfromText));
                    }
                    else
                    {
                        diff = Convert.ToInt16(decimal.Parse(sessiontoText) - decimal.Parse(sessionfromText)) + 12;
                    }


                    for (int x = 0; x < diff; x++)
                    {
                        var row1 = this.locationGrid.Rows[rowNo + x];
                        row1.Cells[str].Value = row["session"].ToString();

                    }
                }
            }
        }

        private int getRowNo(string time)
        {
            switch (time)
            {
                case "8.30":
                    return 0;
                case "9.30":
                    return 1;
                case "10.30":
                    return 2;
                case "11.30":
                    return 3;
                case "12.30":
                    return 4;
                case "1.30":
                    return 5;
                case "2.30":
                    return 6;
                case "3.30":
                    return 7;
                case "4.30":
                    return 8;
                default:
                    return 9;
            }
        }
        private bool DatesAreInTheSameWeek(DateTime date1, DateTime date2)
        {
            var cal = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
            var d1 = date1.Date.AddDays(-1 * (int)cal.GetDayOfWeek(date1));
            var d2 = date2.Date.AddDays(-1 * (int)cal.GetDayOfWeek(date2));

            return d1 == d2;
        }


        private DataTable createLecTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TimeSlots");
            dt.Columns.Add("Sunday");
            dt.Columns.Add("Monday");
            dt.Columns.Add("Tuesday");
            dt.Columns.Add("WednesDay");
            dt.Columns.Add("ThursDay");
            dt.Columns.Add("Friday");
            dt.Columns.Add("Satday");

            DataRow dr = dt.NewRow();
            dr["TimeSlots"] = "8.30-9.30";
            dt.Rows.Add(dr);

            DataRow dr1 = dt.NewRow();
            dr1["TimeSlots"] = "9.30-10.30";
            dt.Rows.Add(dr1);

            DataRow dr2 = dt.NewRow();
            dr2["TimeSlots"] = "10.30-11.30";
            dt.Rows.Add(dr2);

            DataRow dr3 = dt.NewRow();
            dr3["TimeSlots"] = "11.30-12.30";
            dt.Rows.Add(dr3);

            DataRow dr4 = dt.NewRow();
            dr4["TimeSlots"] = "12.30-1.30";
            dt.Rows.Add(dr4);

            DataRow dr5 = dt.NewRow();
            dr5["TimeSlots"] = "1.30-2.30";
            dt.Rows.Add(dr5);

            DataRow dr6 = dt.NewRow();
            dr6["TimeSlots"] = "2.30-3.30";
            dt.Rows.Add(dr6);

            DataRow dr7 = dt.NewRow();
            dr7["TimeSlots"] = "3.30-4.30";
            dt.Rows.Add(dr7);

            DataRow dr8 = dt.NewRow();
            dr8["TimeSlots"] = "4.30-5.30";
            dt.Rows.Add(dr8);

            return dt;
        }

        private void getGroupList()
        {
            stuGrpCombo.DataSource = getGroupListListData();
            stuGrpCombo.DisplayMember = "GroupID";
            stuGrpCombo.ValueMember = "ID";
        }

        private void getLocationList()
        {
            locationCombo.DataSource = getLocationListData();
            locationCombo.DisplayMember = "Room";
            locationCombo.ValueMember = "ID";
        }

        private void getLectureList()
        {
            lecturersCombo.DataSource = getLectureListData();
            lecturersCombo.DisplayMember = "Name";
            lecturersCombo.ValueMember = "ID";
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
        private DataTable getLocationListData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getLocationCombo", con))
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

        private DataTable getLecturerTableData(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getLecTimeTable", con))
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
        private DataTable getGroupTableData(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getGrpTimeTable", con))
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
        private DataTable getLocationTableData(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getLocationTimeTable", con))
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

        private void clerLecGrid()
        {

            for (int i = 1; i < lectureGrid.Columns.Count; i++) {
                foreach (DataGridViewRow myRow in lectureGrid.Rows)
                {
                    myRow.Cells[i].Value = null;
                }
            }
            
        }

        private void clerGrpGrid()
        {

            for (int i = 1; i < groupGrid.Columns.Count; i++)
            {
                foreach (DataGridViewRow myRow in groupGrid.Rows)
                {
                    myRow.Cells[i].Value = null;
                }
            }

        }
        private void clerLocationGrid()
        {

            for (int i = 1; i < locationGrid.Columns.Count; i++)
            {
                foreach (DataGridViewRow myRow in locationGrid.Rows)
                {
                    myRow.Cells[i].Value = null;
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenu df = new MainMenu();
            df.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            clerLecGrid();
            int licId = Convert.ToInt32(lecturersCombo.SelectedValue);
            getLecturerTable(licId);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            clerGrpGrid();
            int grpId = Convert.ToInt32(stuGrpCombo.SelectedValue);
            getGroupTable(grpId);
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            clerLocationGrid();
            int locationId = Convert.ToInt32(locationCombo.SelectedValue);
            getLocationTable(locationId);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            btnPdf_Click(lectureGrid);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            btnPdf_Click(groupGrid);
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            btnPdf_Click(locationGrid);
        }
        private void btnPdf_Click(DataGridView dataGrid)
        {
            if (dataGrid.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGrid.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGrid.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }
                            for (int i = 0; i < dataGrid.Rows.Count - 1; i++)
                            {
                                foreach (DataGridViewCell cell in dataGrid.Rows[i].Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }


                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("File Saved Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
    }
}
