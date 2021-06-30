using System.ComponentModel.DataAnnotations;
using FootballPlayerApi.Models;

namespace FootBallPlayerApi.Validators
{
    public class RetiredShirtNumberAttribute : ValidationAttribute
    {
        public RetiredShirtNumberAttribute(int number)
        {
            Number = number;
        }

        public int Number { get; }

        public string GetErrorMessage() =>
            $"Shirt number {Number} is retired. Pick a different number.";
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ((int)value == Number)
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }
    }
}