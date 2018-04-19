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
    [RoutePrefix("api/reports")]
    public class ReportController : ApiController
    {
        private readonly ReportProvider _provider;

        public ReportController() : base()
        {
            _provider = new ReportProvider();
        }

        [Route("all/{customerId}")]
        [HttpGet]
        public List<ReportViewModel> GetAllReportsByCustomerId(int customerId)
        {
            List<ReportViewModel> reports = _provider.GetAllReportsByCustomerId(customerId);

            return reports;
        }

        [HttpPost]
        [Route("add/{customerId}")]
        public void CreateReportByCustomerId(int customerId, [FromBody] ReportViewModel reportViewModel)
        {
            reportViewModel.DescriptionStatus = "Nieuw";
            reportViewModel.LastUpdate = DateTime.Now;

            _provider.CreateReportByCustomerId(customerId, reportViewModel);

        }
    }
}