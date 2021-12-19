using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtPlatform.Models {

    public class Post {

        [Required]
        [Key]
        public int IdPost { get; set; }
        public string Description { get; set; }
        public List<Comment> Comments { get; set; }

        public Post(int idPost) {
            IdPost = idPost;
        }

        public Post(int idPost, string description) {
            IdPost = idPost;
            Description = description;
        }

        public void AddReview() { 
            
        }

        public void RateArtwork(Rating rating, Comment comment) {

        }

        public void Comment(Comment comment) {

        }

        public void DeletePost() {

        }

        public void EditPost() {

        }

        public void AddToFavorites() {

        }

    }

}
