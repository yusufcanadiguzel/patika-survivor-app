
namespace WebApi.Models
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string? Name { get; set; }
        public List<Competitor>? Competitors { get; set; }
    }
}
