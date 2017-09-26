using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Configuration;
using CodedUIAgilityPack.Controls;

namespace CodedUIAgilityPack.Demo
{
    [CodedUITest]
    public class SpanControlTest
    {
        [TestInitialize]
        public void Initialize()
        {
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.AllActionSnapshot;
            Playback.PlaybackSettings.DelayBetweenActions = 0;
            Browse.BrowserWindow = BrowserWindow.Launch(new Uri($"{ConfigurationManager.AppSettings["DefaultUrl"]}/Span"));
        }

        [TestCleanup]
        public void Cleanup()
        {
            Browse.BrowserWindow.Close();
            Playback.Cleanup();
        }

        [TestMethod]
        public void Span_Should_Have_Text_Click_Me()
        {
            SpanControl span = new SpanControl("click-span");
            Assert.AreEqual("Click me.", span.GetText);
        }

        [TestMethod]
        public void Span_Should_Have_CssClass_Label_Defaut()
        {
            SpanControl span = new SpanControl("simple-span");
            Assert.AreEqual(true, span.GetCssClassName.Contains("label-default"));
        }

        [TestMethod]
        public void Span_Should_Change_CssClass_After_Clicking()
        {
            SpanControl span = new SpanControl("click-span");
            span.Click();
            Assert.AreEqual(true, span.GetCssClassName.Contains("label-success"));
        }
    }
}
