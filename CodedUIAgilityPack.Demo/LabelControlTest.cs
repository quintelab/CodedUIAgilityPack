using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Configuration;
using CodedUIAgilityPack.Controls;

namespace CodedUIAgilityPack.Demo
{
    [CodedUITest]
    public class LabelControlTest
    {
        [TestInitialize]
        public void Initialize()
        {
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.AllActionSnapshot;
            Playback.PlaybackSettings.DelayBetweenActions = 0;
            Browse.BrowserWindow = BrowserWindow.Launch(new Uri($"{ConfigurationManager.AppSettings["DefaultUrl"]}/Label"));
        }

        [TestCleanup]
        public void Cleanup()
        {
            Browse.BrowserWindow.Close();
            Playback.Cleanup();
        }

        [TestMethod]
        public void Label_Should_Have_Text_Click_Me()
        {
            LabelControl label = new LabelControl("click-label");
            Assert.AreEqual("Click me.", label.GetText);
        }

        [TestMethod]
        public void Label_Should_Have_CssClass_Label_Defaut()
        {
            LabelControl label = new LabelControl("simple-label");
            Assert.AreEqual(true, label.GetCssClassName.Contains("label-default"));
        }

        [TestMethod]
        public void Label_Should_Change_CssClass_After_Clicking()
        {
            LabelControl label = new LabelControl("click-label");
            label.Click();
            Assert.AreEqual(true, label.GetCssClassName.Contains("label-success"));
        }

        [TestMethod]
        public void Label_Without_Id_Should_Have_Text_I_Am_A_Label_Without_Id()
        {
            LabelControl label = new LabelControl();
            label.FindLabelByClassName("label label-default label-without-id");
            Assert.AreEqual("I am a label without ID.", label.GetText);
        }
    }
}
