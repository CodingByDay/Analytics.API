using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardWeb;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDashboardBackend {
    public class DefaultDashboardController : DashboardController {
        public DefaultDashboardController(DashboardConfigurator configurator, IDataProtectionProvider? dataProtectionProvider = null)
            : base(configurator, dataProtectionProvider) {
            
        }


        [HttpGet("")]
        public IActionResult GetWMSApi()
        {
            return Ok("API for WMS");
        }

    }
}
