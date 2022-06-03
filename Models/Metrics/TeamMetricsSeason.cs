using System;
using System.Collections.Generic;

namespace _1212api
{
    public partial class TeamMetricsSeason
    {
        public int TeamId { get; set; }
        public int SeasonNo { get; set; }
        public double WPn { get; set; }
        public double Pn { get; set; }

        public virtual Season SeasonNoNavigation { get; set; } = null!;
        public virtual Team Team { get; set; } = null!;
    }
}
