using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        private List<Actor_Movie> actors_Movies = new List<Actor_Movie>();

        [Key]
        public int Id { get; set; }
        public String ProfilePictureURL { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;

        //Relationships
        public List<Actor_Movie> Actors_Movies { get => actors_Movies; set => actors_Movies = value; }
    }
}
