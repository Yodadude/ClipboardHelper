using System;
using System.Collections.Generic;
using System.Text;
using NppPluginNET;

namespace ClipboardHelper
{
    public class ClipboardIniRepository : IClipboardRepository
    {
        private string filePath;

        public void SetSource(string destination)
        {
            filePath = destination;
        }

        public string[] Get()
        {
            StringBuilder sb = new StringBuilder();
            int numItems;
            string item = "";
            string savedDefault = "";
            List<string> items = new List<string>();
            sb.Capacity = 1024;
            byte[] raw;

            numItems = Win32.GetPrivateProfileInt("General", "LineCount", 0, filePath);

            for (int i = 0; i < numItems; i++)
            {
                Win32.GetPrivateProfileString("General", "item" + i.ToString(), savedDefault, sb, sb.Capacity, filePath);
                raw = Convert.FromBase64String(sb.ToString());
                item = Encoding.UTF8.GetString(raw);
                items.Add(item);
            }
            //MessageBox.Show("Setting Clipboard from INI..." + sb.ToString());

            return items.ToArray();
        }

        public void Save(string[] items)
        {

            Win32.WritePrivateProfileString("General", "LineCount", items.Length.ToString(), filePath);

            for (int i = 0; i < items.Length; i++)
            {
                Win32.WritePrivateProfileString("General", "item" + i.ToString(), Convert.ToBase64String(System.Text.UTF8Encoding.Unicode.GetBytes(items[i])), filePath);
            }
            //MessageBox.Show("Saving Clipboard..." + clipItems);
            //Win32.WritePrivateProfileString("General", "Clipboard", clipItems, iniFilePath);
        }
    }
}
