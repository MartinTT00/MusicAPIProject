using DataStructure.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace DataStructure.Models
{
    public class BeatMaker : BaseModel
    {
        [Required]
        public string BeatMakerName { get; set; }
        public List<Performer> Performers { get; set; }
    }
}
