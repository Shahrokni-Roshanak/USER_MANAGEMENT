using System.Linq;

namespace MyApplication
{
    public partial class RegisterForm : Infrastructure.BaseForm
    {
        public RegisterForm() : base()
        {
            InitializeComponent();
        }

       private void RegisterForm_Load(object sender, System.EventArgs e)
        {
        }

        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                Models.User user =
                     databaseContext.Users
                     .Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
                     .FirstOrDefault();

                if (user != null)
                {
                    System.Windows.Forms.MessageBox.Show
                        ("This username is already exist! please choose another one ...");

                    ResetForm();
                    usernameTextBox.Focus();

                    return;
                }

                user = new Models.User
                {
                    FullName = fullNameTextBox.Text,
                    Password = passwordTextBox.Text,
                    Username = usernameTextBox.Text,

                    IsActive = true
                };

                databaseContext.Users.Add(user);

                databaseContext.SaveChanges();

                System.Windows.Forms.MessageBox.Show("Registeration Done!");

                ResetForm();
            }
            catch(System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
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

        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Reset");
            ResetForm();
        }

        public void ResetForm()
        {
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            fullNameTextBox.Text = string.Empty;

            usernameTextBox.Focus();
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            Hide();

            Infrastructure.Utility.LoginForm.Show();
        }

        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
