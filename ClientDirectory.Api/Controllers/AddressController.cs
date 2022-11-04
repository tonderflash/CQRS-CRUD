using ClientDirectory.Application.Client.Commands;
using ClientDirectory.Application.Client.Dtos;
using ClientDirectory.Application.Client.Queries;
using Microsoft.AspNetCore.Mvc;

namespace ClientDirectory.Api.Controllers
{
    public class AddressController : BaseController<BaseClientAddressCommand, AddressDto>
    {
        [HttpGet("Client/{clientId}")]
        public async Task<IActionResult> GetClientAddresses(int skip, int take, int clientId)
        {
            try
            {
                var query = new GetClientAddressesQuery
                {
                    Take = take,
                    Skip = skip,
                    ClientId = clientId
                };
                return Ok(await Mediator.Send(query));
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message });
            }
        }

        [HttpGet("{addressId}")]
        public async Task<IActionResult> GetClientAddress(int addressId)
        {
            try
            {
                var query = new GetClientAddressQuery
                {
                    AddressId = addressId
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
