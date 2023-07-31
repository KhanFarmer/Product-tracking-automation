using Entities.Abstract;

namespace Entities.Concrete
{
    public class Category : IEntitiy
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
