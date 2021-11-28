using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DataAccessLayer.Models;

namespace TMS_DataAccessLayer.Managers
{
    public class CustomerManager
    {
        public Customer SignUp(Customer customer)
        {
            // if success returns customer object
            return new Customer();
        }

        public Contract CreateNewContract(Contract contract)
        {
            // if success returns contract object
            return new Contract();
        }

        public CustomerOrder CreateNewOrder(CustomerOrder order)
        {
            // if success returns contract object
            return new CustomerOrder();
        }

    }
}
