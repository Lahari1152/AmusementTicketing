using BusinessLayer.Services;
using DataLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServiceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttractionController : ControllerBase
    {
        public AttractionService _attractionService;

        public AttractionController(AttractionService attractionService)
        {
            _attractionService = attractionService;
        }
        [HttpGet]
        public IActionResult GetAllAttractions()
        {
            var allAttractions = _attractionService.GetAllAttractions();
            return Ok(allAttractions);
        }

        [HttpGet("{id}")]
        public IActionResult GetAttractionById(int id)
        {
            var attraction = _attractionService.GetAttractionById();
            return Ok(attraction);
        }

        [HttpPost]
        public IActionResult AddAttraction([FromBody]Attraction attraction)
        {
            _attractionService.AddAttraction(attraction);
            return Ok ();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAttractionById(int id, [FromBody]Attraction attraction)
        {
            var updateAttraction = _attractionService.UpdateAttractionById(id, attraction);
            return Ok(updateAttraction);
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteAttractionById(int id) 
        { 
            _attractionService.DeleteAttractionById(id);
            return Ok();
        }
    }
}
