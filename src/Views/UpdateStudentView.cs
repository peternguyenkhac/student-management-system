using src.Base;
using src.Models;
using src.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Views
{
    public class UpdateStudentView
    {
        public UpdateStudentView()
        {
        }

        public void Render(Student student)
        {
            ViewHelper.Clear();
            ViewHelper.WriteLine("=== Update sinh vien ===");
            string studentCode = ViewHelper.ReadLine("Ma sinh vien", student.StudentCode);
            string name = ViewHelper.ReadLine("Ten", student.Name);
            DateTime dateOfBirth = ViewHelper.ReadDatetime("Ngay sinh", student.DateOfBirth);
            string address = ViewHelper.ReadLine("Đia chi", student.Address);
            int height = ViewHelper.ReadInt("Chieu cao", student.Height);
            int weight = ViewHelper.ReadInt("Can nang", student.Weight);
            string schoolName = ViewHelper.ReadLine("Ten truong", student.SchoolName);
            int startYear = ViewHelper.ReadInt("Nam nhap hoc", student.StartYear);
            double gPA = ViewHelper.ReadDouble("GPA", student.GPA);

            Student updated = new Student(student.Id, name ,dateOfBirth, address, height, weight, studentCode, schoolName, startYear, gPA);
            Router.Instance.Redirect("Thuc hien cap nhat sinh vien", updated);
        }
    }
}
