using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Services;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookApiController : ControllerBase
    {
        private readonly IBooksService _service;
        public BookApiController(IBooksService service)
        {
            _service = service;
        }

        // GET: api/<ProductApiController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }
    }
}
