using BusinessRules;
using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AppWeb.Controllers
{
    [EnableCors("*","*","*")]
    public class CityController : ApiController
    {
        [HttpGet]
        [Route("~/api/City/GetCities")]
        public IHttpActionResult GetCities()
        {
            try
            {
                var result = CityBR.GetCities();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
;            }
        }

        [HttpPost]
        [Route("~/api/City/CreateEditCity")]
        public IHttpActionResult CreateEditCity(CityModel City)
        {
            try
            {
                var result = CityBR.CreateEditCity(City);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/City/DeleteCity/{code}")]
        public IHttpActionResult DeleteCity(int code)
        {
            try
            {
                var result = CityBR.DeleteCity(code);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
