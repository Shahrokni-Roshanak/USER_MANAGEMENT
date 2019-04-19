using System.Linq;

namespace MyApplication
{
    public partial class ChangePasswordForm : Infrastructure.BaseForm
    {
        public ChangePasswordForm() : base()
        {
            InitializeComponent();
        }

        private void ChangePasswordForm_Load(object sender, System.EventArgs e)
        {
        }

        private void ChangePasswordButton_Click(object sender, System.EventArgs e)
        {
            string errorMessages = string.Empty;

            if (string.IsNullOrWhiteSpace(oldPasswordTextBox.Text))
            {
                errorMessages =
                    "Old password is required!";
            }

            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext = new Models.DatabaseContext();

                Models.User currentUser = databaseContext.Users
                    .Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id)
                    .FirstOrDefault();
                if (currentUser == null)
                {
                    System.Windows.Forms.Application.Exit();
                }

                if (string.Compare(currentUser.Password, oldPasswordTextBox.Text, ignoreCase: false) !=0)
                {
                    System.Windows.Forms.MessageBox.Show("The old password is not correct!");

                    oldPasswordTextBox.Focus();

                    return;
                }

                currentUser.Password = newPasswordTextBox.Text;

                databaseContext.SaveChanges();

                System.Windows.Forms.MessageBox.Show("Your password changed successfully.");

                Close();
            }
            catch(System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
            }
        }
    }
}
