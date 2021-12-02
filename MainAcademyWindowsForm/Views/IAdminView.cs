using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainAcademyWindowsForm
{
    public interface IAdminView
    {
        event Action<string, string> OkClicked;
        event Action BackClicked;
        void ShowPassIncorrect(string errorText);
        Control GetScene { get; }
        void Clear();
    }
}
