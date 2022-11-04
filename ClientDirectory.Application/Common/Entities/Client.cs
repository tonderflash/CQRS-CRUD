using ClientDirectory.Domain.Common.BaseEntity;

namespace ClientDirectory.Application.Entities
{
    public class Client : BaseEntity
    {
        public Client()
        {
            Addresses = new HashSet<ClientAddress>();
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public string Dni { get; set; }
        public string Profession { get; set; }
        public virtual ICollection<ClientAddress> Addresses { get; set; }
    }
}
