using BRS.Core.Models;
using BRS.Core.Repositories;
using BRS.Data;
using BRS.Data.Repositories;
using BRS.Data.SqlRepositories;
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
    /// Clase representativa de el form de la lista de destino.
    /// </summary>
    public partial class DestinationListView : Form
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public DestinationListView()
        {
            InitializeComponent();
            IRepository<Destination> repo = RepositoryFactory.Instance().DestinationRepository();
            //Context context = new Context();//Manages the data.Can get or set data
            //var list = context.Destinations.ToList();//Gets info from database
            List<Destination> destinations = repo.ReadAll().ToList();
            var bindingList = new BindingList<Destination>(destinations);//Create a new list to show data from database
            var source = new BindingSource(bindingList, null);//fill with data
            DGVDestination.DataSource = source;

        }
        /// <summary>
        /// Handler del data grid view de los destinos.
        /// </summary>
        /// <param name="sender">Control que dispara el evento.</param>
        /// <param name="e">Data del evento.</param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
    }
}
