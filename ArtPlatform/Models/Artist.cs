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

        public void EditArtistProfile()
        {

        }
    }
}
