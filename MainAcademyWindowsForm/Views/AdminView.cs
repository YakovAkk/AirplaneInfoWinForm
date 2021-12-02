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
    public partial class AdminView : UserControl , IAdminView
    {
        public AdminView()
        {
            InitializeComponent();
        }

        public Control GetScene => this;

        public event Action<string, string> OkClicked = delegate { };
        public event Action BackClicked = delegate { };

        public void ShowPassIncorrect(string errorText)
        {
            IncorrectPassLabel.Text = errorText;
        }
        private void OkBtn_Click(object sender, EventArgs e)
        {
            OkClicked(UserNametextBox.Text, PasswordtextBox.Text);
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            BackClicked();
        }
        public void Clear()
        {
            PasswordtextBox.Text = "";
            UserNametextBox.Text = "";
            IncorrectPassLabel.Text = "";
        }
    }
}
