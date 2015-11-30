using BRS.Core.Models;
using BRS.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRS.DesktopUI {
  public partial class EditUserView : Form {
        UserRepository repo = new UserRepository();
        public EditUserView() {
      InitializeComponent();

       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = TbUserUsername.Text.ToString();
            user.Password = TbUserPassword.Text.ToString();//Falta lo de password again para verificar si ese el password que desea usar.
            //db.Destinations.Add(destination);
            //db.SaveChanges();
            repo.Create(user);
        }

        private void BtnUserCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
