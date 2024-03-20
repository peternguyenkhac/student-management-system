using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Base
{
    public delegate void ControllerAction(object parameter = null);
    public class Router
    {
        private static Router _instance;

        private readonly Dictionary<string, int> _labelTable;
        private readonly Dictionary<int, ControllerAction> _actionTable;

        public static Router Instance => _instance ?? (_instance = new Router());

        public Dictionary<string, int> LabelTable => _labelTable;

        public Dictionary<int, ControllerAction> ActionTable => _actionTable;

        private Router()
        {
            _labelTable = new Dictionary<string, int>();
            _actionTable = new Dictionary<int, ControllerAction>();
        }

        public void Register(int id, string label, ControllerAction controllerAction)
        {
            if (!_labelTable.ContainsKey(label) && !_actionTable.ContainsKey(id))
            {
                _labelTable[label] = id;
                _actionTable[id] = controllerAction;
            }
        }

        public void Redirect(int id, object parameter = null)
        {
            _actionTable[id].Invoke(parameter);
        }

        public void Redirect(string label, object parameter = null)
        {
            _actionTable[_labelTable[label]].Invoke(parameter);
        }
    }
}
