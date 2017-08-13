using Dal.Repositories;
using MyHelper.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyHelper.Controllers
{
    /// <summary>
    /// Controller that handles all requests for user informations
    /// </summary>
    //[Authorize]
    public class UsersController : ApiController
    {
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// Standardconstrutor for injection
        /// </summary>
        /// <param name="userRepository"></param>
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Gets a single user by its id
        /// </summary>
        /// <param name="id">Unique identifier</param>
        /// <returns>A single user</returns>
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var user = _userRepository.GetById(id);

                if (user == null)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "User not found");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, user);
                }
            }
            catch(Exception e)
            {
                // Log it
                return Request.CreateResponse(HttpStatusCode.ServiceUnavailable, e.Message + e.InnerException);
            }
        }

        //public HttpResponseMessage Register(NewUser user)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.BadRequest);
        //    }
        //}
    }
}
