namespace NetFrameworkCompat.Settings;

public class ApplicationSettingsBase
{
    public object this[string name]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
}