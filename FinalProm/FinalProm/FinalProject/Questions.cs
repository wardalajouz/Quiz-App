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
    public partial class Questions : Form
    {
       
        string correctanswer;
        
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\DELL-H\Desktop\AppDB.mdb");
        public Questions(string questiontitle, string answer1, string answer2 ,string answer3,string answer4,int correctanswer)
           
        {
            
            InitializeComponent();
            this.correctanswer = correctanswer.ToString();
            fillquestion(questiontitle, answer1, answer2, answer3, answer4, correctanswer);
           
            

            
        }
        public void fillquestion(string questiontitle, string answer1, string answer2 ,string answer3,string answer4,int correctanswer)
        {
            txttitle.Text = questiontitle;
            button1.Text = answer1;
            button2.Text = answer2;
            button3.Text = answer3;
            button4.Text = answer4;
            
         
            


        }
        private void disabledbutton()
        {
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = false;
            button5.Show();
           
        }
        private void checkanswer(object sender, EventArgs e)//sender(object)==button , we need to cast it to button
        {
            
            var button =(Button) sender;//casted succesfully
            if (button.Tag.ToString() == correctanswer)
            {
                button.BackColor = Color.Green;
                
                Section.counter++;
            }
            else
            {    
                button.BackColor = Color.Red;
            }
            Section.questionnumber++;
            disabledbutton();
        }
       
        

        private void Questions_Load(object sender, EventArgs e)
        {
            button5.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkanswer(sender,e);// sender and e , because we call the function 
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkanswer(sender, e);// sender and e , because we call the function 
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkanswer(sender, e);// sender and e , because we call the function 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkanswer(sender, e);// sender and e , because we call the function 
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Close();
        }
         
    }
}
