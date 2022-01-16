using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestBasic
{
    public class AppSettingDemo
    {
        private readonly IAppSettingsService _appSettings;

        public AppSettingDemo(IAppSettingsService appSettings)
        {
            this._appSettings = appSettings;
        }

        public string GetDisplayName()
        {
            return _appSettings.IsEnabled("IsToggleEnabled") ? "ToggleEnabled" : "ToggleDisabled";
        }
    }
}
