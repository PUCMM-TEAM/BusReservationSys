using BRS.Core.Models;
using BRS.Data;
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

namespace BRS.DesktopUI
{
    /// <summary>
    /// Clase representativa del formulario de edicion de destino.
    /// </summary>
    public partial class EditDestinationView : Form 
    {
        /// <summary>
        /// Repositorio de destino.
        /// </summary>
        DestinationRepository repo = new DestinationRepository();
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public EditDestinationView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handler de texto de destino.
        /// </summary>
        /// <param name="sender">Control que dispara el evento</param>
        /// <param name="e">Data del evento</param>
        private void TbDestinationID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnDestinationCreate_Click(object sender, EventArgs e)
        {
            Destination destination = new Destination();
            destination.Name = TbDestinationName.Text.ToString();
            destination.CreatedDate = DateTime.Now;
            destination.ModifiedDate = DateTime.Now;
            //db.Destinations.Add(destination);
            //db.SaveChanges();
            repo.Create(destination);
        }

        private void BtnDestinationList_Click(object sender, EventArgs e)
        {
            UserListView userview = new UserListView();
            userview.Show();
        }
    }
}
