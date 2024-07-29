using System.ComponentModel.DataAnnotations;

namespace KubTechChallange.Frontend.Models.Api;

public class BasketForCreation
{
    [Required]
    public Guid UserId { get; set; }
}
