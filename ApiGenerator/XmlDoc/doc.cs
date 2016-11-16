using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace ApiGenerator.XmlDoc
{
    [XmlRoot("doc")]
    public class Doc
    {
        [XmlElement("assembly")]
        public Assembly Assembly {get;set;}

        [XmlElement("members")]
        public Members Members { get; set; }
    }
}
