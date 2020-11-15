using DataStructure.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataStructure.Models
{
    public class Performer : BaseModel
    {
        [Required]
        public string PerformerName { get; set; }
        [Required]
        public int CountOfAlbums { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public Style Style { get; set; }
        public Favourite Favourites { get; set; }
        public List<PerformerSong> PerformersSongs { get; set; }
        public List<BeatMaker> Beater { get; set; }
        public List<Mix> Mixes { get; set; }
    }
}