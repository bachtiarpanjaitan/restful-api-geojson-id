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
        public IEnumerable<Adm1List> Get()
        {
            return _context.Adm1.Select(d => new Adm1List
            {
                code = d.code,
                name = d.name,
                id = d.id
            }).ToArray();

            
        }
    }
}

