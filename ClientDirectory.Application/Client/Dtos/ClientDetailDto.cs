using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClientDirectory.Application.Client.Dtos
{
    public class ClientDetailDto
    {
        public ClientDetailDto() => Age = BirthDateValue.Year - DateTime.Now.Year;
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        [JsonIgnore]
        public DateTimeOffset BirthDateValue { get; set; }
        public int Age { get; }
        public string Profession { get; set; }
        public string Dni { get; set; }
        public List<AddressDto> Addresses { get; set; }
    }
}
