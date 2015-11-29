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
    public partial class UserListView : Form
    {
        public UserListView()
        {
            InitializeComponent();
            //Context context = new Context();//Manages the data.Can get or set data
            //var list = context.Users.ToList();//Gets info from database
            //var bindingList = new BindingList<User>(list);//Create a new list to show data from database
            //var source = new BindingSource(bindingList, null);//fill with data
            //DGVUsers.DataSource = source;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
