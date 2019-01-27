using System;
using System.ComponentModel.DataAnnotations;

namespace vega.Models.Entities
{
    public partial class Feature : BaseEntity
    {
        [Required]
        [StringLength(255)]        
        public string Name { get; set; }
    }
}