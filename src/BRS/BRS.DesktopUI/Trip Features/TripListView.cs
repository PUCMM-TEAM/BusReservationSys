﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using BRS.Core.Models;
using BRS.Data.Repositories;

namespace BRS.DesktopUI
{
    public partial class TripListView : Form
    {
        public TripListView()
        {
            InitializeComponent();
            TripRepository repo = new TripRepository();
            //Context context = new Context();//Manages the data.Can get or set data
            //var list = context.Destinations.ToList();//Gets info from database
            List<Trip> trip = repo.ReadAll().ToList();
            var bindingList = new BindingList<Trip>(trip);//Create a new list to show data from database
            var source = new BindingSource(bindingList, null);//fill with data
            DGVTrip.DataSource = source;
        }
    }
}
