using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IList<GameResponse> Get()
        {
            var game = new GameResponse
            {
                Name = "Dark Souls",
                Platform = "Multiplataforma",
                Price = 150
            };

            return new List<GameResponse>{game};
        }
    }
}