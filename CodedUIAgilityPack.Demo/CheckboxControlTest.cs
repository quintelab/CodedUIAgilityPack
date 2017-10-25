using CodedUIAgilityPack.Controls;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;

namespace CodedUIAgilityPack.Demo
{
    [CodedUITest]
    public class CheckboxControlTest
    {
        [TestInitialize]
        public void Initialize()
        {
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.AllActionSnapshot;
            Playback.PlaybackSettings.DelayBetweenActions = 0;
            Browse.BrowserWindow = BrowserWindow.Launch(new Uri($"{ConfigurationManager.AppSettings["DefaultUrl"]}/CheckBox"));
        }

        [TestCleanup]
        public void Cleanup()
        {
            Browse.BrowserWindow.Close();
            Playback.Cleanup();
        }

        [TestMethod]
        public void Checkbox_Should_Be_Checked()
        {
            CheckboxControl checkbox = new CheckboxControl("checkbox_checked");
            Assert.AreEqual(true, checkbox.IsChecked);
        }

        [TestMethod]
        public void Checkbox_Should_Be_Unchecked()
        {
            CheckboxControl checkbox = new CheckboxControl("checkbox_unchecked");
            Assert.AreEqual(false, checkbox.IsChecked);
        }

        [TestMethod]
        public void Checkbox_Should_Be_Enabled()
        {
            CheckboxControl checkbox = new CheckboxControl("checkbox_checked");
            Assert.AreEqual(true, checkbox.IsEnabled);
        }

        [TestMethod]
        public void Checkbox_Should_Be_Disabled()
        {
            CheckboxControl checkbox = new CheckboxControl("checkbox_disabled");
            Assert.AreEqual(false, checkbox.IsEnabled);
        }

        [TestMethod]
        public void Checkbox_Should_Check()
        {
            CheckboxControl checkbox = new CheckboxControl("checkbox_unchecked");
            checkbox.Check();

            Assert.AreEqual(true, checkbox.IsChecked);
        }

        [TestMethod]
        public void Checkbox_Should_Uncheck()
        {
            CheckboxControl checkbox = new CheckboxControl("checkbox_checked");
            checkbox.Uncheck();

            Assert.AreEqual(false, checkbox.IsChecked);
        }

        [TestMethod]
        public void Checkbox_Should_Have_CssClass_Test()
        {
            CheckboxControl checkbox = new CheckboxControl("checkbox_unchecked");
            Assert.AreEqual("test", checkbox.GetCssClassName);
        }

        [TestMethod]
        public void Checkbox_Without_Id_Should_Be_Checked()
        {
            CheckboxControl checkbox = new CheckboxControl();
            checkbox.FindCheckBoxByClassName("checkbox-without-id checked");
            Assert.AreEqual(true, checkbox.IsChecked);
        }

        [TestMethod]
        public void Checkbox_Without_Id_Should_Be_Disabled()
        {
            CheckboxControl checkbox = new CheckboxControl();
            checkbox.FindCheckBoxByClassName("checkbox-without-id disabled");
            Assert.AreEqual(false, checkbox.IsEnabled);
        }
    }
}
