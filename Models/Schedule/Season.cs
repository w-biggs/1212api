using System;
using System.Collections.Generic;

namespace _1212api
{
    public partial class Season
    {
        public Season()
        {
            ConfDivHistories = new HashSet<ConfDivHistory>();
            TeamDivHistories = new HashSet<TeamDivHistory>();
            TeamMetricsSeasons = new HashSet<TeamMetricsSeason>();
            Weeks = new HashSet<Week>();
        }

        public int SeasonNo { get; set; }

        public virtual ICollection<ConfDivHistory> ConfDivHistories { get; set; }
        public virtual ICollection<TeamDivHistory> TeamDivHistories { get; set; }
        public virtual ICollection<TeamMetricsSeason> TeamMetricsSeasons { get; set; }
        public virtual ICollection<Week> Weeks { get; set; }
    }
}
