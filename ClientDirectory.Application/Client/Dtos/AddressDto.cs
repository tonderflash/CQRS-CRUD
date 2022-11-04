using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDirectory.Application.Client.Dtos
{
    public class AddressDto
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string AddressTypeLabel { get; set; }
        public int AddressType { get; set; }
        public string Label { get; set; }
    }
}
