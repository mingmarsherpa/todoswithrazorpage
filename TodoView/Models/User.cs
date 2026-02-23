using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TodoView.Models;

public class User:IdentityUser
{
    [Required]
    [StringLength(10,ErrorMessage = "then minimum length must be 10 characters")]
    public string FirstName { get; set; }=string.Empty;
    [Required]
    [StringLength(10,ErrorMessage = "then minimum length must be 10 characters")]
    public string LastName { get; set; }=string.Empty;
    [Required]
    [StringLength(20,ErrorMessage = "then minimum length must be 20 characters")]
    public string Address { get; set; }=string.Empty;
    public DateTime CreatedAt { get; set; }
    public List<Todo> TodoItems { get; set; } = new();
}