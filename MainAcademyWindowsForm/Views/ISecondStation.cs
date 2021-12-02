using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainAcademyWindowsForm.Views
{
    interface ISecondStation
    {
        event Action ShowAllRaces;
        event Action<int> FindRceWithNum;
        event Action ShowAllRacesToday;
        event Action ShowAllRacesNearestSevenDays;
        event Action<int> ShowAllRacesLessThanXUAH;
        event Action ShowAllRacesWhichHaveFreePlaces;
        event Action BackClicked;
        Control GetScene { get; }
    }
}
