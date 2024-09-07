using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class StudentFormatSerializer
    {
        public static List<string> Serial(List<Student> model)
        {
            List<string> res = new List<string>();
            foreach (var item in model)
            {
                res.Add($"{item.Name},{item.Family},{item.Age},{item.Subject},{item.Id}");

            }
            return res;
        }
        public static List<Student> Deserial (List<string> model)
        {
            List<Student> res = new List<Student>();
            foreach (var item in model)
            {
                Student std = new Student()
                {
                    Name = item.Split(',')[0],
                    Family = item.Split(',')[1],
                    Age = int.Parse(item.Split(',')[2]),
                    Subject = item.Split(',')[3],
                    Id = int.Parse(item.Split(',')[4]),
                };
                res.Add(std);
            }
            return res;
        }
    }

}
