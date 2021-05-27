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
    public partial class AddTag : MetroFramework.Forms.MetroForm
    {
        public AddTag()
        {
           
            InitializeComponent();
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (VerificationFunction())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("insertTagDetails", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@tagName", Tag_Name.Text.Trim());
                        cmd.Parameters.AddWithValue("@tagCode", Tag_Code.Text.Trim());
                        cmd.Parameters.AddWithValue("@relatedTagId", Related_Tag.SelectedValue);


                        con.Open();


                        cmd.ExecuteScalar();
                        MessageBox.Show("Tag Details Added Successfully", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clerTextFields();


                    }
                }
            }
        }

        private bool VerificationFunction()
        {
            if (
            CheckTextBox(Tag_Name) &&
            CheckTextBox(Tag_Code)&&
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
            clerTextFields();
        }

        private void clerTextFields()
        {
            Tag_Name.Text = "";
            Tag_Code.Text = "";
            Related_Tag.SelectedIndex = -1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenu df = new MainMenu();
            df.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
