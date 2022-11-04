using ClientDirectory.Application.Enums;
using MediatR;
using System.Text.Json.Serialization;

namespace ClientDirectory.Application.GenericHandler
{
    public class BaseCommand<TResponse> : IRequest<TResponse> where TResponse : class
    {
        [JsonIgnore]
        public virtual ActionTypes ActionType { get; set; }
        public int Id { get; set; }
    }
}
