using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Etickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string logo { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
