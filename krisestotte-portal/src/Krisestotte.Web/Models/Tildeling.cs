namespace Krisestotte.Web.Models;

public class Tildeling
{
    public int Id { get; set; }
    public int BehovId { get; set; }
    public Behov? Behov { get; set; }
    public int RessursId { get; set; }
    public Ressurs? Ressurs { get; set; }
    public string TildeltAvUserId { get; set; } = string.Empty;
    public ApplicationUser? TildeltAvUser { get; set; }
    public DateTime TildeltDato { get; set; } = DateTime.UtcNow;
    public string? Kommentar { get; set; }
}