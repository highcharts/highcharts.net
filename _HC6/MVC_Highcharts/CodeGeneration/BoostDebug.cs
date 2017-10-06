using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class BoostDebug  : BaseObject
	{
		public BoostDebug()
		{
			TimeRendering = TimeRendering_DefaultValue = false;
			TimeSeriesProcessing = TimeSeriesProcessing_DefaultValue = false;
			TimeSetup = TimeSetup_DefaultValue = false;
			TimeKDTree = TimeKDTree_DefaultValue = false;
			ShowSkipSummary = ShowSkipSummary_DefaultValue = false;
			TimeBufferCopy = TimeBufferCopy_DefaultValue = false;
			
		}	
		

		/// <summary>
		/// <p>Time the series rendering.</p><p>This outputs the time spent on actual rendering in the console whenset to true.</p>
		/// </summary>
		public bool? TimeRendering { get; set; }
		private bool? TimeRendering_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Time the series processing.</p><p>This outputs the time spent on transforming the series data tovertex buffers when set to true.</p>
		/// </summary>
		public bool? TimeSeriesProcessing { get; set; }
		private bool? TimeSeriesProcessing_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Time the the WebGL setup.</p><p>This outputs the time spent on setting up the WebGL context,creating shaders, and textures.</p>
		/// </summary>
		public bool? TimeSetup { get; set; }
		private bool? TimeSetup_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Time the building of the k-d tree.</p><p>This outputs the time spent building the k-d tree used formarkers etc.</p><p>Note that the k-d tree is built async, and runs post-rendering.Following, it does not affect the performance of the rendering itself.</p>
		/// </summary>
		public bool? TimeKDTree { get; set; }
		private bool? TimeKDTree_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Show the number of points skipped through culling.</p><p>When set to true, the number of points skipped in series processingis outputted. Points are skipped if they are closer than 1 pixel fromeach other.</p>
		/// </summary>
		public bool? ShowSkipSummary { get; set; }
		private bool? ShowSkipSummary_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Time the WebGL to SVG buffer copy</p><p>After rendering, the result is copied to an image which is injectedinto the SVG.</p><p>If this property is set to true, the time it takes for the buffer copyto complete is outputted.</p>
		/// </summary>
		public bool? TimeBufferCopy { get; set; }
		private bool? TimeBufferCopy_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (TimeRendering != TimeRendering_DefaultValue) h.Add("timeRendering",TimeRendering);
			if (TimeSeriesProcessing != TimeSeriesProcessing_DefaultValue) h.Add("timeSeriesProcessing",TimeSeriesProcessing);
			if (TimeSetup != TimeSetup_DefaultValue) h.Add("timeSetup",TimeSetup);
			if (TimeKDTree != TimeKDTree_DefaultValue) h.Add("timeKDTree",TimeKDTree);
			if (ShowSkipSummary != ShowSkipSummary_DefaultValue) h.Add("showSkipSummary",ShowSkipSummary);
			if (TimeBufferCopy != TimeBufferCopy_DefaultValue) h.Add("timeBufferCopy",TimeBufferCopy);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
			else 
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