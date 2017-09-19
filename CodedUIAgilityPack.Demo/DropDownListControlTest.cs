using CodedUIAgilityPack.Controls;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;

namespace CodedUIAgilityPack.Demo
{
    [CodedUITest]
    public class DropDownListControlTest
    {
        DropDownListControl myDropDownList;

        [TestInitialize]
        public void Initialize()
        {
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.AllActionSnapshot;
            Playback.PlaybackSettings.DelayBetweenActions = 0;
            Browse.BrowserWindow = BrowserWindow.Launch(new Uri($"{ConfigurationManager.AppSettings["DefaultUrl"]}/DropDownList"));

            myDropDownList = new DropDownListControl("companies");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Browse.BrowserWindow.Close();
            Playback.Cleanup();
        }

        [TestMethod]
        public void DropDownList_Should_Select_Value_Saab()
        {
            myDropDownList.Select("saab");

            Assert.AreEqual("saab", myDropDownList.SelectedValue);
        }

        [TestMethod]
        public void DropDownList_Should_Select_Item_Audi()
        {
            myDropDownList.Select("audi");

            Assert.AreEqual("audi", myDropDownList.SelectedItem.Value);
            Assert.AreEqual("Audi", myDropDownList.SelectedItem.Description);
        }

        [TestMethod]
        public void DropDownList_CssClass_Should_Be_Form_Control()
        {
            Assert.AreEqual("form-control", myDropDownList.CssClassName);
        }

        [TestMethod]
        public void DropDownList_Should_Have_Four_Items()
        {
            Assert.AreEqual(5, myDropDownList.NumberOfItems);
        }
    }
}
