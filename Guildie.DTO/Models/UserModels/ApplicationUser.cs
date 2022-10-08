using Microsoft.AspNetCore.Identity;

namespace Guild.DTO.Models.UserModels
{
    public class ApplicationUser : IdentityUser
    {
        public string UserId { get; set; }
    }
}