using DataStructure.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Models
{
    public class PerformerSong : BaseModel
    {
        public int PerformerID { get; set; }
        public Performer Performer { get; set; }
        public int SongID { get; set; }
        public Song Song { get; set; }
    }
}