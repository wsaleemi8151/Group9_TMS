using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DataAccessLayer.Models;
using TMS_DataAccessLayer.MySQL_Connector;
using TMS_DataAccessLayer.ViewModel;

namespace TMS_DataAccessLayer.Managers
{
    public class UserManager
    {
        DataManager dataManager = new DataManager();
        public User Login(string userName, string password)
        {
            User user = new User();
            user.UserName = userName;
            user.Password = password;

            return dataManager.SelectOne(user, "User", " WHERE UserName=@UserName and Password=@Password");
        }

        public User ChangePassword(string userName, string password, string newPassword)
        {
            User user = new User();
            user.UserName = userName;
            user.Password = password;

            user = dataManager.SelectOne(user, "User", " WHERE UserName=@UserName and Password=@Password");
            user.Password = newPassword;
            return dataManager.UpdateEntity(user, "User", true);
        }

        public User UpdateProfile(User user)
        {
            return dataManager.UpdateEntity(user, "User", true);
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
            return dataManager.SelectMany(new Log(), "Log");
        }

        public List<Fee> GetFees()
        {
            return dataManager.SelectMany(new Fee(), "Fee");
        }

        public bool UpdateFee(Fee fee)
        {
            return dataManager.UpdateEntity(fee, "Fee", true) != null;
        }

        public bool UpdateCarrier(Carrier carrier)
        {
            return dataManager.UpdateEntity(carrier, "Carrier", true) != null;
        }

        public bool UpdateRoute(Route route)
        {
            return dataManager.UpdateEntity(route, "Route", true) != null;
        }

        public List<Route> GetRoutes()
        {
            return dataManager.SelectMany(new Route(), "Route");
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
            return dataManager.UpdateEntity(contract, "Contract", true) != null;
        }

        public bool UpdateCustomer(Customer customer)
        {
            return dataManager.UpdateEntity(customer, "Customer", true) != null;
        }

        public List<Customer> GetCustomers()
        {
            return dataManager.SelectMany(new Customer(), "Customer");
        }

        public bool UpdateOrder(CustomerOrder order)
        {
            return dataManager.UpdateEntity(order, "CustomerOrder", true) != null;
        }

        public bool SetOrderCarrier(CustomerOrder order, Carrier carrier)
        {
            order.CarrierID = carrier.CarrierID;
            return dataManager.UpdateEntity(order, "CustomerOrder", true) != null;
        }

        public List<Carrier> GetCarrier()
        {
            return dataManager.SelectMany(new Carrier(), "Carrier");
        }

        public Invoice GenerateOrderInvoice(CustomerOrder order)
        {
            // if success returns invoice object
            return new Invoice();
        }

        #endregion


        #region PlannerUser

        public List<CustomerOrder> GetOrders()
        {
            return dataManager.SelectMany(new CustomerOrder(), "CustomerOrder");
        }

        public bool ReviewOrder(CustomerOrder order)
        {
            return dataManager.UpdateEntity(order, "CustomerOrder", true) != null;
        }

        public List<OrderTrip> CreateOrderTrips(CustomerOrder order)
        {
            //return dataManager.UpdateEntity(order, "CustomerOrder", true) != null;
            return new List<OrderTrip>();
        }

        public bool OrderEstimation(CustomerOrder order)
        {
            return dataManager.UpdateEntity(order, "CustomerOrder", true) != null;
        }

        public OrderStatus ReviewOrderStatus(CustomerOrder order)
        {
            //return dataManager.UpdateEntity(order, "CustomerOrder", true) != null;
            return new OrderStatus();
        }

        public bool MonitorOrderProgress(CustomerOrder order)
        {
            return dataManager.UpdateEntity(order, "CustomerOrder", true) != null;
        }

        public OrderReportModel GenerateReport()
        {
            // if success returns true
            return new OrderReportModel();
        }

        #endregion

    }
}
