using System.ComponentModel.DataAnnotations;

namespace DesafioBlazor.Models;

public class Todo {

    [Required]
    [StringLength(30, ErrorMessage = "Identifier too long (16 character limit).")]
    public string Title { get; set; } = null!;

    [Required]
    public string Text { get; set; } = null!;

    public string HexColor { get; set; } = null!;
}