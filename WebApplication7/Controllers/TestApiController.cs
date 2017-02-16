using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication7.Controllers
{
    public class TestApiController : ApiController
    {
        public string GetTest()
        {
            return "hello world";
        }
        public string GetTest2(string id)
        {
            return id;
        }
    }
}
