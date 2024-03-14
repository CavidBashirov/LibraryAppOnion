
using Domain.Common;

namespace Domain.Models
{
    public class Library : BaseEntity
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Phone { get; set; }
    }
}
