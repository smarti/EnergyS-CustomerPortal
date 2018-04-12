using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Application.ViewModels;
using Application.Providers;

namespace CustomerPortal.API.Controllers
{
    [Route("api/customer/{customerId}")]
    public class CustomerController : ApiController
    {
        private CustomerProvider _provider;

        public CustomerController() : base()
        {
            _provider = new CustomerProvider();
        }

        [HttpGet]
        public CustomerViewModel GetCustomerById(int customerId)
        {
            CustomerViewModel customer = _provider.GetCustomerById(customerId);

            return customer;
        }
    }
}