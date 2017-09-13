using CodedUIAgilityPack.Controls;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodedUIAgilityPack.Demo
{
    [CodedUITest]
    public class TextBoxControlTest
    {
        [TestInitialize]
        public void Initialize()
        {
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.AllActionSnapshot;
            Playback.PlaybackSettings.DelayBetweenActions = 0;
            Browse.BrowserWindow = BrowserWindow.Launch(new Uri("http://localhost/CodedUIAgilityPack.Web/TextBox"));
        }

        [TestCleanup]
        public void Cleanup()
        {
            Browse.BrowserWindow.Close();
            Playback.Cleanup();
        }

        [TestMethod]
        public void Textbox_Should_Have_CssClass_Form_Control()
        {
            TextBoxControl textbox = new TextBoxControl("textbox");
            Assert.AreEqual("form-control", textbox.GetCssClassName());
        }

        [TestMethod]
        public void Textbox_Should_Have_Text_Value()
        {
            TextBoxControl textbox = new TextBoxControl("textbox");
            Assert.AreEqual("text here", textbox.GetText());
        }

        [TestMethod]
        public void Textbox_Should_Be_Empty()
        {
            TextBoxControl textbox = new TextBoxControl("empty-textbox");
            Assert.AreEqual("", textbox.GetText());
        }

        [TestMethod]
        public void Textbox_Should_Set_Value()
        {
            TextBoxControl textbox = new TextBoxControl("empty-textbox");
            textbox.SetText("unit test");
            Assert.AreEqual("unit test", textbox.GetText());
        }
    }
}
