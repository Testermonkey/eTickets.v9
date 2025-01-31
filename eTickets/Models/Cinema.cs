using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        private List<Movie> movies = new List<Movie>();

        [Key]
        public int Id { get; set; }
        public string Logo { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        //Relationships
        public List<Movie> Movies { get => movies; set => movies = value; }
    }
}
