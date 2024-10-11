
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Competitor : IEntity
    {
        public Competitor(string firstName, string lastName, int categoryId)
        {
            CreatedDate = DateTime.UtcNow;
            ModifiedDate = DateTime.UtcNow;
            IsDeleted = false;
            FirstName = firstName;
            LastName = lastName;
            CategoryId = categoryId;
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category? Category { get; set; }
    }
}
