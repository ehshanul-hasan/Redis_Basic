using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Redis_Basic.Controllers
{
    [ApiController]
    [Route("api/redis")]
    public class RedisDemoController : ControllerBase
    {
        private readonly IDistributedCache _redisCache;

        public RedisDemoController(IDistributedCache cache)
        {
            _redisCache = cache;
        }

        [HttpGet]
        public async Task<ActionResult<string>> Get([FromQuery] string key)
        {
            return await _redisCache.GetStringAsync(key);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromQuery] string key, [FromQuery] string value)
        {
            await _redisCache.SetStringAsync(key, value);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete([FromQuery] string key)
        {
            await _redisCache.RemoveAsync(key);
            return Ok();
        }
    }
}
