using ClientDirectory.Application.Address.Commands;
using ClientDirectory.Application.Address.Dtos;
using ClientDirectory.Application.Address.Queries;
using Microsoft.AspNetCore.Mvc;

namespace ClientDirectory.Api.Controllers
{
    public class StateController : BaseController<BaseStateCommand, StateDto>
    {
        [HttpGet("Country/{countryId}")]
        public async Task<IActionResult> GetStatesByCountry(int countryId)
        {
            try
            {
                var query = new GetStatesByCountryQuery
                {
                    CountryId = countryId
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
