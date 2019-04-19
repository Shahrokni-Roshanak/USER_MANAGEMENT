using System.Linq;

namespace MyApplication.Admin
{
    public partial class UpdateUserForm : Infrastructure.BaseForm
    {
        public UpdateUserForm()
        {
            InitializeComponent();
        }

        public Models.User SelectedUser { get; set; }

        private void UpdateUserForm_Load(object sender, System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext =
                    new Models.DatabaseContext();
                Models.User foundedUser =
                    databaseContext.Users
                    .Where(current => current.Id == SelectedUser.Id)
                    .FirstOrDefault();
                if (foundedUser == null)
                {
                    System.Windows.Forms.MessageBox.Show("There is no such a user anymore!");
                    Close();
                }

                isAdminCheckBox.Checked = foundedUser.IsAdmin;
                isActiveCheckBox.Checked = foundedUser.IsActive;

                fullNameTextBox.Text = foundedUser.FullName;
                descriptionTextBox.Text = foundedUser.Description;
            }
            catch(System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

                Close();
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

        private void SaveAndClosebutton_Click(object sender, System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext =
                    new Models.DatabaseContext();
                Models.User foundedUser =
                    databaseContext.Users
                    .Where(current => current.Id == SelectedUser.Id)
                    .FirstOrDefault();

                if (foundedUser == null)
                {
                    System.Windows.Forms.MessageBox.Show("There is no such a user anymore!");

                    Close();
                }

                foundedUser.IsAdmin = isAdminCheckBox.Checked;
                foundedUser.IsActive = isActiveCheckBox.Checked;

                foundedUser.FullName = fullNameTextBox.Text;
                foundedUser.Description = descriptionTextBox.Text;

                databaseContext.SaveChanges();

                Close();
            }
            catch(System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

                Close();
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
