using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using static CRUDAPI.Entity.Members;

namespace CRUDAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private IConfiguration Configuration;
        

        public MembersController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpGet]
        [Route("GetMember")]

        public MemberResponse GetMember()
        {
            MemberResponse memberResponse = new MemberResponse();

            return memberResponse;
        }
    }
}
