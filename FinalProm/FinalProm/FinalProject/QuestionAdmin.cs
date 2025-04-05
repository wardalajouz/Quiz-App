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
    public partial class QuestionAdmin : Form
        
    {
        private int id; //declare the id (class)
        private OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\DELL-H\Desktop\AppDB.mdb");

        public QuestionAdmin(int id)
        {
            this.id = id;
            InitializeComponent();
        }

            
        private void QuestionAdmin_Load(object sender, EventArgs e)
        {
            mop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //fillgrid();
            //mop();

        }
        private void mop()
        { //same as fillgrid()
            string connetionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\DELL-H\Desktop\AppDB.mdb;";
            string sql = "SELECT * FROM [Questions] WHERE [sectionid]="+id; 
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "[Questions]");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "[Questions]"; //datamember to selecte table name
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             AddQuestions AddQuestions  = new AddQuestions(id);
            //this.Hide();
            AddQuestions.ShowDialog();
            mop();
        }
        public void DeleteRecord(int id)
        {

            try
            {
                con.Open();
                // Define the SQL DELETE command
                string query = "DELETE FROM [Questions] WHERE [id] = @id";

                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    // Add the parameter
                    cmd.Parameters.AddWithValue("@id", id);

                    // Execute the command
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if the record was deleted
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Record deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No record found with the specified ID.");
                    }
                }
            }
            catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            finally
            {
                con.Close();
            }
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this question?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)

            {
                string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                DeleteRecord(int.Parse(id));
                mop();
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //public void UpdateRecord(int id, string newTitle, string newAnswer1, string newAnswer2, string newAnswer3, string newAnswer4, int newSectionID, int newCoAnswer)
        //{
        //    string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=your_database.accdb;";
        //    using (OleDbConnection con = new OleDbConnection(connectionString))
        //    {
        //        try
        //        {
        //            con.Open();
        //            // Define the SQL UPDATE command
        //            string query = "UPDATE [Questions] SET questiontitle = @newTitle, answer1 = @newAnswer1, answer2 = @newAnswer2, answer3 = @newAnswer3, answer4 = @newAnswer4, sectionid = @newSectionID, correctanswer = @newCoAnswer WHERE id = @id";

        //            using (OleDbCommand cmd = new OleDbCommand(query, con))
        //            {
        //                // Add the parameters
        //                cmd.Parameters.AddWithValue("@newTitle", newTitle);
        //                cmd.Parameters.AddWithValue("@newAnswer1", newAnswer1);
        //                cmd.Parameters.AddWithValue("@newAnswer2", newAnswer2);
        //                cmd.Parameters.AddWithValue("@newAnswer3", newAnswer3);
        //                cmd.Parameters.AddWithValue("@newAnswer4", newAnswer4);
        //                cmd.Parameters.AddWithValue("@newSectionID", newSectionID);
        //                cmd.Parameters.AddWithValue("@newCoAnswer", newCoAnswer);
        //                cmd.Parameters.AddWithValue("@id", id);

        //                // Execute the command
        //                int rowsAffected = cmd.ExecuteNonQuery();

        //                // Check if the record was updated
        //                if (rowsAffected > 0)
        //                {
        //                    Console.WriteLine("Record updated successfully.");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("No record found with the specified ID.");
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Error: " + ex.Message);
        //        }
        //    }
        //}


        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            UpdateQuestions UpdateQuestions = new UpdateQuestions(int.Parse(id));
            UpdateQuestions.ShowDialog();
            mop();
            
        }
        
    }
}
