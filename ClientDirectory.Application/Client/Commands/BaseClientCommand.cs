using ClientDirectory.Application.Client.Dtos;
using ClientDirectory.Application.GenericHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDirectory.Application.Client.Commands
{
    public class BaseClientCommand : BaseCommand<ClientDetailDto>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public string Dni { get; set; }
        public string Profession { get; set; }
    }
}
