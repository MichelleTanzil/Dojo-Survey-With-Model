using System.ComponentModel.DataAnnotations;
using dojo_survey_with_model.Models;
namespace dojo_survey_with_model
{
    public class RequiredIfAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
      var survey = (Survey)validationContext.ObjectInstance;
      if (survey.Comment == null || survey.Comment.Length >= 20)
      {
        return ValidationResult.Success;
      }
      return new ValidationResult("Comment must be at least 20 characters long.");
    }

  }
}