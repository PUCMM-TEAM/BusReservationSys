using System;
using System.Windows.Forms;

namespace BRS.DesktopUI
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLogin2_Click(object sender, EventArgs e)
        {
            
            
            SearchView searchview = new SearchView();
            searchview.Show();
        }
    }
}
