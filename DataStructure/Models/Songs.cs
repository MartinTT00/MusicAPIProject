using DataStructure.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataStructure.Models
{
    public class Songs : BaseModel
    {
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string SongName { get; set; }
        public int SongsId { get; set; }
        public List<Performer> Performers { get; set; }
        public List<PlayLists> PlayLists { get; set; }
    }
}
