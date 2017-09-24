using CodedUIAgilityPack.Controls;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace CodedUIAgilityPack.Demo
{
    [CodedUITest]
    public class RadioButtonControlTest
    {
        RadioButtonControl myRadioButton;

        [TestInitialize]
        public void Initialize()
        {
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.AllActionSnapshot;
            Playback.PlaybackSettings.DelayBetweenActions = 0;
            Browse.BrowserWindow = BrowserWindow.Launch(new Uri($"{ConfigurationManager.AppSettings["DefaultUrl"]}/RadioButton"));

            myRadioButton = new RadioButtonControl("gender");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Browse.BrowserWindow.Close();
            Playback.Cleanup();
        }

        [TestMethod]
        public void RadioButton_First_Item_Should_Be_Male()
        {
            List<ListOptions> items = myRadioButton.GetChildren();

            Assert.AreEqual("m", items[0].Value);
            Assert.AreEqual("gender_male", items[0].Name);
        }

        [TestMethod]
        public void RadioButton_Second_Item_Should_Be_Female()
        {
            List<ListOptions> items = myRadioButton.GetChildren();

            Assert.AreEqual("f", items[1].Value);
            Assert.AreEqual("gender_female", items[1].Name);
        }

        [TestMethod]
        public void RadioButton_Should_Select_Male_Option()
        {
            myRadioButton.SelectById("gender_male");
            ListOptions item = myRadioButton.SelectedItem;

            Assert.AreEqual("m", item.Value);
            Assert.AreEqual("gender_male", item.Name);
        }

        [TestMethod]
        public void RadioButton_Should_Select_Other_Option()
        {
            myRadioButton.SelectByValue("o");
            ListOptions item = myRadioButton.SelectedItem;

            Assert.AreEqual("o", item.Value);
            Assert.AreEqual("gender_other", item.Name);
        }

        [TestMethod]
        public void RadioButton_Should_Contains_3_Items()
        {
            Assert.AreEqual(3, myRadioButton.NumberOfItems);
        }
    }
}
