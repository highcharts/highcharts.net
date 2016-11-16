using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace ApiGenerator.XmlDoc
{
    public static class XmlDocReader
    {
        public static Doc Get(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Doc));
            StreamReader reader = new StreamReader(filePath);

            Doc doc = (Doc)serializer.Deserialize(reader);

            return doc;
        }
    }
}
