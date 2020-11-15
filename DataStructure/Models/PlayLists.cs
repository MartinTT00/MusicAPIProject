using DataStructure.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Models
{
    public class PlayLists : BaseModel
    {
        public string PlayListName { get; set; }
        public User User { get; set; }
        public List<Songs> Songs { get; set; }

    }
}