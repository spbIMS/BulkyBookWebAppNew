using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Range(1,10000)]
        public double ListPrice { get; set; } //List price of the book
        [Required]
        [Range(1, 10000)]
        public double Price { get; set; } //Final price for one single book
        [Required]
        [Range(1, 10000)]
        public double Price50 { get; set; } //Bulk order price for 50 books
        [Required]
        [Range(1, 10000)]
        public double Price100 { get; set; } //Bulk order price for 100 books
        public string ImageUrl { get; set; }

        [Required]
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; } //Marked as a FK using Data Annotations
        public Category Category { get; set; }

        [Required]
        public int CoverTypeId { get; set; } //EF core will automatically mark it as a FK
        public CoverType CoverType { get; set; }

    }
}
