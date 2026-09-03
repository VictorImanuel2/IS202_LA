namespace Krisestotte.Web.Models.Enums;

public enum OffentligAktorType
{
    Stat, Kommune, Politi, Brann, Helse, Sivilforsvaret, ForsvaretHeimevernet
}

public enum RessursleverandorType
{
    Privatperson, Bedrift, Bonde, Entreprenor, FrivilligOrganisasjon, Droneoperator
}

public enum TypeBehov
{
    Transport, Droneobservasjon, StromAggregat, Snorydding, SandGrus,
    Maskiner, Evakuering, Samband, Mannskap, Lokaler, Annet
}

public enum TypeRessurs
{
    Drone, Atv, Traktor, Gravemaskin, Hjullaster, Skogsmaskin, Snoskuter,
    Lastebil, SandGrus, Aggregat, Lokaler, Sambandsutstyr, Bat, Mannskap, Annet
}

public enum Prioritet
{
    Lav, Middels, Hoy, Akutt
}

public enum StatusBehov
{
    Ny, Vurderes, Tildelt, Lost
}

public enum StatusRessurs
{
    Tilgjengelig, Reservert, Tildelt, Utilgjengelig
}