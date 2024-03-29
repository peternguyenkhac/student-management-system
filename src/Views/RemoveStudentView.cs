﻿using src.Base;
using src.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Views
{
    public class RemoveStudentView : ViewBase
    {
        public RemoveStudentView()
        {
        }

        public void Render()
        {
            ViewHelper.Clear();
            ViewHelper.WriteLine("=== XOA SINH VIEN ===");
            int id = ViewHelper.ReadInt("Id sinh vien can xoa");
            RouterInstance.Redirect("Thuc hien xoa sinh vien", id);
        }
    }
}
