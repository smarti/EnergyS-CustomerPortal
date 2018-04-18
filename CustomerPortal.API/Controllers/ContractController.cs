using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using Application.Providers;
using Application.ViewModels;

namespace CustomerPortal.API.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/contracts")]
    public class ContractController : ApiController
    {
        private ContractProvider _provider;

        public ContractController() : base()
        {
            _provider = new ContractProvider();
        }

        [Route("all/{customerId}")]
        [HttpGet]
        public List<ContractViewModel> GetAllContractsByCustomerId(int customerId)
        {
            List<ContractViewModel> contracts = _provider.GetAllContractsByCustomerId(customerId);

            return contracts;
        }

        [HttpPost]
        [Route("add")]
        public void CreateContractByCustomerId(int customerId, string description)
        {
            ContractViewModel contract = new ContractViewModel
            {
                ContractStatus = "In behandeling",
                Description = description,
                LastUpdate = DateTime.Now

            };
            _provider.CreateContractByCustomerId(customerId, contract);
        }
    }
}