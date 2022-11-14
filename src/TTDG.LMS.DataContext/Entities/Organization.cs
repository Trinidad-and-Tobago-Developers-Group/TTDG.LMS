#nullable disable

using System.ComponentModel.DataAnnotations;

namespace TTDG.LMS.DataContext
{
    public class Organization
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [MaxLength(100)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [MaxLength(500)]
        [Display(Name = "Tag Line")]
        public string TagLine { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [MaxLength(250)]
        [Display(Name = "Banner Image")]
        public string BannerImage { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [MaxLength(100)]
        [Display(Name = "Contact Email")]
        public string ContactEmail { get; set; }
    }
}
