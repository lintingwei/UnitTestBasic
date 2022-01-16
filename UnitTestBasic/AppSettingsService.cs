using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestBasic
{
    public class AppSettingsService : IAppSettingsService
    {
        public bool IsEnabled(string settingId)
        {
            // Actual situation might get the setting from Db
            return true;
        }
    }
}
