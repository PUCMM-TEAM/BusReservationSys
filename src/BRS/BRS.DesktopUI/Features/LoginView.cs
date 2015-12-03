using BRS.Core.Models;
using BRS.Data;
using BRS.Logical.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRS.DesktopUI
{
    /// <summary>
    /// Clase representativa del formulario del login.
    /// </summary>
    public partial class LoginView : Form
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
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


        /// <summary>
        /// Handler del boton del salir del formulario.
        /// </summary>
        /// <param name="sender">Control que dispara el evento</param>
        /// <param name="e">Data del evento</param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handler del boton para hacer login.
        /// </summary>
        /// <param name="sender">Control que dispara el evento</param>
        /// <param name="e">Data del evento</param>
        private void BtnLogin2_Click(object sender, EventArgs e)
        {
           if(UserSessionManager.Instance.LoginUser(TbUsername.Text, TbPassword.Text))
            {

                if (UserSessionManager.Instance.UserRole == UserSessionManager.Erole.Customer)
                {

                    if (AccountManager.Instance.UserRole == AccountManager.Erole.Customer)
                    {
                        SearchView searchview = new SearchView();
                        searchview.Show();
                        this.Close();
                    }
                    else if (AccountManager.Instance.UserRole == AccountManager.Erole.Administrator)
                    {
                        AdminEditView adminview = new AdminEditView();
                        adminview.Show();
                        this.Close();
                    }
                }
                else if (UserSessionManager.Instance.UserRole == UserSessionManager.Erole.Administrator)
                {
                    MessageBox.Show("Not a user");
                }

            }
            else
            {
                MessageBox.Show("No Username or password provided");
            }
              
        }
    }
}
