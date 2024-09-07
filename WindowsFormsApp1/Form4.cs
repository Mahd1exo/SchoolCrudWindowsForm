using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        StudentRepository repository = new StudentRepository();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            int index = repository.FindIndex(search);
            if (index != -1)
            {
                string Name = textBox2.Text;
                string Family = textBox3.Text;
                int Age = int.Parse(textBox4.Text);
                string Subject = textBox5.Text;
                int ID = int.Parse(textBox6.Text);
                Student updatedStudent = new Student()
                {
                    Name = Name,
                    Family = Family,
                    Age = Age,
                    Subject = Subject,
                    Id = ID,

                };
                repository.UpdateStudent(updatedStudent, index);
                MessageBox.Show("Done");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            int index = repository.FindIndex(search);
            if (index != -1)
            {
                MessageBox.Show("Found");
            }
            else
            {
                MessageBox.Show("NOT Found");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
