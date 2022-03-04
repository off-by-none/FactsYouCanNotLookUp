using FactsYouCanNotLookUp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FactsYouCanNotLookUp.Controllers
{
    [Route("FactsYouCanNotLookUp/[controller]")]
    [ApiController]
    public class FactsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetFact()
        {
            try
            {
                var results = new Fact
                {
                    FactId = 1,
                    BingoId = "o68",
                    isOprah = true,
                    Value = "On her 68th birthday, Oprah was able to blow out all 68 candles on her cake.",
                    Updated = DateTime.UtcNow,
                };

                return Ok(results);
            }
            catch
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Whoops");
            }
        }

        //[HttpGet("{factId:int}")]
        //public ActionResult<Fact> GetFact(int factId)
        //{
        //    try
        //    {
        //        var results = new Fact
        //        {
        //            FactId = 1,
        //            BingoId = "o68",
        //            isOprah = true,
        //            Value = "On her 68th birthday, Oprah was able to blow out all 68 candles on her cake.",
        //            Updated = DateTime.UtcNow,
        //        };

        //        return Ok(results);
        //    }
        //    catch
        //    {
        //        return this.StatusCode(StatusCodes.Status500InternalServerError, "Whoops");
        //    }
        //}

        //[HttpGet("{bingoId}")]
        //public ActionResult<Fact> GetFact(string bingoId)
        //{
        //    try
        //    {
        //        var results = new Fact
        //        {
        //            FactId = 1,
        //            BingoId = "o68",
        //            isOprah = true,
        //            Value = "On her 68th birthday, Oprah was able to blow out all 68 candles on her cake.",
        //            Updated = DateTime.UtcNow,
        //        };

        //        return Ok(results);
        //    }
        //    catch
        //    {
        //        return this.StatusCode(StatusCodes.Status500InternalServerError, "Whoops");
        //    }
        //}

        //[HttpGet]
        //public ActionResult<Fact> GetFact(bool isOprah = true)
        //{
        //    try
        //    {
        //        var results = new Fact
        //        {
        //            FactId = 1,
        //            BingoId = "o68",
        //            isOprah = true,
        //            Value = "On her 68th birthday, Oprah was able to blow out all 68 candles on her cake.",
        //            Updated = DateTime.UtcNow,
        //        };

        //        return Ok(results);
        //    }
        //    catch
        //    {
        //        return this.StatusCode(StatusCodes.Status500InternalServerError, "Whoops");
        //    }
        //}
    }
}
