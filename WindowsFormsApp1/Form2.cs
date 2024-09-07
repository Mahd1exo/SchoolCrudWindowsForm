using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace WindowsFormsApp1
{
    public partial class Form2 :Form
    {
        StudentRepository repository = new StudentRepository();
        public Form2()
        {
            InitializeComponent();
 

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbName.Text;
                string family = tbFamily.Text;
                int age = int.Parse(tbAge.Text);
                string subject = tbSubject.Text;
                int id = int.Parse(tbID.Text);
                Student student = new Student()
                {
                    Name = name,
                    Family = family,
                    Age = age,
                    Subject = subject,
                    Id = id,
                };
                repository.AddStudent(student);
                button1_Click(sender, e);
                MessageBox.Show("Well Done");
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR");
            }
        }
        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFamily_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbFamily.Text = "";
            tbAge.Text = "";
            tbSubject.Text = "";
            tbID.Text = "";
        }
    }
}
