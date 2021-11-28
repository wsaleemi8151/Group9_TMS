using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DataAccessLayer.Models;
using TMS_DataAccessLayer.ViewModel;

namespace TMS_DataAccessLayer.Managers
{
    public class UserManager
    {
        public User Login(string userName, string password)
        {
            // if success returns user object
            return new User();
        }

        public User ChangePassword(string userName, string password, string newPassword)
        {
            // if success returns user object
            return new User();
        }

        public User UpdateProfile(User user)
        {
            // if success returns user object
            return new User();
        }

        #region AdminUser

        public bool SetLogFileDirectory(string newPath)
        {
            // if success returns true
            return true;
        }

        public bool SetServerConnection(string connectionString)
        {
            // if success returns true
            return true;
        }

        public List<Log> ReviewLogs()
        {
            // if success returns list of logs
            return new List<Log>();
        }

        public bool UpdateFee(Fee fee)
        {
            // if success returns true
            return true;
        }

        public bool UpdateCarrier(Carrier carrier)
        {
            // if success returns true
            return true;
        }

        public bool UpdateRoute(Route route)
        {
            // if success returns true
            return true;
        }

        public bool DB_Backup()
        {
            // if success returns true
            return true;
        }


        #endregion


        #region BuyerUser

        public bool ReceiveContract(Contract contract)
        {
            // if success returns true
            return true;
        }

        public bool UpdateCustomer(Customer customer)
        {
            // if success returns true
            return true;
        }

        public bool UpdateOrder(CustomerOrder order)
        {
            // if success returns true
            return true;
        }

        public bool SetOrderCarrier(CustomerOrder order, Carrier carrier)
        {
            // if success returns true
            return true;
        }

        public Invoice GenerateOrderInvoice(CustomerOrder order)
        {
            // if success returns invoice object
            return new Invoice();
        }

        #endregion


        #region PlannerUser

        public bool ReviewOrder(CustomerOrder order)
        {
            // if success returns true
            return true;
        }

        public List<OrderTrip> CreateOrderTrips(CustomerOrder order)
        {
            // if success returns List of trips for the order
            return new List<OrderTrip>();
        }

        public bool OrderEstimation(CustomerOrder order)
        {
            // if success returns true
            return true;
        }

        public OrderStatus ReviewOrderStatus(CustomerOrder order)
        {
            // if success returns OrderStatus
            return new OrderStatus();
        }

        public bool MonitorOrderProgress(CustomerOrder order)
        {
            // if success returns true
            return true;
        }

        public OrderReportModel GenerateReport()
        {
            // if success returns true
            return new OrderReportModel();
        }

        #endregion

    }
}
