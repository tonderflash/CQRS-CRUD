using ClientDirectory.Application.Address.Commands;
using ClientDirectory.Application.Address.Dtos;
using ClientDirectory.Application.Address.Queries;
using Microsoft.AspNetCore.Mvc;

namespace ClientDirectory.Api.Controllers
{
    public class CountryController : BaseController<BaseCountryCommand, CountryDto>
    {
        [HttpGet]
        public async Task<IActionResult> GetCountries()
        {
            try
            {
                var query = new GetCountriesQuery();
                return Ok(await Mediator.Send(query));
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message });
            }
        }
    }
}
