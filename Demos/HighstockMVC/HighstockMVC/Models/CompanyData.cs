using System;

namespace HighstockMVC.Models
{
    public class CompanyData
    {
        public int Id { get; set; }
        public Nullable<double> Date { get; set; }
        public Nullable<double> Value { get; set; }
    }
}