using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRS.ReportApp {
  public partial class UserReportForm : Form {
    public UserReportForm() {
      InitializeComponent();
    }

    private void UserReportForm_Load(object sender, EventArgs e) {
      // TODO: This line of code loads data into the '_aspnet_BRS_WebUI_20151116060626DataSet.AspNetUsers' table. You can move, or remove it, as needed.
      this.AspNetUsersTableAdapter.Fill(this._aspnet_BRS_WebUI_20151116060626DataSet.AspNetUsers);

      this.reportViewer1.RefreshReport();
    }
  }
}
