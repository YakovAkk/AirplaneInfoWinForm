using MainAcademyWindowsForm.Controllers;
using MainAcademyWindowsForm.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainAcademyWindowsForm
{
    class MainController : ControllerBase
    {
        private readonly Form _scene;
        private readonly IWellcomeView _welcomeView;
        private readonly FirstStationController _firstStationController;
        private readonly SecondStationController _secondStationStationController;
        private readonly AdminController _adminController;

        ///////////////////
        // Main Function //
        ///////////////////

        public MainController(Form scene) : base(scene)
        {
            _scene = scene;
            _welcomeView = new WelcomeWindow();
            _adminController = new AdminController(_scene);
            _firstStationController = new FirstStationController(_scene);
            _secondStationStationController = new SecondStationController(_scene);
        }
        public override void Start()
        {
            _welcomeView.AdminClicked += AdminHandler;
            _welcomeView.FirstClicked += FirstHandler;
            _welcomeView.SecondClicked += SecondHadnler;
            _welcomeView.QuitClicked += QuitHandler;

            AddChild(_welcomeView.GetScene);
        }
        public override void Stop()
        {
            _welcomeView.AdminClicked -= AdminHandler;
            _welcomeView.FirstClicked -= FirstHandler;
            _welcomeView.SecondClicked -= SecondHadnler;
            _welcomeView.QuitClicked -= QuitHandler;

            RemoveChild(_welcomeView.GetScene);
        }


        ///////////////////
        // Wellcome View //
        ///////////////////
        ///
        private void QuitHandler()
        {
            Application.Exit();
        }

        // Admin Controller
        private void AdminHandler()
        {
            RemoveChild(_welcomeView.GetScene);
            _adminController.Back += BackFromAdmin;
            _adminController.Start();
        }
        private void BackFromAdmin()
        {
            AddChild(_welcomeView.GetScene);
            _adminController.Back -= BackFromAdmin;
            _adminController.Stop();
        }


        // First Station Controller
        private void FirstHandler()
        {
            RemoveChild(_welcomeView.GetScene);
            _firstStationController.Back += BackFromFirstStationHandler;
            _firstStationController.Start();
        }
        private void BackFromFirstStationHandler()
        {
            AddChild(_welcomeView.GetScene);
            _firstStationController.Back -= BackFromFirstStationHandler;
            _firstStationController.Stop();
        }


        // Second Station Controller
        private void SecondHadnler()
        {
            RemoveChild(_welcomeView.GetScene);
            _secondStationStationController.Back += BackFromSecondStationHandler;
            _secondStationStationController.Start();
        }
        private void BackFromSecondStationHandler()
        {
            AddChild(_welcomeView.GetScene);
            _secondStationStationController.Back -= BackFromSecondStationHandler;
            _secondStationStationController.Stop();
        }
    }
}
