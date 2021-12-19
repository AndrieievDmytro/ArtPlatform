using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtPlatform.Models
{
    public class Purchase
    {
        [Required]
        [Key]
        public int IdPurchase { get; set; }
        [Required]
        [Range(0, Int64.MaxValue)]
        public decimal Price { get; set; }
        [Required]
        public string State { get; set; }
        public List<ArtWork> PurchasedArtworks { get; set; }
        [Required]
        public User Buyer { get; set; }
        public Purchase(int idPurchase, decimal price, string state, List<ArtWork> purchasedArtworks, User buyer){
            IdPurchase = idPurchase;
            Price = price;
            State = state;
            PurchasedArtworks = purchasedArtworks;
            Buyer = buyer;            
        }
        public void CommitTransaction(){

        }
        //Function ChangeState() I did not added because it is just setter
    }
}
