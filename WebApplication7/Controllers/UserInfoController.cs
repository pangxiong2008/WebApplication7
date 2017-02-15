using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication7.Controllers
{
    public class UserInfoController : ApiController
    {
        Models.UserInfo bll = new Models.UserInfo();
        // GET: api/UserInfo
        public IEnumerable<Models.UserInfo> Get()
        {
            // return new string[] { "value1", "value2" };
            return bll.get();
        }

        // GET: api/UserInfo/5
        public string Get(string  v1,string v2)
        {
            return v1 + v2;
        }

        public string Get(int id)
        {
            return "value";
        }
        public string PostAaa()
        {
            return "helloword";
        }

        // POST: api/UserInfo
        public string  Post([FromBody]string value)
        {
            return value;
        }

        public string Post()
        {
            string postdata = Request.Content.ReadAsStringAsync().Result;
            return postdata;
        }
        // PUT: api/UserInfo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UserInfo/5
        public void Delete(int id)
        {
        }
    }
}
