using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataStructure.Interfaces
{
    public interface IBaseModel<T>
    {
        [Key]
        public T Id { get; set; }
    }

}