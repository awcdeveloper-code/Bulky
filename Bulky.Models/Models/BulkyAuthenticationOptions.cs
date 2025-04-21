using Microsoft.AspNetCore.Authentication;

namespace Bulky.Models.Models
{
    public class BulkyAuthenticationOptions : AuthenticationSchemeOptions
    {
        public string? BulkyOption { get; set; }
    }
}
