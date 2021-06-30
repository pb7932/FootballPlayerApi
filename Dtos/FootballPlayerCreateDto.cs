using System.ComponentModel.DataAnnotations;
using FootBallPlayerApi.Validators;

namespace FootballPlayerApi.Models
{
    public class FootballPlayerCreateDto
    {
        [Required]
        public string lastname { get; set; }

        [Required]
        [Range(1, 99, ErrorMessage = "Value for {0} msut be between {1} and {2}.")]
        [RetiredShirtNumber(22)]
        public int shirtNumber { get; set; }

        [Required]
        [Range(1, 99, ErrorMessage = "Value for {0} msut be between {1} and {2}.")]
        public int speed { get; set; }

        [Required]
        [Range(1, 99, ErrorMessage = "Value for {0} msut be between {1} and {2}.")]
        public int skill { get; set; }
    }
}