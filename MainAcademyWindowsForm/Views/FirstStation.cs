using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainAcademyWindowsForm.Views
{
    public partial class FirstStation : UserControl, IFirstStation
    {
        public FirstStation()
        {
            InitializeComponent();
        }

        public Control GetScene => this;

        public event Action ShowAllRaces = delegate { };
        public event Action<int> FindRceWithNum = delegate { };
        public event Action ShowAllRacesToday = delegate { };
        public event Action ShowAllRacesNearestSevenDays = delegate { };
        public event Action<int> ShowAllRacesLessThanXUAH = delegate { };
        public event Action ShowAllRacesWhichHaveFreePlaces = delegate { };
        public event Action BackClicked = delegate { };

        private void BackBtn_Click(object sender, EventArgs e)
        {
            BackClicked();
        }
    }
}
