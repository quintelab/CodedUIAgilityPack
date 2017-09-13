using CodedUIAgilityPack.Controls;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            Browse.BrowserWindow = BrowserWindow.Launch(new Uri("http://localhost/CodedUIAgilityPack.Web/DropDownList"));

            myDropDownList = new DropDownListControl("companies");
            myDropDownList.AddItem("", "Select an item");
            myDropDownList.AddItem("volvo", "Volvo");
            myDropDownList.AddItem("saab", "Saab");
            myDropDownList.AddItem("mercedes", "Mercedes");
            myDropDownList.AddItem("audi", "Audi");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Browse.BrowserWindow.Close();
            Playback.Cleanup();
        }

        [TestMethod]
        public void DropDownList_Should_Select_Audi_Item()
        {
            myDropDownList.Select(myDropDownList.DropDownListOptions[4]);

            ListOptions option = myDropDownList.SelectedItem();

            Assert.AreEqual("audi", option.Value);
        }

        [TestMethod]
        public void DropDownList_Should_Select_Saab_Item()
        {
            myDropDownList.Select("saab");

            ListOptions option = myDropDownList.SelectedItem();

            Assert.AreEqual("saab", option.Value);
        }

        [TestMethod]
        public void DropDownList_CssClass_Should_Be_Form_Control()
        {
            Assert.AreEqual("form-control", myDropDownList.GetCssClassName());
        }

        [TestMethod]
        public void DropDownList_Should_Have_Four_Items()
        {
            Assert.AreEqual(5, myDropDownList.NumberOfItems);
        }
    }
}
