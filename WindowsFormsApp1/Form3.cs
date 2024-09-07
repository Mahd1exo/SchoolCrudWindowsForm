using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public object Massagebox { get; private set; }

        public Form3()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string search = textBox1.Text;
                textBox1.Text = "";
                StreamReader reader = new StreamReader("db.json");
                string data = reader.ReadToEnd();
                List<Student> students = JsonConvert.DeserializeObject<List<Student>>(data);
                foreach (var student in students)
                {
                    try
                    {
                        if (student.Name == search)
                        {
                            MessageBox.Show("Name : " + student.Name + "\nFamily : " + student.Family + "\nAge : " + student.Age + "\nSubject : " + student.Subject + "\nID : " + student.Id);
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("ERROR");
                    }

                }
                reader.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR");
            }
        }
    }
}
