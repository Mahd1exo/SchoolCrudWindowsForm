using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class JsonContext
    {
        string path="db.json";
        List<Student> students;

        public JsonContext(string path)
        {
            this.path = path;
            students = GetStudents();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            saveChanges();
        }
        public void DeleteStudent(int index)
        {
            students.RemoveAt(index);
            saveChanges();
        }

        private void saveChanges()
        {
            string data = JsonConvert.SerializeObject(students);
            StreamWriter writer = new StreamWriter(path);
            writer.Write(data);
            writer.Flush();
            writer.Close();
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            try
            {
                StreamReader reader = new StreamReader(path);
                string data = reader.ReadToEnd();
                students = JsonConvert.DeserializeObject<List<Student>>(data);


                reader.Close();
            }
            catch (System.Exception)
            {


            }

            return students;
        }

        internal void UpdateStudent(Student updatedStudent, int index)
        {
            students[index] = (updatedStudent);
            saveChanges();
        }
    }
}
