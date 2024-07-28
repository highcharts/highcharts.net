using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class BoostDebug  : BaseObject
	{
		Hashtable h = new Hashtable();

		public BoostDebug()
		{
		}	
		

		/// <summary>
		/// Show the number of points skipped through culling.When set to true, the number of points skipped in series processingis outputted. Points are skipped if they are closer than 1 pixel fromeach other.
		/// </summary>
		public bool? ShowSkipSummary { get; set; }
		 

		/// <summary>
		/// Time the WebGL to SVG buffer copyAfter rendering, the result is copied to an image which is injectedinto the SVG.If this property is set to true, the time it takes for the buffer copyto complete is outputted.
		/// </summary>
		public bool? TimeBufferCopy { get; set; }
		 

		/// <summary>
		/// Time the building of the k-d tree.This outputs the time spent building the k-d tree used formarkers etc.Note that the k-d tree is built async, and runs post-rendering.Following, it does not affect the performance of the rendering itself.
		/// </summary>
		public bool? TimeKDTree { get; set; }
		 

		/// <summary>
		/// Time the series rendering.This outputs the time spent on actual rendering in the console whenset to true.
		/// </summary>
		public bool? TimeRendering { get; set; }
		 

		/// <summary>
		/// Time the series processing.This outputs the time spent on transforming the series data tovertex buffers when set to true.
		/// </summary>
		public bool? TimeSeriesProcessing { get; set; }
		 

		/// <summary>
		/// Time the WebGL setup.This outputs the time spent on setting up the WebGL context,creating shaders, and textures.
		/// </summary>
		public bool? TimeSetup { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (ShowSkipSummary != null) h.Add("showSkipSummary",ShowSkipSummary);
			if (TimeBufferCopy != null) h.Add("timeBufferCopy",TimeBufferCopy);
			if (TimeKDTree != null) h.Add("timeKDTree",TimeKDTree);
			if (TimeRendering != null) h.Add("timeRendering",TimeRendering);
			if (TimeSeriesProcessing != null) h.Add("timeSeriesProcessing",TimeSeriesProcessing);
			if (TimeSetup != null) h.Add("timeSetup",TimeSetup);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}