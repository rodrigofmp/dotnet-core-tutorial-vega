using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace vega.Models.Entities
{
    public class Make : BaseEntity
    {
        [Required]
        [StringLength(255)]             
        public string Name { get; set; }

        public List<Model> Models { get; set; }
    }
}