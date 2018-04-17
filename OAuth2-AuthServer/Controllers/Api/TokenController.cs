using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OAuth2_AuthServer.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/token")]
    public class TokenController : Controller
    {
        /// <summary>
        /// Let's client get their own access token
        /// client credentials can either be passed in body or in basic header
        /// </summary>
        /// <param name="grant_type"></param>
        /// <param name="client_id"></param>
        /// <param name="client_secret"></param>
        /// <param name="scope"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("")]
        public async Task<ActionResult> Post(string grant_type, string client_id = "", string client_secret = "", string scope = "")
        {
            //Verify 1 but not both set of credentials exist (Basic or post body)
            //Verify grant_type
            //Verify credentials
            //Generate Access token
            //Store
            //return result

            throw new NotImplementedException();
        }

        /// <summary>
        /// Let's a resource server get an access token for a client
        /// </summary>
        /// <param name="grant_type"></param>
        /// <param name="client_id"></param>
        /// <param name="client_secret"></param>
        /// <param name="scope"></param>
        /// <returns></returns>
        [HttpPost]
        [BasicAuth]
        [Route("/for_client")]
        public async Task<ActionResult> PostForClient(string grant_type, string client_id, string client_secret, string scope = "")
        {
            //Verify grant_type
            //Verify client_id exists for app
            //Verify client credentials
            //Generate access token
            //Store
            //return result
            throw new NotImplementedException();
        }

        /// <summary>
        /// Used by resource server to check access token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpPost]
        [BasicAuth]
        [Route("")]
        public async Task<ActionResult> Introspect(string token)
        {
            //Verify app owns token
            //return result
            throw new NotImplementedException();
        }

        /// <summary>
        /// Let's a user or resource server revoke an access token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpDelete]
        [BasicAuth]
        [UserAuth]
        [Route("")]
        public async Task<ActionResult> Revoke(string token)
        {
            //Verify app or person's app owns token
            //Remove
            //return Result
            throw new NotImplementedException();
        }
    }
}