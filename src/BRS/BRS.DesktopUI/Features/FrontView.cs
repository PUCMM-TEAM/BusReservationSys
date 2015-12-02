using System;
using System.Windows.Forms;

namespace BRS.DesktopUI {
  public partial class FormFrontView : Form {
    public FormFrontView() {
      InitializeComponent();
    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginView loginview = new LoginView();
            loginview.Show();
        }

        private void userReportsToolStripMenuItem_Click(object sender, EventArgs e) {
          //ReportApp.UserReportForm form = new UserReportForm();
          //form.Show();
        }

        private void destinationReportsToolStripMenuItem_Click(object sender, EventArgs e) {
          //ReportApp.Form1 form = new Form1();
          //form.Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationform = new RegistrationForm();
            registrationform.Show();
        }
    }
}
