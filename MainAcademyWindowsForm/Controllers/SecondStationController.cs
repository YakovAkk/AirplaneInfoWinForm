using MainAcademyWindowsForm.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainAcademyWindowsForm.Controllers
{
    class SecondStationController : ControllerBase
    {
        private readonly ISecondStation _secondStationView;
        public event Action Back;
        public SecondStationController(Form scene) : base(scene)
        {
            _secondStationView = new SecondStation();

        }
        public override void Start()
        {
            _secondStationView.BackClicked += BackFromFirstStationHandler;
            AddChild(_secondStationView.GetScene);
        }
        public override void Stop()
        {
            _secondStationView.BackClicked -= BackFromFirstStationHandler;
            RemoveChild(_secondStationView.GetScene);
        }

        private void BackFromFirstStationHandler()
        {
            Back();
        }
    }
}
