using System;
using System.ComponentModel.DataAnnotations;

namespace vega.Models.Entities
{
    public class Model : BaseEntity
    {
        [Required]
        [StringLength(255)]             
        public string Name { get; set; }
    }
}