using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pizza_mama.Data;
using pizza_mama.Models;

namespace pizza_mama.Controllers
{
    
    
    [Route("[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        DataContext dataContext;
    
        public ApiController(DataContext dataContext){
            this.dataContext = dataContext;
        }
        
        // GET: api/Api
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        
        [HttpGet]
        [Route("getpizzas")]
        public IActionResult GetPizzas()
        {
            var pizzas = dataContext.Pizzas.ToList();
             return Json(pizzas);
            
        }
    }
}
