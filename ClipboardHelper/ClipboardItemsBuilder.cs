using System;
using System.Collections.Generic;
using System.Text;

namespace ClipboardHelper
{
    public class ClipboardItemsBuilder
    {
        public ClipboardItems Create(string[] items)
        {
            var clipitems = new ClipboardItems();

            clipitems.Items.AddRange(items);

            return clipitems;
        }
    }
}
