using SampleWebApi.Models.Services;
using SampleWebApi.Models.Services.Rmm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleWebApi.Controllers
{
    /// <summary>
    /// API to activate and deactivate partner services.
    /// </summary>
    [AllowAnonymous]
    public class ServiceController : ApiController
    {
        /// <summary>
        /// Activates the RMM service for a partner.
        /// </summary>
        /// <param name="partnerid"></param>
        /// <param name="rmmServiceActivationInfo"></param>              
        [Route("partner/{partnerid:int}/service/rmm/activate")]
        public RmmServiceActivationResult ActivateRmmService(int partnerid, RmmServiceActivationRequest rmmServiceActivationInfo)
        {
            return null;
        }

        /// <summary>
        /// Activates the Backup service for a partner.
        /// </summary>
        /// <param name="partnerid"></param>        
        [Route("partner/{partnerid:int}/service/backup/activate")]
        public void ActivateBackupService(int partnerid)
        {
        }

        /// <summary>
        /// Activates the SSO service for a partner.
        /// </summary>
        /// <param name="partnerid"></param>        
        [Route("partner/{partnerid:int}/service/sso/activate")]
        public void ActivateSsoService(int partnerid)
        {
        }

        /// <summary>
        /// Activates the NOC service for a partner.
        /// </summary>
        /// <param name="partnerid"></param>       
        [Route("partner/{partnerid:int}/service/noc/activate")]
        public void ActivateNocService(int partnerid)
        {
        }

        /// <summary>
        /// Activates the Helpdesk service for a partner.
        /// </summary>
        /// <param name="partnerid"></param>        
        [Route("partner/{partnerid:int}/service/helpdesk/activate")]
        public void ActivateHelpdeskService(int partnerid)
        {
        }

        /// <summary>
        /// Deactivates the specified service for a partner.
        /// </summary>
        /// <param name="partnerid">The ID of the partner.</param>
        /// <param name="service">The type of the service.</param>       
        [Route("partner/{partnerid:int}/service/deactivate")]
        public void DeactivateService(int partnerid, Service service)
        {
        }
    }
}
