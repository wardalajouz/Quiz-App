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
    public partial class Section : Form
    {
        Marks marks = new Marks(); //
        int attempts = 0;
       public static int counter = 0; //we put it public  static to make it accessible to other form
        public static int questionnumber = 0;//same here
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\DELL-H\Desktop\AppDB.mdb");


        public Section()
        {
            InitializeComponent();
        }
        private void getquetions(int id)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("select * from [Questions] where [sectionid]=" + id,con);
                OleDbDataReader reader = cmd.ExecuteReader();// to return question or execute the query , include all the questions
                while (reader.Read())//to read line per line (object)
                {
                    string title = reader.GetString(reader.GetOrdinal("questiontitle"));
                    string answer1 = reader.GetString(reader.GetOrdinal("answer1"));
                    string answer2 = reader.GetString(reader.GetOrdinal("answer2"));
                    string answer3 = reader.GetString(reader.GetOrdinal("answer3"));
                    string answer4 = reader.GetString(reader.GetOrdinal("answer4"));
                    int correctanswer = reader.GetInt32(reader.GetOrdinal(("correctanswer")));

                    Form ror = new Questions(title, answer1, answer2, answer3, answer4, correctanswer); //new: create a new Question object
                    ror.ShowDialog(); 
              
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("ERROR"+e1.ToString());
            }
            finally{
                con.Close();
            }
        }

        private void btnsport_Click(object sender, EventArgs e)
        {
            counter = 0;
            questionnumber = 0;
            getquetions(2);
            attempts++;
            MessageBox.Show("Your mark in this quiz is " + counter + "/" + questionnumber);
            marks.saveresult("Number of Atempts" + attempts + " " + "Mark" + counter + "/" + questionnumber);
           
            marks.Show();

        }
        

        private void btnscience_Click(object sender, EventArgs e)
        {
            
            counter = 0;
            questionnumber = 0;
            getquetions(3);
            attempts++;
            MessageBox.Show("Your mark in this quiz is " + counter + "/" + questionnumber);
            marks.saveresult("Number of Atempts" + attempts + " " + "Mark" + counter + "/" + questionnumber);
 
            marks.Show();
                
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            
            counter = 0;
            questionnumber = 0;
            getquetions(4);
            attempts++;
            MessageBox.Show("Your mark in this quiz is " + counter + "/" + questionnumber);
            marks.saveresult("Number of Atempts" + attempts + " " + "Mark" + counter + "/" + questionnumber);
            marks.Show();
        }

        private void btnentertainment_Click(object sender, EventArgs e)
        {
           
            counter = 0;
            questionnumber = 0;
            getquetions(1);
            attempts++;
            MessageBox.Show("Your mark in this quiz is " + counter+"/"+questionnumber);
            marks.saveresult("Number of Atempts"+attempts +" " +"Mark"+ counter + "/" + questionnumber);
            marks.Show();


        }

        private void Section_Load(object sender, EventArgs e)
        {
            
            
        }
    }
    
}
