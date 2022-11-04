using ClientDirectory.Domain.Common.BaseEntity;

namespace ClientDirectory.Application.Entities.Address
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }
    }
}
