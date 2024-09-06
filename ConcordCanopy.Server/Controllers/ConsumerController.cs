using ConcordCanopy.Server.Data;
using ConcordCanopy.Server.Models;
using ConcordCanopy.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConcordCanopy.Server.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ConsumerController : Controller
    {
        private ConsumerData _consumerData;

        ConsumerController(ConsumerData consumerData)
        {
            _consumerData = consumerData;
        }

        [HttpGet("{id}")]
        public IActionResult ConsumerId(Int32? id)
        {
            if (!id.HasValue)
                return RedirectToAction("Index");

            return View();
        }
    }
}
