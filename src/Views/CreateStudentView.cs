using src.Models;
using src.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace src.Views
{
    public class CreateStudentView
    {
        public CreateStudentView()
        {
        }

        public void Render()
        {
            string studentCode = ViewHelper.ReadLine("Ma sinh vien");
            DateTime dateOfBirth = ViewHelper.ReadDatetime("Ngay sinh");
            string address = ViewHelper.ReadLine("Đia chi");
            int height = ViewHelper.ReadInt("Chieu cao");
            int weight = ViewHelper.ReadInt("Can nang");
            string schoolName = ViewHelper.ReadLine("Ten truong");
            int startYear = ViewHelper.ReadInt("Nam nhap hoc");
            double gPA = ViewHelper.ReadDouble("GPA");

            Student newStudent = new Student(dateOfBirth, address, height, weight, studentCode, schoolName, startYear, gPA);

            ViewHelper.WriteLine(newStudent.ToString());
        }
    }
}
