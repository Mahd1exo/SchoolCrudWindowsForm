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
    public partial class Form6 : Form
    {
        StudentRepository repository = new StudentRepository();
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string text = textBox2.Text;
                int index = repository.FindIndex(text);
                if (index != -1)
                {
                    repository.DeleteStudent(index);
                    MessageBox.Show("Done");
                }
                else
                {
                    MessageBox.Show("NOT Found");
                }
                textBox2.Text = "";

            }
            catch (Exception)
            {

                MessageBox.Show("ERROR");
            }

        }
    }
}
