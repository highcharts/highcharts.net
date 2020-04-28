using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Demo.Models
{
    public class StockData
    {
        public int Id { get; set; }
        public Nullable<double> Date { get; set; }
        public Nullable<double> Open { get; set; }
        public Nullable<double> High { get; set; }
        public Nullable<double> Low { get; set; }
        public Nullable<double> Close { get; set; }
        public Nullable<double> Volume { get; set; }
    }
}