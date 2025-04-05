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
    public partial class Form1 : Form
    {
        private OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\DELL-H\Desktop\AppDB.mdb");
        bool IsAdmin = false;  
           
            public Form1()

        {
            InitializeComponent();

        }
            public bool CheckRecordExists (string username, string password, bool isAdmin)
            {
                string connectionString = (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\DELL-H\Desktop\AppDB.mdb");
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @UserName AND [Password] = @Password AND IsAdmin = @IsAdmin";

                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    try
                    {
                        con.Open();//without close , because the keyword(using) will handle it
                        using (OleDbCommand cmd = new OleDbCommand(query, con))
                        {
                            // Add the parameters
                            cmd.Parameters.AddWithValue("@UserName", username);
                            cmd.Parameters.AddWithValue("@Password", password);
                            cmd.Parameters.AddWithValue("@IsAdmin", isAdmin);

                            // Execute the query and get the result
                            int count = (int)cmd.ExecuteScalar();//executesclalr return one value

                            // Return true if the count is greater than 0, meaning a matching record exists
                            return count > 0;
                        }
                    }
                    catch (Exception ex)
                    { 
                        return false; //return false because the method must return bool in all scenario
                    }
                }
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtname.Text) || String.IsNullOrEmpty(txtpassword.Text))
            {
                errorProvider1.SetError(btnlogin,"Missing field");
                
            }
            if (CheckRecordExists(txtname.Text, txtpassword.Text, true))
            {
                Form AdminForm = new AdminForm();
                AdminForm.ShowDialog();
                this.Hide();
                return;

            }

            if (CheckRecordExists(txtname.Text, txtpassword.Text, false))
            {
                Form Section = new Section();
                Section.ShowDialog();
                this.Hide();
                return;
            }
            else
            {
                MessageBox.Show("Invalid login");
            }


            //try
            //{
            //    AppDBDataSetTableAdapters.UsersTableAdapter user = new AppDBDataSetTableAdapters.UsersTableAdapter();
            //    AppDBDataSet.UsersDataTable dt = user.GetDataBy(txtname.Text, txtpassword.Text, true);
            //    if (dt.Rows.Count == 1)
            //    {
            //        IsAdmin = true;
            //        Form AdminForm = new AdminForm();
            //        AdminForm.ShowDialog();
            //        this.Hide();
            //        return;// to exit the function

            //    }
               

            //    dt = user.GetDataBy(txtname.Text, txtpassword.Text, false);
            //    if (dt.Rows.Count == 1)
            //    {
            //        IsAdmin = false;
            //        Form Section = new Section();
            //        Section.ShowDialog();
            //        this.Hide();
            //        return;// to exit the function
            //    }
            //    else 
            //    {
            //        MessageBox.Show("Invalid login");

            //}

            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show("An error occurred: " + ex.Message);
            //}
            //txtname.Text = txtpassword.Text = "";

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            signinform signinform = new signinform();
            this.Hide();
            signinform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MessageBox.Show("Success");
            }
            catch (Exception e1)
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
