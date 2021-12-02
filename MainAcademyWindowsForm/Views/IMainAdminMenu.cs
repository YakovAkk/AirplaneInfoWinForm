using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainAcademyWindowsForm.Views
{
    public interface IMainAdminMenu
    {
        event Action AddPlaneByID;
        event Action RemovePlaneByID;
        event Action Back;
        Control GetScene { get; }

    }
}
