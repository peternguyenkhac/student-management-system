using src.Base;
using src.Models;
using src.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Views
{
    public class MenuView : ViewBase
    {
        public MenuView()
        {
        }

        public void Render()
        {
            ViewHelper.Clear();
            ViewHelper.WriteLine("=== MENU ===");
            Dictionary<string, object> menuList = new Dictionary<string, object>()
            {
                {"Danh sach sinh vien", null },
                {"Tim kiem sinh vien", null },
                {"Them sinh vien", null },
                {"Xoa sinh vien", null }
            };
            KeyValuePair<string, object> label = ViewHelper.MenuList(menuList);
            RouterInstance.Redirect(label.Key, label.Value);
        }
    }
}
