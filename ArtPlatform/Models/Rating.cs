using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtPlatform.Models
{
    public abstract class Rating
    {
        [Required]
        [Key]
        public int IdRating { get; set; }
        [Required]
        public decimal RatingValue { get; set; }
        [MaxLength(300)]
        public string Description{ get; set; }
        [Required]
        public User RelatedUser { get; set; }
        [Required]
        public Post RelatedPost  { get; set; }
    }
}
