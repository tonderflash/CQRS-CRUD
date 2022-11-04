using ClientDirectory.Application.Entities.Address;
using ClientDirectory.Application.Enums;
using ClientDirectory.Domain.Common.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDirectory.Application.Entities
{
    public class ClientAddress : BaseEntity
    {
        public string Label { get; set; }
        public string Address { get; set; }
        public AddressesTypes AddressType { get; set; }
        public int ClientId { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public virtual Client Client { get; set; }
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
    }
}
