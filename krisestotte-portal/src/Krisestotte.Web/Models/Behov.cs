using Krisestotte.Web.Models.Enums;

namespace Krisestotte.Web.Models;

public class Behov
{
    public int Id { get; set; }
    public string OpprettetAvUserId { get; set; } = string.Empty;
    public ApplicationUser? OpprettetAvUser { get; set; }
    public string Tittel { get; set; } = string.Empty;
    public string Beskrivelse { get; set; } = string.Empty;
    public TypeBehov TypeBehov { get; set; }
    public string GeografiskOmrade { get; set; } = string.Empty;
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    public DateTime? TidspunktFrist { get; set; }
    public Prioritet Prioritet { get; set; }
    public string Kontaktpunkt { get; set; } = string.Empty;
    public StatusBehov Status { get; set; } = StatusBehov.Ny;
    public DateTime OpprettetDato { get; set; } = DateTime.UtcNow;
    public DateTime OppdatertDato { get; set; } = DateTime.UtcNow;
}