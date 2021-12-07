using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TMS_DataAccessLayer.Managers;

namespace Group9_TMS
{
    /// <summary>
    /// Interaction logic for frmLogin.xaml
    /// </summary>
    public partial class frmLogin : Window
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {
            UserManager userManager = new UserManager();
            var user = userManager.Login(UserIDInput.Text, PasswordInput.Password);
            if (user != null && user.FirstName !=  null)
            {
                frmMain mainForm = new frmMain(user);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                LogError.Content = "Username or password invalid.";
            }
        }

        private void frmLogin1_Closed(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
