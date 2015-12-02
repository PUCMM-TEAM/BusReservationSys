using System;
using System.Windows.Forms;
using BRS.Core.Models;
using BRS.Data;
using BRS.Data.SqlRepositories;

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
            Close();
        }

        private void BtnRegistrationCreate_Click(object sender, EventArgs e)
        {
            UserSqlRepository userRepo = new UserSqlRepository();

            User user = new User();

            user.Username = TbRegistrationUsername.Text;
            user.Email = TbRegistrationEmail.Text;
            user.Password = TbRegistrationPassword.Text;
            user.Role = userRepo.GetRoleInstance(Erole.Customer);
            
            Customer customer = new Customer();

            customer.FirstName = TbRegistrationFirstName.Text;
            customer.LastName = TbRegistrationLastName.Text;
            customer.Birthday = DTPRegistrationBirthday.Value;

            CreditCard creditcard = new CreditCard();

            creditcard.CardHolder = TbRegistrationCardHolder.Text;
            creditcard.CardNumber = TbRegistrationCardNumber.Text;
            creditcard.CVC = TbRegistrationCVC.Text;
            creditcard.ExpirationDate =   DTPRegistrationExpirationDate.Value.Millisecond;

            RepositoryFactory.Instance().UserRepository().Create(user);
            RepositoryFactory.Instance().CustomerRepository().Create(customer);
            RepositoryFactory.Instance().CreditCardRepository().Create(creditcard);

            MessageBox.Show("Succesfully Added!");

        }

        private void BtnRegistrationCreate_Click(object sender, EventArgs e)
        {
            //UserSqlRepository userRepo = new UserSqlRepository();


            User user = new User();
            if (TbRegistrationPassword.Text == TbRegistrationPA.Text)
            {
                user.Username = TbRegistrationUsername.Text;
                user.Email = TbRegistrationEmail.Text;
                user.Password = TbRegistrationPassword.Text;
              //user.Role = userRepo.GetRoleInstance(Erole.Customer);

                Customer customer = new Customer();

                customer.FirstName = TbRegistrationFirstName.Text;
                customer.LastName = TbRegistrationLastName.Text;
                customer.Birthday = DTPRegistrationBirthday.Text;

                CreditCard creditcard = new CreditCard();

                creditcard.CardHolder = TbRegistrationCardHolder.Text;
                creditcard.CardNumber = MtbRegistrationCardNumber.Text;
                creditcard.CVC = MtbRegistrationCVC.Text;
                creditcard.ExpirationDate = DTPRegistrationExpirationDate.Value.Millisecond;

                RepositoryFactory.Instance().UserRepository().Create(user);
                RepositoryFactory.Instance().CustomerRepository().Create(customer);
                RepositoryFactory.Instance().CreditCardRepository().Create(creditcard);

                MessageBox.Show("Succesfully Added!");
            }
            else
            {
                MessageBox.Show("Passwords don't match");
            }

        }
    }
}
