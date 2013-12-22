using System;
using System.Collections.Generic;
using System.Text;
using NppPluginNET;

namespace ClipboardHelper
{
    public interface IClipboardRepository
    {
        string[] Get();
        void Save(string[] clipitems);
        void SetSource(string destination);
    }


}
