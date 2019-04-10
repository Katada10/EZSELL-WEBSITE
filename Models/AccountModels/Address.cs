using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Street Address Is Required"), MaxLength(30)]
        public string StreetNumberName { get; set; }

        [MaxLength(30)]
        public string PostalCode { get; set; }

        [Required, MaxLength(30)]
        public string City { get; set; }

        [Required, MaxLength(30)]
        public string Province { get; set; }

        [Required, MaxLength(30)]
        public string Country { get; set; }
    }
}