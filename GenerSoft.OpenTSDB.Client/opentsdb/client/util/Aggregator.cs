using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerSoft.OpenTSDB.Client
{
    public enum Aggregator
    {
        avg,
        count,
        dev,
        ep50r3,
        ep50r7,
        ep75r3,
        ep75r7,
        ep90r3,
        ep90r7,
        ep95r3,
        ep95r7,
        ep99r3,
        ep99r7,
        ep999r3,
        ep999r7,
        mimmin,
        mimmax,
        min,
        max,
        none,
        p50,
        p75,
        p90,
        p95,
        p99,
        p999,
        sum,
        zimsum
    }
}