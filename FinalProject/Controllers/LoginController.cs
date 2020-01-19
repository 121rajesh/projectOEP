using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FinalProject.Models;
//using System.Web.Security;
using System.Web.Http.Cors;


namespace FinalProject.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LoginController : ApiController
    {
        FinalProjectdbEntities5 dalObj = new FinalProjectdbEntities5();
        public LoginController()
        {
            dalObj.Configuration.ProxyCreationEnabled = false;
        }
        public Response Post([FromBody]T_Users user)
        {
            Response response = new Response();
            List<T_Users> users = dalObj.T_Users.ToList();
            if (user.EmailId != null && user.Password != null)
            {
                    var validate = (from u in users
                                    where u.EmailId == user.EmailId && u.Password == 
                                    user.Password
                                    select u).SingleOrDefault();
                if (validate != null)
                {
                    response.Data = validate;
                    response.Error = null;
                    response.Status = "Success";
                    return response;
                }
                else
                {
                    response.Data = null;
                    response.Error =null;
                    response.Status = "Incorrect email or password";
                    return response;
                }
            }
            else
            {
                response.Data = null;
                response.Error = null;
                response.Status = "Fields are empty";
                return response;
            }
        }
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/Login/Register")]
        public Response Register([FromBody] T_Users data)
        {
            Response response = new Response();
            if (data != null)
            {
                try
                {
                    dalObj.T_Users.Add(data);
                    dalObj.SaveChanges();
                    response.Data = data;
                    response.Error = null;
                    response.Status = "Registered successfully, login here";
                    return response;
                }
                catch (Exception e)
                {
                    response.Data = null;
                    response.Error = null;
                    response.Status = "Check credentials";
                    return response;
                }
                
            }
            else
            {
                response.Data = null;
                response.Error = null;
                response.Status = "Fields are empty";
                return response;
            }   
        }
    }
}
