using System.Web.Http;
using System.Web.Http.Cors;
using Application.Providers;
using Application.ViewModels;

namespace CustomerPortal.API.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/customers")]
    public class CustomerController : ApiController
    {
        private readonly CustomerProvider _provider;

        public CustomerController()
        {
            _provider = new CustomerProvider();
        }

        [Route("login")]
        [HttpPost]
        public int CheckCustomerLogin([FromBody] NamePasswordDTO namePasswordDTO)
        {
            int customerId = _provider.CheckCustomerLogin(namePasswordDTO.EMail, namePasswordDTO.Password);

            return customerId;
        }

        [Route("changePassword")]
        [HttpPost]
        public void ChangeCustomerPassword([FromBody] ChangePasswordDTO changePasswordDTO)
        {
            _provider.ChangeCustomerPassword(changePasswordDTO.CustomerId, changePasswordDTO.OldPassword,
                changePasswordDTO.NewPassword);
        }
    }
}