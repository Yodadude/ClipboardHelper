using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace ClipboardHelper
{
    public class ClipboardXmlRepository : IClipboardRepository
    {
        private string filePath;

        public void SetSource(string destination)
        {
            filePath = destination;

            if (!File.Exists(filePath))
            {
                File.CreateText(filePath);
            }
        }

        public string[] Get()
        {
            ClipboardItems items;

            using (var stream = File.OpenRead(filePath))
            {
                var serializer = new XmlSerializer(typeof(ClipboardItems));
                items = serializer.Deserialize(stream) as ClipboardItems;
            }

            return items.Items.ToArray() ?? new string[0];
        }

        public void Save(string[] items)
        {
            using (var writer = new StreamWriter(filePath))
            {
                var serializer = new XmlSerializer(typeof(ClipboardItems));
                serializer.Serialize(writer, (ClipboardItems)items);
                writer.Flush();
            }
        }
    }

}
