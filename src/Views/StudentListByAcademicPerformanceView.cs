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
    public class StudentListByAcademicPerformanceView : ViewBase
    {
        private string _academicPerformance;
        private List<Student> _students;

        public StudentListByAcademicPerformanceView(string academicPerformance, List<Student> students)
        {
            _academicPerformance = academicPerformance;
            _students = students;
        }

        public void Render()
        {
            ViewHelper.Clear();
            ViewHelper.WriteLine($"=== DANH SACH SINH VIEN HOC LUC {_academicPerformance} ===");
            if (_students.Count == 0)
            {
                ViewHelper.WriteLine("Danh sach trong");
            }
            else
            {
                foreach (var student in _students)
                {
                    Console.WriteLine(student.ToString());
                }
            }
            Dictionary<string, object> menuList = new Dictionary<string, object>()
                {
                    {"Menu", null}
                };
            KeyValuePair<string, object> label = ViewHelper.MenuList(menuList);
            RouterInstance.Redirect(label.Key, label.Value);
        }
    }
}
