using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OAuth2_AuthServer.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/app")]
    [UserAuth]
    public class AppController : Controller
    {
        /// <summary>
        /// Let's a user create an app
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Create(object app)
        {
            //Check properties on app model
            //Store
            //Return result with app id
            throw new NotImplementedException();
        }

        /// <summary>
        /// Let's a user edit the details of an app
        /// </summary>
        /// <param name="id"></param>
        /// <param name="app"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("{id}")]
        public async Task<ActionResult> Edit(int id, object app)
        {
            //Check user owns app
            //Check properties on app model
            //Store
            //Return result
            throw new NotImplementedException();
        }

        /// <summary>
        /// Let's a user view the details of an app (includes clients and scopes)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            //Check user owns app
            //Return result
            throw new NotImplementedException();
        }

        /// <summary>
        /// Let's a user delete an app
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            //Check user owns app
            //Remove from storage
            //Return result
            throw new NotImplementedException();
        }

        /// <summary>
        /// Let's a user or a resource server list the tokens for an app
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}/tokens")]
        [BasicAuth]
        public async Task<ActionResult> ListTokens(int id)
        {
            //Check user owns app
            //get list of tokens
            //return
            throw new NotImplementedException();
        }
        #region scopes
        /// <summary>
        /// Let's a user add a scope to an app
        /// </summary>
        /// <param name="id"></param>
        /// <param name="scope"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("{id}/scope")]
        public async Task<ActionResult> AddScope(int id, object scope)
        {
            //Check user owns app
            //check scope name doesn't exist
            //store scope
            //return result
            throw new NotImplementedException();
        }

        /// <summary>
        /// Let's a user remove a scope from an app
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}/scope/{name}")]
        public async Task<ActionResult> DeleteScope(int id, string name)
        {
            //Check user owns app
            //check scope name exists
            //remove scope from any existing clients
            //remove scope from app
            //return result
            throw new NotImplementedException();
        }
        #endregion

        #region clients
        /// <summary>
        /// Let's a user add a client for an app
        /// </summary>
        /// <param name="id"></param>
        /// <param name="client"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("{id}/client")]
        public async Task<ActionResult> AddClient(int id, object client)
        {
            //Check user owns app
            //Generate client credentials
            //Store
            //return result
            throw new NotImplementedException();
        }

        /// <summary>
        /// Let's a user remove a client from an app
        /// </summary>
        /// <param name="id"></param>
        /// <param name="client_id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}/client/{client_id}")]
        public async Task<ActionResult> DeleteClient(int id, string client_id)
        {
            //Check user owns app
            //check client_id exists
            //Remove
            //return result
            throw new NotImplementedException();
        }

        /// <summary>
        /// Let's a user or resource server view the list of access tokens for a client
        /// </summary>
        /// <param name="id"></param>
        /// <param name="client_id"></param>
        /// <returns></returns>
        [HttpGet]
        [BasicAuth]
        [Route("{id}/client/{client_id}/tokens")]
        public async Task<ActionResult> ListClientTokens(int id, string client_id)
        {
            //Check user owns app
            //check client_id exists
            //return list of tokens
            throw new NotImplementedException();
        }
        #endregion
    }
}