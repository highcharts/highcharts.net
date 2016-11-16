using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ApiGenerator.XmlDoc
{
    public class Assembly
    {
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
