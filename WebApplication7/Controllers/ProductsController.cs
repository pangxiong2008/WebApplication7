using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class ProductsController : ApiController
    {

        Product[] products = new Product[]
        {
            new Product {Id=1,Name ="tomato soup",Category="groceries",Price=1 },
            new Product {Id=2,Name ="yo-yo",Category="toys",Price=3.75M },
            new Product {Id=3,Name ="hammer",Category ="hardware",Price=16.99M }
        };
        [HttpGet]
        ///  GET api/Products/GetAllProducts/
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
            
        }
        [HttpGet]
        ///  GET api/Products/GetproductById/id
        public Product GetproductById(int id)
        {
            var product1 = products.FirstOrDefault((p) => p.Id == id);
            if (product1==null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return product1;

        }
        [HttpGet]
        //http://localhost:49456/api/Products/GetProductsByCategory/?category=toys&id=2
        ///  GET api/Products/GetProductsByCategory/?category=category&id=id
        public IEnumerable<Product> GetProductsByCategory(string category,int id)
        {
             return products.Where((p) => string.Equals(p.Category, category, StringComparison.OrdinalIgnoreCase)&&(p.Id==id));
           // return products.Where((p) => string.Equals(p.Category, category, StringComparison.OrdinalIgnoreCase));
        }

        [HttpGet, HttpPost]
        public void list(int id, [FromUri] string apiKey, [FromUri] string description, [FromBody] Balance_Update balance)
        {

            var dd = 1;
            //int maxId = list.Max(e => e.Id);
            //employee.Id = maxId + 1;
            //list.Add(employee);
            //var response = Request.CreateResponse<Employee>(HttpStatusCode.Created, employee);
            //string uri = Url.Link("DefaultApi", new { id = employee.Id });
            //response.Headers.Location = new Uri(uri);
            //return response;

            //*****************************************************//
            //next code is post data to this webapi,it is working , it add by cory in 2016-11-23

            // Url = "http://localhost:49456/api/Products/list/";
            //         id = "1163945558";
            //         apiKey = "0f43d4dcf2078e70f1138cc018645f01";
            //request.Method = "POST";
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this.URL + this.MadID + "?apiKey=" + this.Apikey + "&description=something");


            //request.ContentType = "application/json";

            //var streamWriter = new StreamWriter(request.GetRequestStream());//denis side cannont read the byte[] data, so just send json data, cory wu in 2016-11-17

            //this.Data = result_json_write();

            //streamWriter.Write(this.Data);
            //streamWriter.Flush();
            //streamWriter.Close();

            //****************************************************************//
        }
    }

    public class Balance_Update
    {

        public string balance { get; set; }

        // public string phone { get; set; }

    }
}
