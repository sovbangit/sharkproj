using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace raspiapiproj.Controllers
{
    [ApiController]
   
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

 
        [HttpGet]
        [Route("[controller]")]
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
