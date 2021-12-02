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
    public partial class SecondStation : UserControl , ISecondStation
    {
        public SecondStation()
        {
            InitializeComponent();
        }

        public Control GetScene => this;

        public event Action ShowAllRaces;
        public event Action<int> FindRceWithNum;
        public event Action ShowAllRacesToday;
        public event Action ShowAllRacesNearestSevenDays;
        public event Action<int> ShowAllRacesLessThanXUAH;
        public event Action ShowAllRacesWhichHaveFreePlaces;
        public event Action BackClicked;

        private void backBtn_Click(object sender, EventArgs e)
        {
            BackClicked();
        }
    }
}
