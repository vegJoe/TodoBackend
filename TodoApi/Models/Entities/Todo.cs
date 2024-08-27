using NuGet.Packaging.Signing;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models.Entities
{
    public class Todo
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string Author { get; set; }

        public bool IsComplete { get; set; }

        public string? Timestamp { get; set; }

        public string? TodoText { get; set; }
    }
}
