using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class StudentRepository
    {

        private JsonContext context;

        public StudentRepository()
        {

            context = new JsonContext("db.json");
        }

        public void AddStudent(Student student)
        {
            context.AddStudent(student);
        }
        public void DeleteStudent(int index)
        {
            context.DeleteStudent(index);
        }

        public List<Student> GetStudents()
        {
            return context.GetStudents();
        }

        public int FindIndex(string search)
        {
            int index = -1;
            List<Student> students = context.GetStudents();
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == search)
                {
                    index = i;
                }
            }


            return index;
        }

        public void UpdateStudent(Student updatedStudent, int index)
        {
            context.UpdateStudent(updatedStudent, index);
        }
    }
}
