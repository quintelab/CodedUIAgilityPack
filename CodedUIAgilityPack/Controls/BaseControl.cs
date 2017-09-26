using System;

namespace CodedUIAgilityPack.Controls
{
    /// <summary>
    /// Base control
    /// </summary>
    public abstract class BaseControl
    {
        internal BaseControl(string controlName)
        {
            if (Browse.BrowserWindow == null)
                throw new Exception("BrowserWindow is null!");

            if(string.IsNullOrEmpty(controlName))
                throw new Exception("Control name is null or empty!");
        }
    }
}
