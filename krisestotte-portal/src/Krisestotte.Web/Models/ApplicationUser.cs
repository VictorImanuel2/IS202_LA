using Krisestotte.Web.Models.Enums;
using Microsoft.AspNetCore.Identity;

namespace Krisestotte.Web.Models;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; } = string.Empty;
    public string? OrganisasjonNavn { get; set; }
    public OffentligAktorType? OffentligAktorType { get; set; }
    public RessursleverandorType? RessursleverandorType { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}