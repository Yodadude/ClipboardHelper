using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace ClipboardHelper
{
    [XmlRoot("Items")]
    public class ClipboardItems
    {
        //[XmlElement("Item")]
        //[XmlText]
        [XmlElement("Item")]
        public List<string> Items { get; set; }

        public ClipboardItems()
        {
            Items = new List<string>();
        }

        // Convert string array to ClipboardItems object
        public static implicit operator ClipboardItems(string[] rhs)
        {
            ClipboardItems c = new ClipboardItems();

            c.Items.AddRange(rhs);

            return c;
        }
    }


}
