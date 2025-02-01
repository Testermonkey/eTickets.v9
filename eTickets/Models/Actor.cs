using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor
    {

        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture Url")]
        public String ProfilePictureURL { get; set; } = string.Empty;
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = string.Empty;
        [Display(Name = "Biography")]
        public string Bio { get; set; } = string.Empty;

        //Relationships
        public List<Actor_Movie>? Actors_Movies { get; set; }
    }
}
