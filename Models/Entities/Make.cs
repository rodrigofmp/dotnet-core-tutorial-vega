using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace vega.Models.Entities
{
    public class Make : BaseEntity
    {
        [Required]
        [StringLength(255)]             
        public string Name { get; set; }

        public ICollection<Model> Models { get; set; }

        public Make()
        {
            Models = new Collection<Model>();
        }
    }
}