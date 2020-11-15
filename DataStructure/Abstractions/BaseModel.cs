using DataStructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Abstractions
{
    public abstract class BaseModel : IBaseModel<string>, IAuditInfo
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
