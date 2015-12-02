using System;
using System.Windows.Forms;
using BRS.Core.Models;
using BRS.Data.Repositories;

namespace BRS.DesktopUI
{
    public partial class EditDestinationView : Form 
    {
        //private Context db = new Context();
        DestinationRepository repo = new DestinationRepository();
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
            destination.Name = TbDestinationName.Text;
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
