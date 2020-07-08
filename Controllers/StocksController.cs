using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stocks.Data;

namespace Stock_List.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private IStockService _service;
        public StocksController(IStockService service)
        {
            this._service = service;
        }

        [HttpGet("[action]")]
        public IActionResult GetStocks()
        {
            var allStocks = _service.GetAllStocks();
            return Ok(allStocks);
        }

        [HttpGet("SingleStock/{id}")]
        public IActionResult GetStockById(int id)
        {
            var stock = _service.GetStockById(id);
            return Ok(stock);
        }

        [HttpPost("AddStock")]
        public IActionResult AddStock([FromBody]Stock stock)
        {
            if (stock != null)
            {
                _service.AddStock(stock);
            }
            return Ok();
        }

        [HttpPut("UpdateStock/{id}")]
        public IActionResult UpdateTrip(int id, [FromBody]Stock stock)
        {
            _service.UpdateStock(id, stock);
            return Ok(stock);
        }

        [HttpDelete("DeleteStock/{id}")]
        public IActionResult DeleteStock(int id)
        {
            _service.DeleteStock(id);
            return Ok();
        }
    }
}