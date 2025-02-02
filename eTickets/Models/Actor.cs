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
        [Required(ErrorMessage = "Profile Picture URL is required")]
        [StringLength(500, ErrorMessage = "URL must be less then 500 letters")]
        public String ProfilePictureURL { get; set; } = string.Empty;
        [Required(ErrorMessage = "Full Name is required")]
        [Display(Name = "Full Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be 3-50 letters")]
        public string FullName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Biography is required")]
        [Display(Name = "Biography")]
        [StringLength(500, MinimumLength =3, ErrorMessage = "Bio must be 3-500 Letters")]
        public string Bio { get; set; } = string.Empty;

        //Relationships
        public List<Actor_Movie>? Actors_Movies { get; set; }
    }
}
