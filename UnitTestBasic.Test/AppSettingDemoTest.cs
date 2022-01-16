using System;
using System.Collections.Generic;
using System.Text;
using NSubstitute;
using NUnit.Framework;

namespace UnitTestBasic.Test
{
    public class AppSettingDemoTest
    {
        [Test]
        public void GetDisplayName_When_Toggle_Disabled_Should_Return_Disable()
        {
            // Use Substitute to create a fake appSettingService object
            var appSettingService = Substitute.For<IAppSettingsService>();
            // when IsEnabled called with any string will return false
            appSettingService.IsEnabled(Arg.Any<string>()).Returns(false);
            var appSetting = new AppSettingDemo(appSettingService);

            var result = appSetting.GetDisplayName();

            Assert.AreEqual("ToggleDisabled", result);
        }
    }
}
