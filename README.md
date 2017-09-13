# Coded UI Agility Pack
Coded UI Agility Pack was built to help developers that wants to create Coded UI Tests (Automation Tests).

Most of the articles and guides use the **Record Action** to generate the UI Test Code. Using **Coded UI Agility Pack** you do not need it. You can code your Coded Ui Tests as you code your Unit Tests.

There are examples about how to use every option available on Coded UI Agility Pack on the [Demo project](https://github.com/quintelab/CodedUIAgilityPack/tree/master/CodedUIAgilityPack.Demo)

## Simple Example

```c#
using CodedUIAgilityPack.Controls;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            Browse.BrowserWindow = BrowserWindow.Launch(new Uri("http://localhost/CodedUIAgilityPack.Web/Button"));
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
            Assert.AreEqual(true, button.IsEnabled());
        }
    }
}

```
## How to install
You can install it from [Nuget](https://www.nuget.org/packages/CodedUIAgilityPack/)

```
Install-Package CodedUIAgilityPack -Version 1.0.0
```
