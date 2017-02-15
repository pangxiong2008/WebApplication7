using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        private List<UserInfo> Data = new List<UserInfo>
        {
            new UserInfo() { Id=1,Name="haha",Age=10},
            new UserInfo() { Id=2,Name="heihei",Age=19},

        };
        public IEnumerable<UserInfo> get()
        {

            return Data;
        }
    }
}