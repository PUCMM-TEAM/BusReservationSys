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
    public partial class ReservationListView : Form
    {
        public ReservationListView()
        {
            InitializeComponent();
            IRepository<Reservation> repo = RepositoryFactory.Instance().ReservationRepository();
            List<Reservation> reservation = repo.ReadAll().ToList();
            var bindingList = new BindingList<Reservation>(reservation);//Create a new list to show data from database
            var source = new BindingSource(bindingList, null);//fill with data
            DGVReservation.DataSource = source;
        }
    }
}
