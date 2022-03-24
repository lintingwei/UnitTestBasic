namespace UnitTestBasic
{
    public interface IAppSettingsService
    {
        bool IsEnabled(string settingId);
        int GetIntegerValue(string settingId);
    }
}