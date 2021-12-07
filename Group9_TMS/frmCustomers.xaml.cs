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
    /// Interaction logic for frmLogs.xaml
    /// </summary>
    public partial class frmCustomers : Window
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmLogs1_Loaded(object sender, RoutedEventArgs e)
        {
            UserManager manager = new UserManager();
            var customers = manager.GetCustomers();

            foreach (var customer in customers)
            {
                Logs_input.Text += "Customer Name: " + customer.Name + "     Company Name: " + customer.CompanyName + "            Created On: " + customer.CreatedOn.ToString() + Environment.NewLine;
            }
        }
    }
}
