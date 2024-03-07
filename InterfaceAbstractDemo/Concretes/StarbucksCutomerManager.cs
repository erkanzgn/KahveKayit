﻿using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concretes
{
    public class StarbucksCutomerManager :BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;
        public StarbucksCutomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if(_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);

            }
            else
            {
                throw new Exception("Not a valid person");
            }
            base.Save(customer);
        }

 
    }
}