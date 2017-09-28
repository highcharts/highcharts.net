using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Collections.ObjectModel;

namespace ApiGenerator.XmlDoc
{
    public class Members
    {
        private ObservableCollection<Member> _List = new ObservableCollection<Member>();

        [XmlElement("member")]
        public ObservableCollection<Member> List
        {
            get
            {
                return _List;
            }

            set
            {
                _List = value;
            }
        }
    }
}
