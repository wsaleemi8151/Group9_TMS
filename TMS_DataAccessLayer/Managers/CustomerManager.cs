using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DataAccessLayer.Models;

namespace TMS_DataAccessLayer.Managers
{
    /// 
    /// \class CustomerManager
    ///
    /// \brief The purpose capture the functionality of customer manager required for the project
    ///
    /// \author Amritpal Singh <i>TMS-Group 9 Member</i>
    ///
    public class CustomerManager
    {
        /**
        * \brief To instantiate a new Customer object - given a set of attribute values
        * \details <b>Details</b>
        *
        * \param customer - <b>Customer</b> - the customer object that we want to create
        * 
        * \return if success new Customer object is returned
        *
        */
        // return if success returns customer object
        public Customer SignUp(Customer customer)
        {
            // if success returns Customer object
            return new Customer();
        }

        /**
        * \brief To instantiate a new Contract object - given a set of attribute values
        * \details <b>Details</b>
        *
        * \param cuntract - <b>Contract</b> - the contract that we want initiate
        * 
        * \return if success new Contract object is returned
        *
        */
        // return if success returns Contract object
        public Contract CreateNewContract(Contract contract)
        {
            // if success returns contract object
            return new Contract();
        }



        /**
         * \brief To instantiate a new CustomerOrder object - given a set of attribute values
         * \details <b>Details</b>
         *
         * \param order - <b>CustomerOrder</b> - the order details of the object that we want to generate
         * 
         * \return if success new Contract object is returned
         *
         */
        // return if success returns CustomerOrder object
        public CustomerOrder CreateNewOrder(CustomerOrder order)
        {
            // if success returns contract object
            return new CustomerOrder();
        }

    }
}
