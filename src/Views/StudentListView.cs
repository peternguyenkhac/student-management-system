using src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Views
{
    public class StudentListView
    {
        private List<Student> students;

        public StudentListView(List<Student> students)
        {
            this.students = students;
        }

        public void Render()
        {
            if(students.Count == 0)
            {
                Console.WriteLine("Danh sach trong");
                return;
            }

            foreach(var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
