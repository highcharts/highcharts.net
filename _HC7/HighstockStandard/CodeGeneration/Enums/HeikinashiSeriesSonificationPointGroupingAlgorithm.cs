using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Highsoft.Web.Mvc.Stocks
{
    public enum HeikinashiSeriesSonificationPointGroupingAlgorithm
    {
        Null, 
		Minimax, 
		First, 
		Last, 
		Middle, 
		Firstlast
    }
}
