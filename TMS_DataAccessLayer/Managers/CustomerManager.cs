using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DataAccessLayer.Models;
using TMS_DataAccessLayer.MySQL_Connector;

namespace TMS_DataAccessLayer.Managers
{
    public class CustomerManager
    {
        DataManager dataManager = new DataManager();
        public Customer SignUp(Customer customer)
        {
            return dataManager.UpdateEntity(customer, "Customer", false);
        }

        public Contract CreateNewContract(Contract contract)
        {
            return dataManager.UpdateEntity(contract, "Contract", false);
        }

        public CustomerOrder CreateNewOrder(CustomerOrder order)
        {
            return dataManager.UpdateEntity(order, "CustomerOrder", false);
        }

    }
}
