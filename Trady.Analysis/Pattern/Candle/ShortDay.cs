﻿using System;
using Trady.Core;

namespace Trady.Analysis.Pattern.Candle
{
    /// <summary>
    /// Reference: http://stockcharts.com/school/doku.php?id=chart_school:chart_analysis:candlestick_pattern_dictionary
    /// </summary>
    public class ShortDay : AnalyticBase<IsMatchedResult>
    {
        public ShortDay(Equity equity) : base(equity)
        {
        }

        public override IsMatchedResult ComputeByIndex(int index)
        {
            throw new NotImplementedException();
        }
    }
}