using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtPlatform.Models
{
    public class ArtWork
    {
        [Key]
        [Required]
        public int IdArtwork { get; set; }
        [Required]
        public int IdUser { get; set; }
        public string ArtType { get; set; }
        public string Description { get; set; }
        // Photos and videos as links of type string 
        public List<string> Video { get; set; }
        public List<string> Photo { get; set; }
        // public User User { get; set; }
        public Artist Artist { get; set; }
        public List<Post> Post { get; set; }

        public ArtWork(int idArtwork, Artist artist, string artType, string description, List<string> video, List<string> photo, List<Post> post)
        {
            IdArtwork = idArtwork;
            Artist = artist;
            // IdUser = artist.IdUser;
            ArtType = artType;
            Description = description;
            Video = video;
            Photo = photo;
            Post = post;
        }

        public void BuyArtwork(){

        }

        public List<ArtWork> GetAllArtworks(){
            return null;
        }

        public void AddPost(){

        }
    }
}
