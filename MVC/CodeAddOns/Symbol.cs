using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc
{
    /// <summary>
    /// If set, the symbol for the point can be one of the following - Circle, Square, Diamond, Triangle, TraingleDown
    /// </summary>
    public enum SymbolEnum
    {
        Null = 0,
        Circle = 1,
        Square = 2,
        Diamond = 3,
        Triangle = 4,
        Triangledown = 5,
    }

    public partial class Symbol : BaseObject
    {
        public Symbol()
        {
            Url ="";
            SymbolEnum = SymbolEnum.Null;
        }

        /// <summary>
        /// If set, the symbol will be a pth to the image specified using CSS synax, valid example is: "url(http://www.highcharts.com/demo/gfx/sun.png)"
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// If set, the symbol for the point can be one of the following - Circle, Square, Diamond, Triangle, TraingleDown
        /// </summary>
        public SymbolEnum SymbolEnum { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable h = new Hashtable();

            if (Url != null)
            {
                h.Add("symbol", Url);
            }
            else if (SymbolEnum != SymbolEnum.Null)
            {
                h.Add("symbol", SymbolEnum.ToString().ToLower());
            }

            return h;
        }

        internal override string ToJSON()
        {
            if (Url != null)
            {
                return Url.ToString();
            }
            else if (SymbolEnum != SymbolEnum.Null)
            {
                return SymbolEnum.ToString().ToLower();
            }

            return "";
        }

        // checks if the state of the object is different from the default
        // and therefore needs to be serialized
        internal override bool IsDirty()
        {
            return ToHashtable().Count > 0;
        }
    }

}