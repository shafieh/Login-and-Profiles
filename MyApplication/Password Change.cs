using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class PasswordChange : Infrastructure.BaseForm
    {
        public PasswordChange()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void PasswordChange_Load(object sender, System.EventArgs e)
        {

        }

        private void ConfirmButton_Click(object sender, System.EventArgs e)
        {
            Models.DatabaseContext oDatabaseContext = null;
            try
            {
                Models.User oUser =
                    oDatabaseContext.Users.Where(current => string.Compare(current.Password, OldPasswordTextBox.Text, true) == 0)
                    .FirstOrDefault();

                if (oUser == null)
                {
                    System.Windows.Forms.MessageBox.Show("Old Password is required");
                }

                Infrastructure.Utility.AuthenticatedPassword = oUser;

                Hide();

                MainForm frmMain = new MainForm();

                frmMain.Show();





            }
            catch (System.Exception)
            {

                throw;
            }
            finally
            {

            }

            if (NewPasswordTextBox.Text == ConfirmePasswordTextBox.Text)
            {

            }
        }
    }
}
