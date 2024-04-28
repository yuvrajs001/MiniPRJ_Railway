using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Assignment_01.Models;

namespace Assignment_01.Controllers
{
    public class Country_Controller : ApiController
    {
        [RoutePrefix("api/country")]
        public class PersonController : ApiController
        {

            static List<Country> Countrylist = new List<Country>()
        {
            new Country { Id = 1, CountryName = "India", Capital = "New Delhi" },
            new Country { Id = 2, CountryName = "Australia", Capital = "Canberra" },
            new Country { Id = 3, CountryName = "Brazil", Capital = "Brasília" },
            new Country { Id = 4, CountryName = "Canada", Capital = "Ottawa" },
            new Country { Id = 5, CountryName = "Japan", Capital = "Tokyo" }

        };

            //get operation
            [HttpGet]
            [Route("getlist")]
            public HttpResponseMessage GetAllCountry()
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Countrylist);
                return response;
            }
            [HttpGet]
            [Route("get/{byid}")]
            public HttpResponseMessage GetCountryById(int id)
            {

                var country = Countrylist.FirstOrDefault(c => c.Id == id);
                if (country == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, country);
            }



            [HttpPost]
            [Route("Countrypost")]
            public HttpResponseMessage Post([FromUri] int Id, string CountryName, string capital)
            {

                // Create a new country object
                Country country = new Country();
                country.Id = Id;
                country.CountryName = CountryName;
                country.Capital = capital;

                // Add the country to the list
                Countrylist.Add(country);
                return Request.CreateResponse(HttpStatusCode.OK, Countrylist);
            }
            //Put-------

            [HttpPut]
            [Route("update")]
            public HttpResponseMessage Put(int pid, [FromBody] Country c)
            {
                if (pid <= 0 || pid > Countrylist.Count)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Country not found");
                }

                Countrylist[pid - 1] = c;
                return Request.CreateResponse(HttpStatusCode.OK, Countrylist);
            }
            //Delete--------
            [HttpDelete]
            [Route("deletecountry")]
            public IHttpActionResult Delete(int pid)
            {
                if (pid <= 0 || pid > Countrylist.Count)
                {
                    return NotFound();
                }

                Countrylist.RemoveAt(pid - 1);
                return Ok(Countrylist);
            }
        }
    }

}
