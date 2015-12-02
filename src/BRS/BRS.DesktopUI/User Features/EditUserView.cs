using System;
using System.Windows.Forms;
using BRS.Core.Models;
using BRS.Data.Repositories;

namespace BRS.DesktopUI {
  public partial class EditUserView : Form {
        UserRepository repo = new UserRepository();
        public EditUserView() {
      InitializeComponent();

       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = TbUserUsername.Text;
            user.Password = TbUserPassword.Text;//Falta lo de password again para verificar si ese el password que desea usar.
            //db.Destinations.Add(destination);
            //db.SaveChanges();
            repo.Create(user);
        }

        private void BtnUserCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnUserList_Click(object sender, EventArgs e)
        {
            UserListView userview = new UserListView();
            userview.Show();
        }
    }
}
