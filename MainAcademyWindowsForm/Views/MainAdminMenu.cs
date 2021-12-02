using MainAcademyWindowsForm.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainAcademyWindowsForm 
{
    public partial class MainAdminMenu : UserControl, IMainAdminMenu
    {

        public MainAdminMenu()
        {
            InitializeComponent();
        }
        public Control GetScene => this;

        public event Action AddPlaneByID = delegate { };
        public event Action RemovePlaneByID = delegate { };
        public event Action Back = delegate { };



        private void addBtn_Click(object sender, EventArgs e)
        {
            AddPlaneByID();
        }
        private void removeBtn_Click(object sender, EventArgs e)
        {
            RemovePlaneByID();
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            Back();
        }
    }
}
