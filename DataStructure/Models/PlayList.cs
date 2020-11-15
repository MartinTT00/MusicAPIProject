using DataStructure.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Models
{
    public class PlayList : BaseModel
    {
        public string PlayListName { get; set; }
        public User User { get; set; }
        public List<Song> Songs { get; set; }

    }
}