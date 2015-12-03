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
  /// <summary>
  /// Clase representativa del formulario de editar el usuario.
  /// </summary>
  public partial class EditUserView : Form {
        /// <summary>
        /// Representa el repositorio de usuarios.
        /// </summary>
        UserRepository repo = new UserRepository();

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public EditUserView() {
      InitializeComponent();

       
        }


        /// <summary>
        /// Handler del boton para crear un nuevo usuario.
        /// </summary>
        /// <param name="sender">Control que dispara el evento</param>
        /// <param name="e">Data del evento</param>
        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = TbUserUsername.Text.ToString();
            user.Password = TbUserPassword.Text.ToString();//Falta lo de password again para verificar si ese el password que desea usar.
            //db.Destinations.Add(destination);
            //db.SaveChanges();
            repo.Create(user);
        }


        /// <summary>
        /// Handler del bonton para salir del formulario.
        /// </summary>
        /// <param name="sender">Control que dispara el evento</param>
        /// <param name="e">Data del evento</param>
        private void BtnUserCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handler del boton para ir al formulario de la lista de usuario.
        /// </summary>
        /// <param name="sender">Control que dispara el evento</param>
        /// <param name="e">Data del evento</param>
        private void BtnUserList_Click(object sender, EventArgs e)
        {
            UserListView userview = new UserListView();
            userview.Show();
        }
    }
}
