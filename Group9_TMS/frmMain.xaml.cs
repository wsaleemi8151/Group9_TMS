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
using TMS_DataAccessLayer.Models;

namespace Group9_TMS
{
    /// <summary>
    /// Interaction logic for frmMain.xaml
    /// </summary>
    public partial class frmMain : Window
    {
        User user;
        
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(User _user)
        {
            InitializeComponent();

            user = _user;
        }

        private void Exit_btn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void frmMain1_Closed(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void frmMain1_Loaded(object sender, RoutedEventArgs e)
        {
            IDlable.Content = user.UserID;
            NameLable.Content = user.FirstName + " " + user.LastName;
            Role_label.Content = user.RoleID == 1 ? "Admin" : user.RoleID == 2 ? "Planner" : "Buyer";

            switch (user.RoleID)
            {
                case 1:
                    admin_grid.Visibility = Visibility.Visible;
                    Buyer_grid.Visibility = Visibility.Hidden;
                    Planner_grid.Visibility = Visibility.Hidden;
                    break;

                case 2:
                    admin_grid.Visibility = Visibility.Hidden;
                    Buyer_grid.Visibility = Visibility.Hidden;
                    Planner_grid.Visibility = Visibility.Visible;
                    break;

                case 3:
                    admin_grid.Visibility = Visibility.Hidden;
                    Buyer_grid.Visibility = Visibility.Visible;
                    Planner_grid.Visibility = Visibility.Hidden;
                    break;

                default:
                    break;
            }
        }

        private void Logout_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }

        private void LogFileBtn_Click(object sender, RoutedEventArgs e)
        {
            frmLogs logs = new frmLogs();
            logs.ShowDialog();
        }

        private void Ratebtn_Click(object sender, RoutedEventArgs e)
        {
            frmRate rates = new frmRate();
            rates.ShowDialog();
        }

        private void Carrierbtn_Click(object sender, RoutedEventArgs e)
        {
            frmCarrier carrier = new frmCarrier();
            carrier.ShowDialog();
        }

        private void Routebtn_Click(object sender, RoutedEventArgs e)
        {
            frmCarrier carrier = new frmCarrier();
            carrier.ShowDialog();
        }

        private void ViewCustomerbtn_Click(object sender, RoutedEventArgs e)
        {
            frmCustomers customer = new frmCustomers();
            customer.ShowDialog();
        }

        private void ViewOrderbtn_Click(object sender, RoutedEventArgs e)
        {
            frmOrder order = new frmOrder();
            order.ShowDialog();
        }
    }
}
