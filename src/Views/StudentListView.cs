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
    public class StudentListView : ViewBase
    {
        private List<Student> students;

        public StudentListView(List<Student> students)
        {
            this.students = students;
        }

        public void Render()
        {
            ViewHelper.Clear();
            ViewHelper.WriteLine("=== DANH SACH SINH VIEN ===");
            if(students.Count == 0)
            {
                ViewHelper.WriteLine("Danh sach trong");
            }
            else
            {
                foreach (var student in students)
                {
                    Console.WriteLine(student.ToString());
                }
            }

            Dictionary<string, object> menuList = new Dictionary<string, object>()
            {
                {"Menu", null},
                {"Tim kiem sinh vien", null },
                {"Them sinh vien", null },
                {"Xoa sinh vien", null }
            };
            KeyValuePair<string, object> label = ViewHelper.MenuList(menuList);
            RouterInstance.Redirect(label.Key, label.Value);
        }
    }
}
