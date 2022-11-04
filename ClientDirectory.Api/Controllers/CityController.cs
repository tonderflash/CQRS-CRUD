using ClientDirectory.Application.Address.Commands;
using ClientDirectory.Application.Address.Dtos;
using ClientDirectory.Application.Address.Queries;
using Microsoft.AspNetCore.Mvc;

namespace ClientDirectory.Api.Controllers
{
    public class CityController : BaseController<BaseCityCommand, CityDto>
    {
        [HttpGet("State/{stateId}")]
        public async Task<IActionResult> GetCitiesByState(int stateId)
        {
            try
            {
                var query = new GetCitiesByStateQuery
                {
                    StateId = stateId
                };
                return Ok(await Mediator.Send(query));
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message });
            }
        }
    }
}
