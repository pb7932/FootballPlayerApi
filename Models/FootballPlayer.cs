using System.ComponentModel.DataAnnotations;

namespace FootballPlayerApi.Models
{
    public class FootballPlayer
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string lastname { get; set; }

        [Required]
        [Range(1, 99, ErrorMessage = "Value for {0} msut be between {1} and {2}.")]
        public int shirtNumber { get; set; }

        [Required]
        [Range(1, 99, ErrorMessage = "Value for {0} msut be between {1} and {2}.")]
        public int speed { get; set; }

        [Required]
        [Range(1, 99, ErrorMessage = "Value for {0} msut be between {1} and {2}.")]
        public int skill { get; set; }
    }
}