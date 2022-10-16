namespace Company.Plugin;

[ApiVersion(2, 1)]
public partial class PluginName
{
    /// <inheritdoc />
    public override void Initialize()
    {
    }

    /// <inheritdoc />
    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
        if (disposing)
        {
            // dispose managed resources
        }

        // dispose unmanaged resources
    }
}
