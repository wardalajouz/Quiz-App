using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Marks : Form
    {
        public Marks()
        {
            InitializeComponent();
        }

        public void saveresult(string result)
        {
            listBox1.Items.Add(result);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Marks_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Marks_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel=true;// e=event , e=true thats mean it wont close 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //same as Application.Exit();
        }
    }
}
