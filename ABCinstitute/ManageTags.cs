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
    public partial class ManageTags : MetroFramework.Forms.MetroForm
    {
        private int tagId=0;
        public ManageTags()
        {
            InitializeComponent();
            LoadAllTagsData();
            Related_Tag.DataSource = getRelatedTagList();
            Related_Tag.DisplayMember = "RelatedTagName";
            Related_Tag.ValueMember = "ID";
        }

        private object getRelatedTagList()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("loadRelatedTagList", con))
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
                    using (SqlCommand cmd = new SqlCommand("loadTagList", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                    }               
            }
            return dt;
        }

        private void LoadAllTagsData()
        {
            tagDataGrid.DataSource = GetData();
            
        }

        private DataTable GetTagData(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("getTagDetailsById", con))
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
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("updateTags", con))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tagName", Tag_Name.Text.Trim());
                    cmd.Parameters.AddWithValue("@tagCode", Tag_Code.Text.Trim());
                    cmd.Parameters.AddWithValue("@relatedTagId", Related_Tag.SelectedValue);
                    cmd.Parameters.AddWithValue("@id", tagId);
                   
                    con.Open();


                    cmd.ExecuteScalar();
                    MessageBox.Show("Tag Updated Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clerTextFields();
                    tagDataGrid.DataSource = GetData();


                }
            }
        }

        private void clerTextFields()
        {
            Tag_Name.Text = "";
            Tag_Code.Text = "";
            Related_Tag.SelectedIndex = -1;

        }
        private bool VerificationFunction()
        {
            if (
            CheckTextBox(Tag_Name) &&
            CheckTextBox(Tag_Code) &&
            CheckCombo(Related_Tag)
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
        private void metroButton4_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this Tag ??",
                               "Confirm Delete!!",
                               MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("deleteTag", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", tagId);
                        con.Open();


                        cmd.ExecuteScalar();
                        MessageBox.Show("Tag Deleted Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clerTextFields();
                        tagDataGrid.DataSource = GetData();


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

        private void tagDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.tagDataGrid.CurrentRow;
            tagId = Convert.ToInt32(row.Cells[0].Value);
            DataTable tagDetails = GetTagData(tagId);
            DataRow dr;
            dr = tagDetails.Rows[0];

            Tag_Name.Text=dr["tagName"].ToString();
            Tag_Code.Text= dr["tagCode"].ToString();
            Related_Tag.SelectedValue= dr["relatedTagId"].ToString();


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            clerTextFields();
        }
    }
}
