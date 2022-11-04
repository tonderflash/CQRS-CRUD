using ClientDirectory.Application.Client.Commands;
using ClientDirectory.Application.Client.Dtos;
using ClientDirectory.Application.Client.Queries;
using Microsoft.AspNetCore.Mvc;

namespace ClientDirectory.Api.Controllers
{
    public class ClientController : BaseController<BaseClientCommand, ClientDetailDto>
    {

        [HttpGet]
        public async Task<IActionResult> GetClients(int take, int skip)
        {
            try
            {
                var query = new GetClientsQuery
                {
                    Skip = skip,
                    Take = take
                };
                return Ok(await Mediator.Send(query));
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClient(int id)
        {
            try
            {
                var query = new GetClientQuery
                {
                    Id = id
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
