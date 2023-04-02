using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Etickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Cinema Logo")]
        public string logo { get; set; }
        [Display(Name = "Cinema Name")]
        public string name { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
