﻿using DataStructure.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataStructure.Models
{
    public class Song : BaseModel
    {
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string SongName { get; set; }
        public int SongId { get; set; }
        public List<PerformerSong> PerformersSongs { get; set; }
        public List<PlayList> PlayLists { get; set; }
    }
}
