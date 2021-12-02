using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainAcademyWindowsForm.Controllers
{
    public abstract class ControllerBase
    {
        private readonly Form _rootScene;
        public ControllerBase(Form rootScene)
        {
            _rootScene = rootScene;
        }


        public abstract void Start();
        public abstract void Stop();
        protected void AddChild(Control child)
        {
            _rootScene.Controls.Add(child);
            child.BringToFront();
        }
        protected void RemoveChild(Control child)
        {
            if (_rootScene.Controls.Contains(child))
            {
                _rootScene.Controls.Remove(child);
            }
            else
            {
#if DEBUG
                throw new Exception("DOUBLE DELETE OF OBJECT!!!");
#endif
            }
        }
    }
}
