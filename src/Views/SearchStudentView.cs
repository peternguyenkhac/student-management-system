using src.Base;
using src.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Views
{
    public class SearchStudentView
    {
        public SearchStudentView()
        {
        }

        public void Render()
        {
            ViewHelper.Clear();
            ViewHelper.WriteLine("=== TIM KIEM SINH VIEN ===");
            int id = ViewHelper.ReadInt("Nhap Id sinh vien can tim");
            Router.Instance.Redirect(21, id);  
        }
    }
}
