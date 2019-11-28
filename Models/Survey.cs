using System.ComponentModel.DataAnnotations;
namespace dojo_survey_with_model.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "Your Name:")]
        public string FullName {get; set;}
        
        [Required]
        [Display(Name = "Dojo Location:")]
        public string Location {get; set;}

        [Required]
        [Display(Name = "Favorite Language: ")]
        public string Language {get; set;}

        [RequiredIfAttribute]
        [Display(Name = "Comment (Optional):")]
        public string Comment {get; set;}
    }
}