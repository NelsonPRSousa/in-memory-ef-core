using System.Collections.Generic;
using System.Linq;
using InMemoryEFCore.DataContext;
using InMemoryEFCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace InMemoryEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PointOfInterestController : ControllerBase
    {
        private CityGuideDBContext _context;

        public PointOfInterestController(CityGuideDBContext context)
        {
            _context = context;
        }

        // GET api/pointOfInterest
        [HttpGet]
        public ActionResult<IEnumerable<PointOfInterest>> Get()
        {
            return _context.PointsOfInterest;
        }

        // GET api/pointOfInterest/5
        [HttpGet("{id}")]
        public ActionResult<PointOfInterest> Get(int id)
        {
            return _context.PointsOfInterest.FirstOrDefault(poinOfInterestt => poinOfInterestt.Id == id);
        }
    }
}