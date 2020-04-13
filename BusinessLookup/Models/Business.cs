using System.ComponentModel.DataAnnotations;

namespace BusinessLookup.Models
{
    public class Business
    {
        public int BusinessId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(200)]
        public string Description { get; set; }
        [Required]
        [StringLength(4)]
        public string Established { get; set; }
        [Required]
        [StringLength(50)]
        public string Owner { get; set; }
    }
}