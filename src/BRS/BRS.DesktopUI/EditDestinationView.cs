using BRS.Core.Models;
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
    public partial class EditDestinationView : Form 
    {
        private Context db = new Context();

        public EditDestinationView()
        {
            InitializeComponent();
        }

        private void TbDestinationID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnDestinationCreate_Click(object sender, EventArgs e)
        {
            Destination destination = new Destination();
            destination.Name = TbDestinationName.Text.ToString();
            destination.CreatedDate = DateTime.Now;
            destination.ModifiedDate = DateTime.Now;
            db.Destinations.Add(destination);
            db.SaveChanges();

        }
    }
}
