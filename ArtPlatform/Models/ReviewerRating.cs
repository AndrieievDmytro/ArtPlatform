using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtPlatform.Models
{
    class ReviewerRating : Rating
    {
        public ReviewerRating(int idRating, decimal ratingValue, string description, Post post, User user)
        {
            IdRating = idRating;
            RatingValue = ratingValue;
            Description = description;
            RelatedPost = post;
            RelatedUser = user;
        }
    }
}
