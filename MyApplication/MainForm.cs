using System.Linq;

namespace MyApplication
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm() 
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
        }

        public void InitializeMainForm()
        {
            adminToolStripMenuItem.Visible =
                Infrastructure.Utility.AuthenticatedUser.IsAdmin;

            if (string.IsNullOrWhiteSpace(Infrastructure.Utility.AuthenticatedUser.FullName))
            {
                welcomeToolStripStatusLabel.Text =
                    $"Welcom {Infrastructure.Utility.AuthenticatedUser.Username}!";
            }
            else
            {
                welcomeToolStripStatusLabel.Text =
                    $"Welcom {Infrastructure.Utility.AuthenticatedUser.FullName}!";
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.DialogResult result =
                System.Windows.Forms.MessageBox.Show
                (text: "آیا به خروج از برنامه اطمینان دارید؟",
                caption: "سوال",
                buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
                icon: System.Windows.Forms.MessageBoxIcon.Question,
                defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
                options: System.Windows.Forms.MessageBoxOptions.RightAlign |
                    System.Windows.Forms.MessageBoxOptions.RtlReading);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private UpdateProfileForm updateProfileForm;

        private void UpdateProfileToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if ((updateProfileForm == null) || (updateProfileForm.IsDisposed))
            {
                updateProfileForm = new UpdateProfileForm
                {
                    MdiParent = this
                };

                updateProfileForm.Show();
            }
        }

        private ChangePasswordForm changePasswordForm;

        private void ChangePasswordToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if ((changePasswordForm == null) || (changePasswordForm.IsDisposed))
            {
                changePasswordForm = new ChangePasswordForm
                {
                    MdiParent = this
                };

                changePasswordForm.Show();
            }
        }

        private Admin.UsersListForm usersListForm;

        private void UsersListToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if ((usersListForm == null) || (usersListForm.IsDisposed))
            {
                usersListForm = new Admin.UsersListForm
                {
                    MdiParent = this
                };

                usersListForm.Show();
            }
        }

        private void LogoutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Infrastructure.Utility.MainForm.Hide();

            Infrastructure.Utility.LoginForm.ResetForm();

            Infrastructure.Utility.LoginForm.Show();
        
        }

        private void MainForm_FormClosed
            (object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
