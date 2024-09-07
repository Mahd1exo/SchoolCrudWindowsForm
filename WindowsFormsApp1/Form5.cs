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
    public partial class Form5 : Form
    {
        public Form5()

        {
        StudentRepository repository = new StudentRepository();
        InitializeComponent();
            string saver="";
            foreach (var item in repository.GetStudents())
            {
                saver += "\nName : " + item.Name;
                saver += "\nFamily : " + item.Family;
                saver += "\nAge : "+ item.Age;
                saver += "\nSubject : " + item.Subject;
                saver += "\nID : "+item.Id;
                saver += "\n\n";

            }
            label1.Text= saver;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
