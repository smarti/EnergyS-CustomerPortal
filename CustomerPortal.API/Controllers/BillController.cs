using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using Application.Providers;
using Application.ViewModels;

namespace CustomerPortal.API.Controllers
{
    [EnableCors("*", "*", "*")]
    [Route ("api/{customerId}/bills")]
    public class BillController : ApiController
    {
        private BillProvider _provider;

        public BillController() : base()
        {
            _provider = new BillProvider();
        }

        [HttpGet]
        public List<BillViewModel> GetAllBillsByCustomerId(int customerId)
        {
            List<BillViewModel> bills = _provider.GetAlllBillsByCustomerId(customerId);

            return bills;
        }
    }
}