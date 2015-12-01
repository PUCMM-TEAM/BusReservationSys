﻿using BRS.Core.Models;
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
    public partial class DestinationListView : Form
    {
        public DestinationListView()
        {
            InitializeComponent();
            IRepository<Destination> repo = new DestinationSqlRepository();
            //Context context = new Context();//Manages the data.Can get or set data
            //var list = context.Destinations.ToList();//Gets info from database
            List<Destination> destinations = repo.ReadAll().ToList();
            var bindingList = new BindingList<Destination>(destinations);//Create a new list to show data from database
            var source = new BindingSource(bindingList, null);//fill with data
            DGVDestination.DataSource = source;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
    }
}
