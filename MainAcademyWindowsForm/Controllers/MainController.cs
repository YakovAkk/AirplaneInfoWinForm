using MainAcademyWindowsForm.Controllers;
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
        private readonly AdminController _adminController;

        public MainController(Form scene) : base(scene)
        {
            _scene = scene;
            _welcomeView = new WelcomeWindow();
            _adminController = new AdminController(_scene);
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
        private void QuitHandler()
        {
            Application.Exit();
        }

        private void FirstHandler()
        {

        }

        private void SecondHadnler()
        {
            
        }
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

    }
}
