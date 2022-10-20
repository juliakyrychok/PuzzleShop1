using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleShop.Core
{
    public class Puzzle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Articul { get; set; }
        public double? Price { get; set; }
        public int? Count { get; set; }
        public string? VideoURL { get; set; }
        public string? ImgPath { get; set; }
        public Country? Country { get; set; }
        public Brand? Brand { get; set; }
        public virtual ICollection<OrderItem>? OrderItems { get; set; }
    }
}
