using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FinalProject
{
    public partial class AddQuestions : Form
    {
        int id;
        private OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\DELL-H\Desktop\AppDB.mdb");

        public AddQuestions( int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnaddquestion_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("INSERT INTO [Questions] (questiontitle,answer1,answer2,answer3,answer4,sectionid,correctanswer) VALUES (@a, @b, @c, @d, @e, @f, @g)", con);

                cmd.Parameters.AddWithValue("@a", txttitle.Text);
                cmd.Parameters.AddWithValue("@b", txtanswer1.Text);
                cmd.Parameters.AddWithValue("@c", txtanswer2.Text);
                cmd.Parameters.AddWithValue("@d", txtanswer3.Text);
                cmd.Parameters.AddWithValue("@e", txtanswer4.Text);
                cmd.Parameters.AddWithValue("@f",id);
                cmd.Parameters.AddWithValue("@g", int.Parse(txtcoanswer.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Question Added Successfully");
                con.Close();
                
               // QuestionAdmin QuestionAdmin = new QuestionAdmin();
                this.Hide();
                //QuestionAdmin.Show();

            }
            catch (Exception e2)
            {
                MessageBox.Show("ERROR"+e2.ToString());
            }


        }

        private void AddQuestions_Load(object sender, EventArgs e)
        {
            txtsectionid.Text = id.ToString();
        }
    }
}
