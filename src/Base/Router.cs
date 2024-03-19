using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Base
{
    public delegate void ControllerAction();
    public class Router
    {
        private static Router _instance;

        private readonly Dictionary<int, string> _labelTable;
        private readonly Dictionary<int, ControllerAction> _actionTable;

        public static Router Instance => _instance ?? (_instance = new Router());

        public Dictionary<int, string> LabelTable => _labelTable;

        public Dictionary<int, ControllerAction> ActionTable => _actionTable;

        private Router()
        {
            _labelTable = new Dictionary<int, string>();
            _actionTable = new Dictionary<int, ControllerAction>();
        }

        public void Register(int id, string label, ControllerAction controllerAction)
        {
            if (!_labelTable.ContainsKey(id) && !_actionTable.ContainsKey(id))
            {
                _labelTable[id] = label;
                _actionTable[id] = controllerAction;
            }
        }

        public void Redirect(int id)
        {
            _actionTable[id].Invoke();
        }
    }
}
