using Dal;
using Dal.Context;
using MyHelper.DTO;
using Security.BasiAuthentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;


namespace MyHelper.Controllers
{
    [RoutePrefix("api/User")]
    public class HomeController : ApiController
    {
        /// <summary>
        /// Method to create a new user 
        /// </summary>
        /// <param name="newUser">A new user object for creation</param>
        /// <returns>The result of the creation</returns>
        [HttpPost]
        public HttpResponseMessage NewUser(NewUser newUser)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest,
                    ModelState.Select(x => x.Value.Errors)
                           .Where(y => y.Count > 0)
                           .ToList());
            }

            // Create a new user if not existing
            using (var db = new LilHelperEntities())
            {
                if (db.User.Any(user => user.EMail.Equals(newUser.Email, StringComparison.OrdinalIgnoreCase)))
                {
                    return Request.CreateResponse(HttpStatusCode.Conflict, "User allready exists");
                }

                else
                {
                    try
                    {
                        db.User.Add(new User() { EMail = newUser.Email, Password = newUser.Password });
                        db.SaveChanges();

                        return Request.CreateResponse(HttpStatusCode.OK, "User created");
                    }
                    catch(Exception e)
                    {
                        return Request.CreateResponse(HttpStatusCode.ServiceUnavailable, "Please try again later");
                    }
                }
            }
        }
    }
}
