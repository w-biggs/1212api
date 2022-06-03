using System;
using System.Collections.Generic;

namespace _1212api
{
    public partial class TeamDivHistory
    {
        public int TeamId { get; set; }
        public int DivisionId { get; set; }
        public int SeasonNo { get; set; }

        public virtual Division Division { get; set; } = null!;
        public virtual Season SeasonNoNavigation { get; set; } = null!;
        public virtual Team Team { get; set; } = null!;
    }
}
