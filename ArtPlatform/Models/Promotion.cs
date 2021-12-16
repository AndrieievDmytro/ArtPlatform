using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtPlatform.Models
{
    public class Promotion
    {
        [Required]
        [Key]
        public int IdPromotion { get; set; }
        [Required]
        public string PromotionType { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Artist Artist { get; set; }

        public Promotion(int idPromotion, string promotionType, DateTime startDate, DateTime endDate, Artist artist){
            IdPromotion = idPromotion;
            PromotionType = promotionType;
            StartDate = startDate;
            EndDate = endDate;
            Artist = artist;
        }
        public void BuyPromotion(){

        }
    }
}
