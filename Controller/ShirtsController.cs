using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCoreWebApi.Controller
{
    [ApiController]
    [Route("api/[controller]")] //we can configure here directly without using 
                                // it for each methods
    public class ShirtsController : ControllerBase
    {
        [HttpGet]

        /* [Route("/Shirts")]*/ //for routing: tis line should be written on each method
        public string GetShirts()
        {
            return "Reading all the shirts";
        }

        [HttpGet("{id}")]

        //[Route("/Shirts/{id}")]
        public string GetShirtById(int id)
        {
            return $"Reading a shirt: {id}";
        }

        [HttpPost("{id}")]

        //[Route("/Shirts/{id}")]
        public string CreateShirt(int id)
        {
            return $"Creating a shirt: {id}";
        }

        [HttpPut("{id}")]

        //[Route("/Shirts/{id}")]
        public string UpdatingShirt(int id)
        {
            return $"Updating a shirt with id: {id}";
        }
        [HttpDelete("{id}")]

        //[Route("/Shirts/{id}")]
        public string DeleteShirt(int id)
        {
            return $"Deleting a shirt with id {id}";
        }




    }
}
