using MainAcademyWindowsForm.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainAcademyWindowsForm.Controllers
{
    class FirstStationController : ControllerBase
    {
        private readonly IFirstStation _firstStationView;
        public event Action Back;
        public FirstStationController(Form scene) : base(scene)
        {
            _firstStationView = new FirstStation();
        }
        public override void Start()
        {
            _firstStationView.BackClicked += BackFromFirstStationHandler;
            AddChild(_firstStationView.GetScene);
        }

        public override void Stop()
        {
            _firstStationView.BackClicked -= BackFromFirstStationHandler;
            RemoveChild(_firstStationView.GetScene);
        }

        private void BackFromFirstStationHandler()
        {
            Back();
        }
    }
}
