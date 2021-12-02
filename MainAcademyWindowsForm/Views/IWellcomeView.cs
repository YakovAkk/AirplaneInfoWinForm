using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainAcademyWindowsForm
{
    public interface IWellcomeView
    {
        event Action FirstClicked;
        event Action SecondClicked;
        event Action AdminClicked;
        event Action QuitClicked;
        Control GetScene { get; }
    }
}
