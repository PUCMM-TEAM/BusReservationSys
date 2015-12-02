using BRS.Core.Models;
using BRS.Core.Repositories;
using BRS.Data;
using BRS.Data.SqlRepositories;
using BRS.Logical.Account;
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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void TbRegistrationLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRegistrationCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRegistrationCreate_Click(object sender, EventArgs e)
        {
            


            User user = new User();
            if (TbRegistrationPassword.Text == TbRegistrationPA.Text)
            {
                user.Username = TbRegistrationUsername.Text;
                user.Email = TbRegistrationEmail.Text;
                user.Password = TbRegistrationPassword.Text;
                user.Role = AccountManager.Instance.GetRole(AccountManager.Erole.Customer);
                Customer customer = new Customer();
                customer.FirstName = TbRegistrationFirstName.Text;
                customer.LastName = TbRegistrationLastName.Text;
                customer.Birthday = DTPRegistrationBirthday.Value;
                customer.CreatedDate = customer.ModifiedDate = DateTime.Now;

                CreditCard creditcard = new CreditCard();
                creditcard.CardHolder = TbRegistrationCardHolder.Text;
                creditcard.CardNumber = MtbRegistrationCardNumber.Text;
                creditcard.CVC = MtbRegistrationCVC.Text;
                creditcard.ExpirationDate = DTPRegistrationExpirationDate.Value.Millisecond;
                creditcard.CreatedDate = creditcard.ModifiedDate = DateTime.Now;
                customer.CreditCard = creditcard;
                user.Customer = customer;

                RepositoryFactory.Instance().UserRepository().Create(user);
                MessageBox.Show("Succesfully Added!");
            }
            else
            {
                MessageBox.Show("Passwords don't match");
            }

        }
    }
}
