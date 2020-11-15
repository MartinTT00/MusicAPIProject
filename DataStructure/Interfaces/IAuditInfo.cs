using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Interfaces
{
    public interface IAuditInfo
    {
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

    }
}