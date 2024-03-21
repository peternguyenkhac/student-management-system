using src.Base;
using src.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Views
{
    public class ScorePercentageView : ViewBase
    {
        private readonly Dictionary<double, int> _scoreCount;
        private readonly int _studentCount;

        public ScorePercentageView(Dictionary<double, int> scoreCount, int studentCount)
        {
            _scoreCount = scoreCount;
            _studentCount = studentCount;
        }

        public void Render()
        {
            ViewHelper.Clear();
            ViewHelper.WriteLine("=== PHAN TRAM DIEM TRUNG BINH ===");
            foreach (var item in _scoreCount)
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
