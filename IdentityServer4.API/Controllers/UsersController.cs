using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServer4.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<User> Get()
        {
            List<User> users = new List<User>();
            users.Add(new User { Nombre = "Erick", Email = "roy360erick@gmail.com", Telefono = "987654321" });
            users.Add(new User { Nombre = "Juan", Email = "Juan@gmail.com", Telefono = "2221212112" });
            users.Add(new User { Nombre = "Luis", Email = "luis@gmail.com", Telefono = "1235689222" });

            return users;
        }
    }
}