using System;
using Microsoft.AspNetCore.Mvc;

namespace RngApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RngController : ControllerBase
    {
        [HttpGet("{count}")]
        public ActionResult<int[]> Get(int count)
        {
            Random random = new Random();
            int[] result = new int[count];

            for (int idx = 0; idx < count; idx++)
            {
                result[idx] = random.Next();
            }

            return result;
        }
    }
}