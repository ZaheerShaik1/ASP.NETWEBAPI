using Microsoft.AspNetCore.Mvc;
using WebApplicationDemo.Model;
using WebApplicationDemo.Model.Repositories;

namespace WebApplicationDemo.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController : ControllerBase
    {
        
        [HttpGet]
        //[Route ("/shirts")]
        public string GetShirts()
        {
            return "Reading all the shirts";
        }

        //[HttpGet("{id}")]
        ////[Route ("/shirts/{id}")]
        //public string GetShirtById(int id,[FromQuery]string color)
        //{
        //    return $"Reading shirt : {id} color: {color}";
        //}
        //[HttpGet("{id}")]
        //public string GetShirtById(int id, [FromHeader(Name ="color")]string color)
        //{
        //    return $"Reading shirt :{id} , color :{color}";
        //}
        [HttpGet("{id}")]
        public IActionResult GetShirtById(int id)
        {
            if (id <= 0) return BadRequest();
            var shirt = ShirtRepository.GetShirtById(id);
            if(shirt==null)
                return NotFound();
            return Ok(shirt);

            //return shirts.First(x => x.ShirtId == id);
        }

        [HttpPost]
        //[Route ("/shirts")]
        public string CreateShirt([FromBody] Shirt shirt)
        {
            return "Creating shirt";
        }

        [HttpPut("{id}")]
        //[Route ("/shirts/{id}")]
        public string UpdateShirt(int id)
        {
            return $"Updating shirt :{id}";

        }


        [HttpDelete("{id}")]
        //[Route ("/shirts/{id}")]
        public string DeleteShirt(int id)
        {
            return $"Deleting shirt : {id}";
        }
    }
}
