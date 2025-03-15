namespace NetFrameworkCompat.Settings;

public class Settings : ApplicationSettingsBase
{
    private Settings(bool bmpEnableExtensions, bool upgradeRequired, int jpegQuality)
    {
        BmpEnableExtensions = bmpEnableExtensions;
        UpgradeRequired = upgradeRequired;
        JPEGQuality = jpegQuality;
    }

    public bool BmpEnableExtensions { get; set; }
    public bool UpgradeRequired { get; set; }
    public int JPEGQuality { get; set; }

    private static readonly Settings defaultSettings = new(true, true, 100);

    public static Settings Default => defaultSettings;

    public void Upgrade()
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        throw new NotImplementedException();
    }
}