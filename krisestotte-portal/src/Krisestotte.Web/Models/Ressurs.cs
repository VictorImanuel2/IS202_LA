using Krisestotte.Web.Models.Enums;

namespace Krisestotte.Web.Models;

public class Ressurs
{
    public int Id { get; set; }
    public string OpprettetAvUserId { get; set; } = string.Empty;
    public ApplicationUser? OpprettetAvUser { get; set; }
    public string Tittel { get; set; } = string.Empty;
    public string Beskrivelse { get; set; } = string.Empty;
    public TypeRessurs TypeRessurs { get; set; }
    public string GeografiskOmrade { get; set; } = string.Empty;
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    public DateTime? TilgjengeligFra { get; set; }
    public DateTime? TilgjengeligTil { get; set; }
    public string Kontaktpunkt { get; set; } = string.Empty;
    public StatusRessurs Status { get; set; } = StatusRessurs.Tilgjengelig;
    public DateTime OpprettetDato { get; set; } = DateTime.UtcNow;
    public DateTime OppdatertDato { get; set; } = DateTime.UtcNow;
}