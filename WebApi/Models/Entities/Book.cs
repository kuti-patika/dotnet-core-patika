using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models.Entities;

public class Book
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? Title { get; set; }
    public int GenreId { get; set; }
    public virtual Genre? Genre { get; set; }
    public int PageCount { get; set; }
    public DateTime PublishedDate { get; set; }
    public int AuthorId { get; set; }
    public virtual Author? Author { get; set; }
}
