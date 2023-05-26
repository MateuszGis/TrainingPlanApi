using System.ComponentModel.DataAnnotations;

namespace TrainingApi.Models
{
    public class BodyPartType
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(20)]
        public string Name { get; set; } = String.Empty;
    }
}
