using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtPlatform.Models
{
    public class UserRating : Rating
    {
        public UserRating(int idRating, decimal ratingValue, string description, Post post, User user)
        {
            IdRating = idRating;
            RatingValue = ratingValue;
            Description = description;
            RelatedPost = post;
            RelatedUser = user;
        }
    }
}
