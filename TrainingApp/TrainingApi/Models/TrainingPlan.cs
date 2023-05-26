using System.ComponentModel.DataAnnotations;

namespace TrainingApi.Models
{
    public class TrainingPlan
    {
        public int Id { get; set; }
        public int BodyPartTypeId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [StringLength(100)]
        public string? Description { get; set; } = string.Empty;
        [Required(ErrorMessage = "Amount of series is required")]
        public int Series { get; set; }
        [Required(ErrorMessage = "Amount of reps is required")]
        public int Reps { get; set; }
        public int? TimeBetweenSeries { get; set; }
        public BodyPartType? BodyPartType { get; set; }

    }
}
