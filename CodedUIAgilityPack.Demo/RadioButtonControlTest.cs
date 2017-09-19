using CodedUIAgilityPack.Controls;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
            myRadioButton.AddItem("gender_male", "m", "Male");
            myRadioButton.AddItem("gender_female", "f", "Female");
            myRadioButton.AddItem("gender_other", "o", "Other");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Browse.BrowserWindow.Close();
            Playback.Cleanup();
        }

        [TestMethod]
        public void RadioButton_Should_Select_Male_Option()
        {
            myRadioButton.Select(myRadioButton.RadioButtonItems[0]);

            ListOptions option = myRadioButton.SelectedItem();

            Assert.AreEqual("m", option.Value);
        }

        [TestMethod]
        public void RadioButton_Should_Select_Female_Option()
        {
            myRadioButton.Select("gender_female");

            ListOptions option = myRadioButton.SelectedItem();

            Assert.AreEqual("f", option.Value);
        }
    }
}
