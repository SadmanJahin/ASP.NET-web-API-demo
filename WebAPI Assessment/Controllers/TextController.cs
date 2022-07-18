using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using WebAPI_Assessment.Models;

namespace WebAPI_Assessment.Controllers
{
    public class TextController : ApiController
    {

        DatabaseContext db = new DatabaseContext();
       // GET api/<controller>
       [HttpGet]
        public object get()
        {
            return db.Texts.OrderByDescending(p => p.id).Select(p => new { p.Line })
                       .FirstOrDefault(); 
        }
        [HttpPost]
        public HttpResponseMessage post(JObject json)
        {
            var re = Request;
            var headers = re.Headers;
            string page_size = "";
            if (headers.Contains("Custom-Header"))
            {
                 page_size = headers.GetValues("Custom-Header").First();
            }
            int n = Convert.ToInt32(page_size);
            List<String> header = json["ListOfWords"].ToObject<List<String>>();
            string processed_text="";

            foreach(string items in header)
            {
                processed_text += items+" ";
                
            }

            char[] characters = processed_text.ToCharArray();
            int length = characters.Length;
            List<char> final_line = new List<char>();
            
            for(int i=0;i<length;i++)
            {
                final_line.Add(characters[i]);
                if((i+1)%n==0)
                {
                    final_line.Add('\n');
                }
            }

            try
            {
                Text text = new Text();
                text.Line = new string(final_line.ToArray());
                db.Texts.Add(text);
                db.SaveChanges();
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Created);
                return response;
            }
            catch
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                return response;
            }

           
            
            //return Content((HttpStatusCode)201, "OK");

            
        }
        // POST api/<controller>
       

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}