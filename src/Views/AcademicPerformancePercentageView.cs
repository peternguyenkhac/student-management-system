using src.Base;
using src.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Views
{
    public class AcademicPerformancePercentageView : ViewBase
    {
        private readonly Dictionary<AcademicPerformance, int> _academicPerformanceCount;
        private readonly int _studentCount;

        public AcademicPerformancePercentageView(Dictionary<AcademicPerformance, int> academicPerformanceCount, int studentCount)
        {
            _academicPerformanceCount = academicPerformanceCount;
            _studentCount = studentCount;
        }

        public void Render()
        {
            ViewHelper.Clear();
            ViewHelper.WriteLine("=== PHAN TRAM HOC LUC ===");
            foreach(var item in _academicPerformanceCount)
            {
                ViewHelper.WriteLine($"{item.Key}: {(double)item.Value / _studentCount * 100}%");
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
