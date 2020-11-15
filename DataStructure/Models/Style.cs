using DataStructure.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataStructure.Models
{
    public class Style : BaseModel
    {
        [Required]
        public string StyleName { get; set; }
        public List<Performer> Performers { get; set; }


    }
}