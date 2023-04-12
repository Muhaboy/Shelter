using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]

        public string navn { get; set; }
        public string cvr_navn { get; set; }
        public int antal_pl { get; set; }
    }
}
