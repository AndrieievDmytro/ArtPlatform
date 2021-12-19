using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtPlatform.Models
{
    public class Artist : User
    {
        public int NumberOfPosts { get; set; }

        public List<Promotion> BoughtPromotions { get; set; }

        public List<ArtWork> AddedArtWorks { get; set; }

        public List<Post> Posts { get; set; }

        public Artist()
        {

        }

        public Artist(int idUser, string nickname, string firstName, string lastName, string bioDesc, string email, string password, DateTime regDate) : base(idUser, nickname, firstName, lastName, bioDesc, email, password, regDate)
        {
            BoughtPromotions = new List<Promotion>();
            AddedArtWorks = new List<ArtWork>();
            Posts = new List<Post>();
            NumberOfPosts = 0;
        }

        public void EditArtistProfile()
        {

        }
    }
}
