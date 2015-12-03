﻿using BRS.Core.Models;
using BRS.Core.Repositories;
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
using BRS.Data.SqlRepositories;
using BRS.Data;

namespace BRS.DesktopUI
{
    /// <summary>
    /// Clase representativa del formulario de la lista de vehiculos.
    /// </summary>
    public partial class VehicleListView : Form
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public VehicleListView()
        {
            InitializeComponent();
            IRepository<Vehicle> repo = RepositoryFactory.Instance().VehicleRepository();
            //Context context = new Context();//Manages the data.Can get or set data
            //var list = context.Destinations.ToList();//Gets info from database
            List<Vehicle> vehicle = repo.ReadAll().ToList();
            var bindingList = new BindingList<Vehicle>(vehicle);//Create a new list to show data from database
            var source = new BindingSource(bindingList, null);//fill with data
            DGVVehicle.DataSource = source;

        }
    }
}
