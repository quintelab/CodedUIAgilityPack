﻿using CodedUIAgilityPack.Controls;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;

namespace CodedUIAgilityPack.Demo
{
    [CodedUITest]
    public class ButtonControlTest
    {
        [TestInitialize]
        public void Initialize()
        {
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.AllActionSnapshot;
            Playback.PlaybackSettings.DelayBetweenActions = 0;
            Browse.BrowserWindow = BrowserWindow.Launch(new Uri($"{ConfigurationManager.AppSettings["DefaultUrl"]}/Button"));
        }

        [TestCleanup]
        public void Cleanup()
        {
            Browse.BrowserWindow.Close();
            Playback.Cleanup();
        }

        [TestMethod]
        public void Button_Should_Be_Active()
        {
            ButtonControl button = new ButtonControl("active_button");
            Assert.AreEqual(true, button.IsEnabled);
        }

        [TestMethod]
        public void Button_Should_Be_Disabled()
        {
            ButtonControl button = new ButtonControl("disabled_button");
            Assert.AreEqual(true, button.IsEnabled);
        }

        [TestMethod]
        public void Button_Should_Have_CssClass_Info()
        {
            ButtonControl button = new ButtonControl("btn_info");
            Assert.AreEqual(true, button.GetCssClassName.Contains("btn-info"));
        }

        [TestMethod]
        public void Button_Should_Change_CssClass_After_Click()
        {
            ButtonControl button = new ButtonControl("btn_click");
            button.Click();
            Assert.AreEqual(true, button.GetCssClassName.Contains("btn-success"));
        }

        [TestMethod]
        public void Button_Without_Id_Should_Change_CssClass_After_Click()
        {
            ButtonControl button = new ButtonControl();
            button.FindButtonByClassName("btn button-without-id");

            button.Click();
            Assert.AreEqual(true, button.GetCssClassName.Contains("btn-success"));
        }

        [TestMethod]
        public void Button_Without_Id_Should_Be_Active()
        {
            ButtonControl button = new ButtonControl();
            button.FindButtonByClassName("btn button-without-id");

            Assert.AreEqual(true, button.IsEnabled);
        }
    }
}
