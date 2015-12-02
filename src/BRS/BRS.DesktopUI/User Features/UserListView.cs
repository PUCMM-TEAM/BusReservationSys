using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using BRS.Core.Models;
using BRS.Data.Repositories;

namespace BRS.DesktopUI
{
    public partial class UserListView : Form
    {
        public UserListView()
        {
            InitializeComponent();
            IRepository<User> repo = RepositoryFactory.Instance().UserRepository();
            List<User> users = repo.ReadAll().ToList();
            var bindingList = new BindingList<User>(users);//Create a new list to show data from database
            var source = new BindingSource(bindingList, null);//fill with data
            DGVUsers.DataSource = source;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
