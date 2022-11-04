using ClientDirectory.Application.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClientDirectory.Application.GenericHandler
{
    public class BaseCommand<TResponse> : IRequest<TResponse> where TResponse : class
    {
        [JsonIgnore]
        public virtual ActionTypes ActionType { get; set; }
        public int Id { get; set; }
    }
}
