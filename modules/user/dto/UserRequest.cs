using System.ComponentModel.DataAnnotations;

public class UserRequest
{
    [Required(ErrorMessage = "The Name is required.")]
    public string Name { get; set; }
}