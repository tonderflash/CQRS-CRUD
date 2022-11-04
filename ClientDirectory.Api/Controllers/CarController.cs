using ClientDirectory.Application.Cars.Commands;
using ClientDirectory.Application.Cars.Dtos;
using ClientDirectory.Application.Cars.Queries;
using Microsoft.AspNetCore.Mvc;

namespace ClientDirectory.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : BaseController<BaseCarCommand, CarDto>
    {

        [HttpGet("Car/{carId}")]
        public async Task<IActionResult> GetCarById(int carId)
        {
            try
            {
                var query = new GetCarByIdQuery
                {
                    Id = carId
                };
                return Ok(await Mediator.Send(query));
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetCars()
        {
            try
            {
                var query = new GetCarsQuery();
                return Ok(await Mediator.Send(query));
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message });
            }
        }
    }
}
