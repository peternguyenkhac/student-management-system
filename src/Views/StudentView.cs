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
    public class StudentView : ViewBase
    {
        private readonly Student student;

        public StudentView(Student student)
        {
            this.student = student;
        }

        public void Render()
        {
            ViewHelper.Clear();
            ViewHelper.WriteLine("=== SINH VIEN ===");
            if(student == null)
            {
                ViewHelper.WriteLine("Khong tim thay sinh vien!");
                Dictionary<string, object> menuList = new Dictionary<string, object>()
                {
                    {"Menu", null}
                };
                KeyValuePair<string, object> label = ViewHelper.MenuList(menuList);
                RouterInstance.Redirect(label.Key, label.Value);
            }
            else
            {
                ViewHelper.WriteLine(student.ToString());
                Dictionary<string, object> menuList = new Dictionary<string, object>()
                {
                    {"Menu", null},
                    {"Cap nhat sinh vien", student.Id},
                    {"Xoa sinh vien", student.Id}
                };
                KeyValuePair<string, object> label = ViewHelper.MenuList(menuList);
                RouterInstance.Redirect(label.Key, label.Value);
            }
        }
    }
}
