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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void btnsport_Click(object sender, EventArgs e)
        {
            
            Form QuestionAdmin = new QuestionAdmin(2);
            this.Hide();
            QuestionAdmin.ShowDialog();
            this.Show();
        }

        private void btnscience_Click(object sender, EventArgs e)
        {
            Form QuestionAdmin = new QuestionAdmin(3);
            this.Hide();
            QuestionAdmin.ShowDialog();
            this.Show();
        }

        private void btnentertainment_Click(object sender, EventArgs e)
        {
            Form QuestionAdmin = new QuestionAdmin(1);
            this.Hide();
            QuestionAdmin.ShowDialog();
            this.Show();
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            Form QuestionAdmin = new QuestionAdmin(4);
            this.Hide();

            QuestionAdmin.ShowDialog();
            this.Show();
        }
    }
}
