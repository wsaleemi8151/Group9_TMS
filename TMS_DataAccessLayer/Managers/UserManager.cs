/*
 * Filename:    UserManager.cs
 * Project:     TMS_DataAccessLayer
 * By:          Amritpal Singh, Gursharan Singh, Mustafa, Waqar Ali Saleemi
 * Date:         November 28, 2021
 * Description: This file creates the class and methods manages the user
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DataAccessLayer.Models;
using TMS_DataAccessLayer.ViewModel;

namespace TMS_DataAccessLayer.Managers
{
    /// 
    /// \class UserManager
    ///
    /// \brief This class manages the user various user activity like login, password changing etc for the application
    ///
    /// \author Amritpal Singh <i>TMS-Group 9 Member</i>
    ///
    public class UserManager
    {
        /**
        * \brief To instantiate a new Login object - given a set of attribute values
        * \details <b>Details</b>
        *
        * \param userName - <b>string</b> - user name of the user for the login credentials
        * \param password - <b>string</b> - password of the user for the login credentials
        * 
        * // return if success returns user object
        */
        public User Login(string userName, string password)
        {
            return new User();
        }




        /**
        * \brief reset the password for the user  - given a set of attribute values
        * \details <b>Details</b>
        *
        * \param userName - <b>string</b> - user name of the user for the login credentials
        * \param password - <b>string</b> - password of the user for the login credentials
        * \param newPassword - <b>string</b> - new password of the user that user want to make for the login credentials
        * 
        * \return if success returns user object
        *
        */
        public User ChangePassword(string userName, string password, string newPassword)
        {
            return new User();
        }



        /**
        * \brief update the profile of the user  - given a set of attribute values
        * \details <b>Details</b>
        *
        * \param user - <b>User</b> - the profile of the user that will be updated
        * 
        * \return if success returns user object
        *
        */
        public User UpdateProfile(User user)
        {
            return new User();
        }





        #region AdminUser

        /**
       * \brief To Set Log File Directory  - given a set of attribute values
       * \details <b>Details</b>
       *
       * \param newPath - <b>String</b> - Path of the directory
       * 
       * \return if successfully set up new path returns true
       *
       */
        public bool SetLogFileDirectory(string newPath)
        {
            // if success returns true
            return true;
        }



        /**
         * \brief To Set Server Connection  - given a set of attribute values
         * \details <b>Details</b>
         *
         * \param connectionString - <b>String</b> - the connection String
         * 
         * \return if success returns true
         *
         */
        public bool SetServerConnection(string connectionString)
        {
            // if success returns true
            return true;
        }




        /**
         * \brief To Review Logs  - given a set of attribute values
         * \details <b>Details</b>
         *
         * \param void
         * 
         * \return if success returns list of logs
         *
         */
        public List<Log> ReviewLogs()
        {
            // if success returns list of logs
            return new List<Log>();
        }


        /**
        * \brief To Update Fee of ships - given a set of attribute values
        * \details <b>Details</b>
        *
        * \param fee- <b>Fee</b> - the current Fee
        * 
        * \return if success returns list of logs
        *
        */
        public bool UpdateFee(Fee fee)
        {
            // if success returns true
            return true;
        }




        /**
        * \brief To Update Carrier - given a set of attribute values
        * \details <b>Details</b>
        *
        * \param carrier- <b>Carrier</b> - the current Carrier
        * 
        * \return if success returns true
        *
        */
        public bool UpdateCarrier(Carrier carrier)
        {
            // if success returns true
            return true;
        }


        /**
        * \brief To Update route of shipment - given a set of attribute values
        * \details <b>Details</b>
        *
        * \param route- <b>Route</b> - the current route
        * 
        * \return if successfully updated route returns true
        *
        */
        public bool UpdateRoute(Route route)
        {
            // if success returns true
            return true;
        }



        /**
       * \brief The backup of DB
       * \details <b>Details</b>
       *
       * \param void
       * 
       * \return if successfully backedups returns true
       *
       */
        public bool DB_Backup()
        {
            // if success returns true
            return true;
        }


        #endregion


        #region BuyerUser


        /**
       * \brief To receive the contract  - given a set of attribute values
       * \details <b>Details</b>
       *
       * \param contract - <b>Contract</b> - the contract needed to be received
       * 
       * \return if successfully received contract returns true
       *
       */
        public bool ReceiveContract(Contract contract)
        {
            // if success returns true
            return true;
        }


        /**
        * \brief update the profile of the customer  - given a set of attribute values
        * \details <b>Details</b>
        *
        * \param customer - <b>User</b> - the current profile of customer
        * 
        * \return if success updated profile of customer, returns true
        *
        */
        public bool UpdateCustomer(Customer customer)
        {
            // if success returns true
            return true;
        }


        /**
        * \brief To update the order of the customer  - given a set of attribute values
        * \details <b>Details</b>
        *
        * \param order - <b>CustomerOrder</b> - the existing order of customer
        * 
        * \return if success updated order of customer, returns true
        *
        */
        public bool UpdateOrder(CustomerOrder order)
        {
            // if success returns true
            return true;
        }


        /**
      * \brief To set order of carrier  - given a set of attribute values
      * \details <b>Details</b>
      *
      * \param order - <b>CustomerOrder</b> - the order of customer
      * \param carrier - <b>Carrier</b> - the details of current carrier
      * 
      * \return if success set carrier order, returns true
      *
      */
        public bool SetOrderCarrier(CustomerOrder order, Carrier carrier)
        {
            // if success returns true
            return true;
        }


        /**
        * \brief To gernerate invoice of the order  - given a set of attribute values
        * \details <b>Details</b>
        *
        * \param order - <b>CustomerOrder</b> - the order of customer
        * 
        * \return thw invoice of the order
        *
        */
        public Invoice GenerateOrderInvoice(CustomerOrder order)
        {
            // if success returns invoice object
            return new Invoice();
        }

        #endregion


        #region PlannerUser


        /**
       * \brief To review the order  - given a set of attribute values
       * \details <b>Details</b>
       *
       * \param order - <b>CustomerOrder</b> - the order of customer
       * 
       * \return if successfully reviewed order return true
       *
       */
        public bool ReviewOrder(CustomerOrder order)
        {
            // if success returns true
            return true;
        }



        /**
       * \brief To create the trip of order for delivery  - given a set of attribute values
       * \details <b>Details</b>
       *
       * \param order - <b>CustomerOrder</b> - the orders of customer
       * 
       * \return the list of trips for the order
       *
       */
        public List<OrderTrip> CreateOrderTrips(CustomerOrder order)
        {
            // if success returns List of trips for the order
            return new List<OrderTrip>();
        }



        /**
       * \brief The estimation of the order  - given a set of attribute values
       * \details <b>Details</b>
       *
       * \param order - <b>CustomerOrder</b> - the order of customer
       * 
       * \return if successfully estimated order return true
       *
       */
        public bool OrderEstimation(CustomerOrder order)
        {
            // if success returns true
            return true;
        }



        /**
      * \brief The review the status of the customer order  - given a set of attribute values
      * \details <b>Details</b>
      *
      * \param order - <b>CustomerOrder</b> - the order of customer
      * 
      * \return the order status
      *
      */
        public OrderStatus ReviewOrderStatus(CustomerOrder order)
        {
            // if success returns OrderStatus
            return new OrderStatus();
        }



        /**
           * \brief To Monitor the order status of the customer order  - given a set of attribute values
           * \details <b>Details</b>
           *
           * \param order - <b>CustomerOrder</b> - the order of customer
           * 
           * \return if successfully monitored the order progress returns true
           *
           */
        public bool MonitorOrderProgress(CustomerOrder order)
        {
            // if success returns true
            return true;
        }



        /**
       * \brief To generate the report of the customer order  - given a set of attribute values
       * \details <b>Details</b>
       *
       * \param void
       * 
       * \return the generated report
       *
   */
        public OrderReportModel GenerateReport()
        {
            // if success returns true
            return new OrderReportModel();
        }

        #endregion

    }
}
