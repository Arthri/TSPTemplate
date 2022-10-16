using System.Reflection;

namespace Company.Plugin;

public partial class PluginName : TerrariaPlugin
{
    /// <inheritdoc />
    public override string Name { get; } = typeof(PluginName).Assembly.GetCustomAttribute<AssemblyTitleAttribute>()?.Title ?? "Plugin";

    /// <inheritdoc />
    public override string Description { get; } = typeof(PluginName).Assembly.GetCustomAttribute<AssemblyDescriptionAttribute>()?.Description ?? "";

    /// <inheritdoc />
    public override Version Version { get; } = typeof(PluginName).Assembly.GetName()?.Version ?? new Version(0, 0);

    /// <inheritdoc />
    public override string Author { get; } = typeof(PluginName).Assembly.GetCustomAttribute<AssemblyCompanyAttribute>()?.Company ?? "Anonymous";

    /// <summary>
    /// The constructor for the plugin. Initialization should be done in <see cref="Initialize()" /> instead.
    /// </summary>
    public PluginName(Main game) : base(game)
    {
    }
}
