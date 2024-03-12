namespace DenemeModule;

public static class DenemeModuleDbProperties
{
    public static string DbTablePrefix { get; set; } = "DenemeModule";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "DenemeModule";
}
