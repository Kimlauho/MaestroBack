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
    [EnableCors("*", "*", "*")]
    public class SellerController : ApiController
    {
        [HttpGet]
        [Route("~/api/Seller/GetSellers/{code}")]
        public IHttpActionResult GetSellers(int code)
        {
            try
            {
                var result = SellerBR.GetSellers(code);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("~/api/Seller/CreateEditSeller")]
        public IHttpActionResult CreateEditSeller(SellerModel seller)
        {
            try
            {
                var result = SellerBR.CreateEditSeller(seller);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("~/api/Seller/DeleteSeller/{code}")]
        public IHttpActionResult DeleteSeller(int code)
        {
            try
            {
                var result = SellerBR.DeleteSeller(code);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
