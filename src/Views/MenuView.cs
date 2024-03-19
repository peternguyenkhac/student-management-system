using src.Base;
using src.Utils;
using System;
using System.Collections.Generic;
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
            foreach(KeyValuePair<int, string> route in RouterInstance.LabelTable)
            {
                ViewHelper.WriteLine($"{route.Key}. {route.Value}");
            }
            int cmd = ViewHelper.ReadInt(">>");
            RouterInstance.Redirect(cmd);
        }
    }
}
