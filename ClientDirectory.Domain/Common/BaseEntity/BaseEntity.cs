using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDirectory.Domain.Common.BaseEntity
{
    public interface IBase
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }
    }
    public class BaseEntity : IBase
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }
    }
}
