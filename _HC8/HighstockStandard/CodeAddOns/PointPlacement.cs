using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    /// <summary>
    /// <p>Possible values: null, "on", "between".</p><p>In a column chart, when pointPlacement is "on", the point will not create any padding of the X axis. In a polar column chart this means that the first column points directly north. If the pointPlacement is "between", the columns will be laid out between ticks. This is useful for example for visualising an amount between two points in time or in a certain sector of a polar chart.</p><p>Since Highcharts 3.0.2, the point placement can also be numeric, where 0 is on the axis value, -0.5 is between this value and the previous, and 0.5 is between this value and the next. Unlike the textual options, numeric point placement options won't affect axis padding.</p><p>Defaults to <code>null</code> in cartesian charts, <code>"between"</code> in polar charts.
    /// </summary>
    /// 
    public enum PointPlacementEnum
    {
        Null,
        On,
        Between
    }

    public partial class PointPlacement : BaseObject
    {
        public PointPlacement()
        {
            _Value = null;
            _PointPlacementEnum = PointPlacementEnum.Null;
        }

        private double? _Value;
        private PointPlacementEnum _PointPlacementEnum;

        public double? Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
                _PointPlacementEnum = PointPlacementEnum.Null;
            }
        }
        public PointPlacementEnum PointPlacementEnum
        {
            get
            {
                return _PointPlacementEnum;
            }
            set
            {
                _PointPlacementEnum = value;
                _Value = null;
            }
        }

        internal override Hashtable ToHashtable(ref Highstock highcharts)
        {
            Hashtable h = new Hashtable();

            if (Value.HasValue)
                h.Add("pointPlacement", Value);
            else if (PointPlacementEnum != PointPlacementEnum.Null)
                h.Add("pointPlacement", PointPlacementEnum.ToString().ToLower());

            return h;
        }

        internal override string ToJSON(ref Highstock highcharts)
        {
            if (PointPlacementEnum != PointPlacementEnum.Null)
            {
                return PointPlacementEnum.ToString().ToLower();
            }

            return null;
        }

        // checks if the state of the object is different from the default
        // and therefore needs to be serialized
        internal override bool IsDirty(ref Highstock highcharts)
        {
            return ToHashtable(ref highcharts).Count > 0;
        }
    }

}