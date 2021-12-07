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
    public partial class frmCarrier : Window
    {
        public frmCarrier()
        {
            InitializeComponent();
        }

        private void frmLogs1_Loaded(object sender, RoutedEventArgs e)
        {
            UserManager manager = new UserManager();
            var carriers = manager.GetCarrier();

            foreach (var carrier in carriers)
            {
                Carrier_input.Text += "Carrier Name: " + carrier.Name + "Dimensions: " + carrier.VehicleDimensions +
                    "         Created On: " + carrier.CreatedOn.ToString() + Environment.NewLine;
            }
        }
    }
}
