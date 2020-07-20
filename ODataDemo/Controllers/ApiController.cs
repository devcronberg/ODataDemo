using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SQLiteEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataDemo.Controllers
{
    public class ApiController : ODataController
    {
        private readonly ILogger<ApiController> _logger;
        private readonly SQLiteEF.PeopleContext _context;

        public ApiController(ILogger<ApiController> logger, SQLiteEF.PeopleContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        
        [HttpGet]
        [EnableQuery(PageSize = 50)]
        [ODataRoute("people")]
        public IQueryable<Person> GetPeople()
        {
            return _context.People;
        }

        [HttpGet]
        [EnableQuery]
        [ODataRoute("people({id})")]
        public IActionResult GetAddresses([FromODataUri] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var people = SingleResult.Create(_context.People.Where(p => p.PersonId == id));
            return Ok(people);
        }

    }
}
