using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace raspiapiproj.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<dynamic> Get()
        {
            IEnumerable<dynamic> dict =
            new List<dynamic>(){
                                  {"nCoin"},
                                  {"Xther"},
                                  {"hotdog"} };
            return dict;
        }
    }
}
