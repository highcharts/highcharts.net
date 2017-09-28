using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Web;

namespace ApiGenerator.XmlDoc
{
    public class Member
    {
        private string _Summary;

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlElement("summary")]
        public string Summary
        {
            get
            {
                return _Summary;
            }

            set
            {
                _Summary = HttpUtility.HtmlEncode(value);
            }
        } 
    }
}
