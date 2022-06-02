using DataAnnotationLocalization.Resources;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationLocalization.WebUI.Models
{
    public class Product
    {
        [Required(ErrorMessageResourceType =typeof(DataAnnotationResource),ErrorMessageResourceName =nameof(DataAnnotationResource.Required))]
        [Display(Name="Id")]
        public int Id { get; set; }
        [Required(ErrorMessageResourceType = typeof(DataAnnotationResource), ErrorMessageResourceName = nameof(DataAnnotationResource.Required))]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessageResourceType = typeof(DataAnnotationResource), ErrorMessageResourceName = nameof(DataAnnotationResource.Required))]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
    }
}
