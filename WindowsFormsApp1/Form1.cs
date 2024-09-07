using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 a=new Form2();
            a.ShowDialog();
        }

        private void search_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.ShowDialog();
        }

        private void editStudent_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.ShowDialog();
        }

        private void showStudent_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            a.ShowDialog();
        }

        private void deleteStudent_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            a.ShowDialog();
        }
    }
}
