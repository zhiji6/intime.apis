﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.intime.fashion.service.analysis.DTO
{
    class SummarySessionsRequest:SummaryRequestBase
    {
        protected override string MetricName
        {
            get { return "Sessions"; }
        }
    }
}
