using System.ComponentModel.DataAnnotations;

namespace MVCTest.Models
{
    public class Product
    {
        [Range(3, 6)]
        public int Id { get; set; }
        public string Name { get; set; }

        [Range(100, 3000)]
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required]
        public string Category { get; set; }
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
    }
}
