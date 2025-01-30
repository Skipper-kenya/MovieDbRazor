using System.ComponentModel.DataAnnotations;

namespace MovieDbRazor.Model
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; } //nullable
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
    }
}
