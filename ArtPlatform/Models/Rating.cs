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
        public decimal RatingValue {
            get { return _ratingValue; }
            set {
                if (0 <= value && value <= 5)
                    _ratingValue = value;
                else
                    throw new ArgumentException("rating is not between 1 and 5");
            } 
        }
        private decimal _ratingValue;
        [MaxLength(300)]
        public string Description{ get; set; }
        [Required]
        public User RelatedUser { get; set; }
        [Required]
        public Post RelatedPost  { get; set; }
    }
}
