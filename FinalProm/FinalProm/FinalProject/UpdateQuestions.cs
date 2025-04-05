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
    public partial class UpdateQuestions : Form
    {
        private int id; //to make it accessible from class member
        public UpdateQuestions(int id)
        {
            this.id = id;  //id (class) =id(parameters)
            InitializeComponent();
        }


        private void UpdateQuestions_Load(object sender, EventArgs e)
        {
            // we will take the question form the query
            
        }
        public void UpdateRecord(int id, string newTitle, string newAnswer1, string newAnswer2, string newAnswer3, string newAnswer4, int newSectionID, int newCoAnswer)
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\DELL-H\Desktop\AppDB.mdb;";

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // Define the SQL UPDATE command
                    string query = "UPDATE [Questions] SET questiontitle = @newTitle, answer1 = @newAnswer1, answer2 = @newAnswer2, answer3 = @newAnswer3, answer4 = @newAnswer4, sectionid = @newSectionID, correctanswer = @newCoAnswer WHERE id = @id";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        // Add the parameters
                        cmd.Parameters.AddWithValue("@newTitle", newTitle);
                        cmd.Parameters.AddWithValue("@newAnswer1", newAnswer1);
                        cmd.Parameters.AddWithValue("@newAnswer2", newAnswer2);
                        cmd.Parameters.AddWithValue("@newAnswer3", newAnswer3);
                        cmd.Parameters.AddWithValue("@newAnswer4", newAnswer4);
                        cmd.Parameters.AddWithValue("@newSectionID", newSectionID);
                        cmd.Parameters.AddWithValue("@newCoAnswer", newCoAnswer);
                        cmd.Parameters.AddWithValue("@id", id);

                        // Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if the record was updated
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the specified ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }


        private void btnaddquestion_Click(object sender, EventArgs e)
        {
            UpdateRecord(id, txttitle.Text, txtanswer1.Text, txtanswer2.Text, txtanswer3.Text, txtanswer4.Text, int.Parse(txtsectionid.Text), int.Parse(txtcoanswer.Text));
            MessageBox.Show("Question updated successfully");
            this.Hide();

        }
    }
}
