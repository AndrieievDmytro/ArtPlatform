using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtPlatform.Models {

    public class Favorite {

        [Key]
        [Required]
        public User User { get; set; }
        [Key]
        [Required]
        public Post Post { get; set; }

        public Favorite(User user, Post post) {
            User = user;
            Post = post;
        }

        public void RemoveFromFavorites() { 
            
        }

    }

}
