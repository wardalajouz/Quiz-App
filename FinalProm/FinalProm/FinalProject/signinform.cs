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
    public partial class signinform : Form
    {
        private OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\DELL-H\Desktop\AppDB.mdb");
        public signinform()

        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.Show();




        }

        private void signinform_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtname.Text) || String.IsNullOrEmpty(txtpass.Text) || String.IsNullOrEmpty(txtcpassword.Text))
            {
                errorProvider1.SetError(button1,"Field missing");
            }
            string gender;
            if (radioButton1.Checked)
                gender = "Male";
            else
            {
                gender = "Female";
            }
            

            if (txtcpassword.Text == txtpass.Text)
            {
                try
                {

                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("insert into Users (UserName, [Password], IsAdmin,Gender) values (@a, @b, false,@c)", con);
                    cmd.Parameters.AddWithValue("@a", txtname.Text);
                    cmd.Parameters.AddWithValue("@b", txtpass.Text);
                    cmd.Parameters.AddWithValue("@c", gender);
                    cmd.ExecuteNonQuery(); //no return value
                    MessageBox.Show("Sign up Succeed");
                    con.Close();
                    Form1 Form1 = new Form1();
                    this.Hide();
                    Form1.Show();

                }
                catch (Exception e1)
                {

                    MessageBox.Show("Sign in Failed" + e1.ToString());

                }
                finally
                {
                    con.Close();
                }

            }//if
            else
            {
                MessageBox.Show("Password does not match!");
                txtcpassword.Text = txtcpassword.Text = "";
            }
}





            }
        }

    
