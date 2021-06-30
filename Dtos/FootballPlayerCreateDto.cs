using System.ComponentModel.DataAnnotations;
using FootBallPlayerApi.Validators;
using Microsoft.AspNetCore.Mvc;

namespace FootballPlayerApi.Models
{
    public class FootballPlayerCreateDto
    {
        [Required]
        [Remote(action: "VeirfyLastname", controller: "FootballPlayersValidation")]
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