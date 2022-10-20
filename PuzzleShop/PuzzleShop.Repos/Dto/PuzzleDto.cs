using PuzzleShop.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleShop.Repos.Dto
{
    public class PuzzleDto
    {
        public int? Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Articul { get; set; }
        public double? Price { get; set; }
        public int? Count { get; set; }
        public string? VideoURL { get; set; }
        public string? ImgPath { get; set; }
        public string? Country { get; set; }
        public string? Brand { get; set; }
    }
}
