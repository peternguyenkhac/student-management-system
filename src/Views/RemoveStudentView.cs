using src.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Views
{
    public class RemoveStudentView
    {
        public RemoveStudentView()
        {
        }

        public void Render()
        {
            int id = ViewHelper.ReadInt("Id sinh viên cần xoá");
        }
    }
}
