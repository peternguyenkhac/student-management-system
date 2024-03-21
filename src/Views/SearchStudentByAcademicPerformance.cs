using src.Base;
using src.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Views
{
    public class SearchStudentByAcademicPerformance : ViewBase
    {
        public SearchStudentByAcademicPerformance()
        {
        }

        public void Render()
        {
            ViewHelper.Clear();
            ViewHelper.WriteLine("=== TIM SINH VIEN THEO HOC LUC===");
            string academicPerformance = ViewHelper.ReadLine("Nhap hoc luc [VerryPoor/Poor/Fair/Good/VeryGood/Excellent]");
            Router.Instance.Redirect("Thuc hien tim kiem sinh vien bang hoc luc", academicPerformance);
        }
    }
}
