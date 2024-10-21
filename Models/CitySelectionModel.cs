using System.ComponentModel.DataAnnotations;

namespace WebApplication121024_Pogoda.Models
{
    public class CitySelectionModel
    {
        [Required]
        public string City { get; set; }
    }
}
