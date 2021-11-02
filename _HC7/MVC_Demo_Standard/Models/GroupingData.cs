using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Demo.Models
{
    public class GroupingData
    {
        public IEnumerable<double> List { get; set; }
        public double PointStart { get; set; }
        public double PointInterval { get; set; }
        public long DataLength { get; set; }
    }
}