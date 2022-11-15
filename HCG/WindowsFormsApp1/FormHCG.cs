using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1
{
    public partial class FormHCG : Form
    {
        QuestionController question = new QuestionController();
        AnswerController answer = new AnswerController();
        public FormHCG()
        {
            InitializeComponent();
            getData();
        }

        private void getData()
        {
            try
            {
                DataSet rs = question.getAll("Questions");
                DataSet rs1 = answer.getAll("Answers");
                label1.Text = rs.Tables["Questions"].Rows[0]["Name"].ToString();
                label2.Text = rs1.Tables["Answers"].Rows[0]["Name"].ToString(); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
