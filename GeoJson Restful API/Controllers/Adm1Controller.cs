using GeoJson_Restful_API.Helpers;
using Microsoft.AspNetCore.Mvc;
using GeoJson_Restful_API.Entities;

namespace GeoJson_Restful_API.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    [Route("api/adm1")]
    public class Adm1Controller : ControllerBase
    {
        private DataContext _context;

        public Adm1Controller(DataContext context)
        {
            _context = context;
        }

        [HttpGet("list", Name = "GetAdm1List")]
        public ActionResult<Adm1List> Get()
        {
            var results = _context.Adm1.Select(d => new Adm1List
            {
                code = d.code,
                name = d.name,
                id = d.id
            });

            if (!results.Any())
                return NotFound();
            else return Ok(results);

            
        }

        [HttpGet("list/{code}", Name = "GetAdm1Detail")]
        public ActionResult<Adm1> GetDetail(string code)
        {
            var result = _context.Adm1.Where(d => d.code == code);

            if (!result.Any())
                return NotFound();
            else return result.First();
        }
    }
}

