using BRS.Core.Models;
using BRS.Core.Repositories;
using BRS.Data;
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
   /// Clase representativa del formulario de introduccion.
   /// </summary>
  public partial class FormFrontView : System.Windows.Forms.Form {
    /// <summary>
    /// Constructor de la clase.
    /// </summary>
    public FormFrontView() {
      InitializeComponent();

           
            IRepository<Trip> repo = RepositoryFactory.Instance().TripRepository();
            List<Trip> trip = repo.ReadAll().ToList();
            var bindingList = new BindingList<Trip>(trip);//Create a new list to show data from database
            var source = new BindingSource(bindingList, null);//fill with data
            DGVFrontTrips.DataSource = source;
            DGVFrontTrips.Columns["Deleted"].Visible = false;
            DGVFrontTrips.Columns["CreatedDate"].Visible = false;
            DGVFrontTrips.Columns["ModifiedDate"].Visible = false;
            DGVFrontTrips.Columns["ID"].Visible = false;
        }

        /// <summary>
        /// Handler de picturebox para las imagenes.
        /// </summary>
        /// <param name="sender">Control que dispara el evento.</param>
        /// <param name="e">Data del evento</param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handler del boton de login.
        /// </summary>
        /// <param name="sender">Control que dispara el evento</param>
        /// <param name="e">Data del evento</param>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginView loginview = new LoginView();
            loginview.Show();
        }


        /// <summary>
        /// Handler del Tool item del menu strip.
        /// </summary>
        /// <param name="sender">Control que dispara el evento</param>
        /// <param name="e">Data del evento</param>
        private void userReportsToolStripMenuItem_Click(object sender, EventArgs e) {
          //ReportApp.UserReportForm form = new UserReportForm();
          //form.Show();
        }


        /// <summary>
        /// Handler del Report item del menu strip.
        /// </summary>
        /// <param name="sender">Control que dispara el evento</param>
        /// <param name="e">Data del evento</param>
        private void destinationReportsToolStripMenuItem_Click(object sender, EventArgs e) {
          //ReportApp.Form1 form = new Form1();
          //form.Show();
        }

        /// <summary>
        /// Handler del boton de registro.
        /// </summary>
        /// <param name="sender">Control que dispara el evento</param>
        /// <param name="e">Data del evento</param>
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationform = new RegistrationForm();
            registrationform.Show();
        }
    }
}
