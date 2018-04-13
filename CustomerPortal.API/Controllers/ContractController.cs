using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Application.Providers;
using Application.ViewModels;

namespace CustomerPortal.API.Controllers
{
    [Route("api/{customerId}/contracts")]
    public class ContractController : ApiController
    {
        private ContractProvider _provider;

        public ContractController() : base()
        {
            _provider = new ContractProvider();
        }

        [HttpGet]
        public List<ContractViewModel> GetAllContractsByCustomerId(int customerId)
        {
            List<ContractViewModel> contracts = _provider.GetAllContractsByCustomerId(customerId);

            return contracts;
        }
    }
}