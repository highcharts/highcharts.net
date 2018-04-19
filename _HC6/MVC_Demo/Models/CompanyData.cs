using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Demo.Models
{
    public class CompanyData
    {
        public int Id { get; set; }
        public Nullable<double> Date { get; set; }
        public Nullable<double> Value { get; set; }
    }
}