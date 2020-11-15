using DataStructure.Abstractions;
using DataStructure.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataStructure.Models
{
    public class User : BaseModel
    {
        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string UserName { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 6)]
        public string Password { get; set; }

        public List<Favourite> Favourites { get; set; }
        public string StyleId { get; set; }
        public List<PlayList> PlayLists { get; set; }
    }
}