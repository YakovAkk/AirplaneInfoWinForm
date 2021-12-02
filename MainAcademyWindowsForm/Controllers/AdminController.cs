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
    class AdminController : ControllerBase
    {
        public event Action Back = delegate { };
        private readonly IMainAdminMenu _adminMainView;
        private readonly IAdminView _adminView;
        private readonly Form _scene;
        private const string user = "admin";
        private const string pass = "qwerty";



        public AdminController(Form scene) : base(scene)
        {
            _scene = scene;
            _adminView = new AdminView();
            _adminMainView = new MainAdminMenu();
        }
        public override void Start()
        {
            _adminMainView.Back += BackFromMainAdminMenu;
            _adminView.BackClicked += BackHandler;
            _adminView.OkClicked += OkHandler;
            AddChild(_adminView.GetScene);
            _adminView.GetScene.BringToFront();
        }
        public override void Stop()
        {
            _adminView.BackClicked -= BackHandler;
            _adminView.OkClicked -= OkHandler;
            _adminView.Clear();
            RemoveChild(_adminView.GetScene);
        }
        private void BackFromMainAdminMenu()
        {
            RemoveChild(_adminMainView.GetScene);
            AddChild(_adminView.GetScene);
        }
        private void OkHandler(string u, string p)
        {
            if (u == user && p == pass)
            {
                RemoveChild(_adminView.GetScene);
                AddChild(_adminMainView.GetScene);
            }
            else
            {
                _adminView.ShowPassIncorrect("Login or Password incorrect");
            }
        }
        private void BackHandler()
        {
            Back();
        }
    }
}
