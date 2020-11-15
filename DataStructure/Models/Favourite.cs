using DataStructure.Abstractions;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Models
{
    public class Favourite : BaseModel
    {
        public List<Style> Styles { get; set; }
        public List<Performer> Performers { get; set; }
        public User User { get; set; }
    }
}