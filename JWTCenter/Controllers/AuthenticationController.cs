using JWTCenter.Unity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTCenter.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController
    {
        public ICustomDesJwtService _customDesJwtService = null;
        public AuthenticationController(ICustomDesJwtService customDesJwtService)
        {
            _customDesJwtService = customDesJwtService;
        }

        [Route("Login")]
        [HttpPost]
        public string Login(string name)
        {
            if (name == "admin")
            {
                string token = _customDesJwtService.GetToken(name);
                return JsonConvert.SerializeObject(new
                {
                    result = true,
                    token
                });
            }
            else
            {
                return JsonConvert.SerializeObject(new
                {
                    result = false,
                    token=""
                });
            }
        }
    }
}
