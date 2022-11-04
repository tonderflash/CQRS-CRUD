using ClientDirectory.Domain.Common.BaseEntity;

namespace ClientDirectory.Application.Entities.Address
{
    public class Country : BaseEntity
    {
        public Country()
        {
            States = new HashSet<State>();
        }
        public string Name { get; set; }
        public ICollection<State> States { get; set; }
    }
}
