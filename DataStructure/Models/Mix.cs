﻿using DataStructure.Abstractions;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Models
{
    public class Mix : BaseModel
    {
        public string MixName { get; set; }
        public List<Performer> Performers { get; set; }

    }
}