using System.ComponentModel.DataAnnotations;

namespace CleanArchMvcWebUI.ViewModels;

public class RegisterViewModel
{
    [Required]
    [EmailAddress]
    public string? Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = "Password don't match")]
    public string? ConfirmPassword { get; set; }
}
