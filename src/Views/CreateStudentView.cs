using src.Base;
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
            ViewHelper.Clear();
            ViewHelper.WriteLine("=== THEM SINH VIEN ===");
            string studentCode = ViewHelper.ReadLine("Ma sinh vien", StudentValidation.IsValidStudentCode);
            string name = ViewHelper.ReadLine("Ten", HumanValidation.IsValidName);
            DateTime dateOfBirth = ViewHelper.ReadDatetime("Ngay sinh");
            string address = ViewHelper.ReadLine("Đia chi");
            int height = ViewHelper.ReadInt("Chieu cao");
            int weight = ViewHelper.ReadInt("Can nang");
            string schoolName = ViewHelper.ReadLine("Ten truong");
            int startYear = ViewHelper.ReadInt("Nam nhap hoc");
            double gPA = ViewHelper.ReadDouble("GPA");

            Student newStudent = new Student(name, dateOfBirth, address, height, weight, studentCode, schoolName, startYear, gPA);
            Router.Instance.Redirect("Thuc hien them sinh vien", newStudent);
        }
    }
}
