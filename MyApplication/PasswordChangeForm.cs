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
            Models.DatabaseContext oDatabaseContext = null;
            try
            {
                if (OldPasswordTextBox.Text == null)
                {
                    System.Windows.Forms.MessageBox.Show("You need to import Old Password");
                }

                Models.User oUser =
                    oDatabaseContext.Users.Where(current => string.Compare(current.Password, OldPasswordTextBox.Text, true) == 0)
                    .FirstOrDefault();

                if (oUser == null)
                {
                    System.Windows.Forms.MessageBox.Show("Old Password is wrong");
                }

                if (NewPasswordTextBox.Text == ConfirmePasswordTextBox.Text)
                {
                    oUser.Password = NewPasswordTextBox.Text;
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
