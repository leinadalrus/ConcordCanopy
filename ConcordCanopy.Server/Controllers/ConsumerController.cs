using ConcordCanopy.Server.Data;
using ConcordCanopy.Server.Models;
using ConcordCanopy.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConcordCanopy.Server.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ConsumerController : ControllerBase
    {
        private ConsumerData _consumerData;

        ConsumerController(ConsumerData consumerData)
        {
            _consumerData = consumerData;
        }

        [HttpGet("GetConsumer/{id}")]
        public IEnumerable<Consumer> ConsumerId(Int32? id)
        {
            return Enumerable.Range(0, 1).Select(x => new Consumer
            {
                Id = 0,
                Nickname = "",
            })
            .ToArray();
        }
    }
}
