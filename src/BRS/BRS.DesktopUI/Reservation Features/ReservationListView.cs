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

namespace BRS.DesktopUI
{
    /// <summary>
    /// Clase representativa del formulario de la lista de reservaciones.
    /// </summary>
    public partial class ReservationListView : Form
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public ReservationListView()
        {
            InitializeComponent();
            IRepository<Reservation> repo = RepositoryFactory.Instance().ReservationRepository();
            List<Reservation> reservation = repo.ReadAll().ToList();
            var bindingList = new BindingList<Reservation>(reservation);
            var source = new BindingSource(bindingList, null);
            DGVReservation.DataSource = source;
        }
    }
}
