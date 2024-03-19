using src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Views
{
    public class StudentView
    {
        private readonly Student student;

        public StudentView(Student student)
        {
            this.student = student;
        }

        public void Render()
        {
            Console.WriteLine(student.ToString());
        }
    }
}
