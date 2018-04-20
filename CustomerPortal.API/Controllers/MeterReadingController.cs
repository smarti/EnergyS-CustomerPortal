using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using Application.Providers;
using Application.ViewModels;

namespace CustomerPortal.API.Controllers
{
    [EnableCors("*", "*", "*")]
    [Route("api/{customerId}/meterReadings")]
    public class MeterReadingController : ApiController
    {
        private readonly MeterReadingProvider _provider;

        public MeterReadingController()
        {
            _provider = new MeterReadingProvider();
        }

        [HttpGet]
        public List<MeterReadingViewModel> GetAllMeterReadingsByCustomerId(int customerId)
        {
            List<MeterReadingViewModel> meterReadings = _provider.GetAllMeterReadingsByCustomerId(customerId);

            return meterReadings;
        }
    }
}