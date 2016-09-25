using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class PasswordChangeForm : Infrastructure.BaseForm
    {
        public PasswordChangeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }
        private void PasswordChangeForm_Load(object sender, System.EventArgs e)
        {

        }

        private void ConfirmButton_Click(object sender, System.EventArgs e)
        {
            ///در ابتدا حالتی را می نویسیم که کاربر پسورد قدیمی را وارد نکند

            //*****************

            if (string.IsNullOrWhiteSpace(OldPasswordTextBox.Text))
            {

                System.Windows.Forms.MessageBox.Show("You need to import Old Password");

                return;
            }

            //******************

            Models.DatabaseContext oDatabaseContext = null;

            try
            {

                oDatabaseContext =
                               new Models.DatabaseContext();

                Models.User oUser =
                     oDatabaseContext.Users.Where(current => string.Compare(current.Password, OldPasswordTextBox.Text, true) == 0)
                     .FirstOrDefault();
                ///حالتی را بررسی می کنیم که پسورد غلط وارد شود

                if (string.Compare(oUser.Password, OldPasswordTextBox.Text, ignoreCase: false) != 0)
                {
                    System.Windows.Forms.MessageBox.Show("Old Password is wrong");
                }


                if (NewPasswordTextBox.Text == ConfirmePasswordTextBox.Text)
                {
                    //var varUsers =
                    //      oDatabaseContext.Users
                    //      .Where(current => current.Password,NewPasswordTextBox.Text)
                    //      .ToList();

                    oUser.Password = NewPasswordTextBox.Text;


                                       oDatabaseContext.SaveChanges();

                    System.Windows.Forms.MessageBox.Show("Your Password Change is done Successfully");
                }


                else
                {
                    System.Windows.Forms.MessageBox.Show("Check Your Confirm Password");
                }


                Infrastructure.Utility.AuthenticatedPassword = oUser;


                Hide();

                MainForm frmMain = new MainForm();

                frmMain.Show();


            }
            catch (System.Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (oDatabaseContext != null)
                {
                    oDatabaseContext.Dispose();
                    oDatabaseContext = null;
                }
            }

        }


    }
}
