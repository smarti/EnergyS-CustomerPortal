using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Application.Providers;

namespace CustomerPortal.API.Controllers
{
    [RoutePrefix("api/customers")]
    public class CustomerController : ApiController
    {
        private readonly CustomerProvider _provider;

        public CustomerController() : base()
        {
            _provider = new CustomerProvider();
        }

        [Route("login")]
        [HttpPost]
        public int CheckCustomerLogin(string eMail, string password)
        {
            int customer = _provider.CheckCustomerLogin(eMail, password);

            return customer;
        }
    }
}