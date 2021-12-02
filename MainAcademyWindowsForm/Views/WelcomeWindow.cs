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
    public partial class WelcomeWindow : UserControl , IWellcomeView
    {
        public WelcomeWindow()
        {
            InitializeComponent();
        }

        public Control GetScene => this;

        public event Action FirstClicked = delegate { };
        public event Action SecondClicked = delegate { };
        public event Action AdminClicked = delegate { };
        public event Action QuitClicked = delegate { };

        private void firstStationBtn_Click(object sender, EventArgs e)
        {
            FirstClicked();
        }

        private void secondStationBtn_Click(object sender, EventArgs e)
        {
            SecondClicked();
        }

        private void AdmenBtn_Click(object sender, EventArgs e)
        {
            AdminClicked();
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            QuitClicked();
        }
    }
}
