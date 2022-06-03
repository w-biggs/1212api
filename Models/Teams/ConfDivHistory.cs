using System;
using System.Collections.Generic;

namespace _1212api
{
    public partial class ConfDivHistory
    {
        public int ConferenceId { get; set; }
        public int DivisionId { get; set; }
        public int SeasonNo { get; set; }

        public virtual Conference Conference { get; set; } = null!;
        public virtual Division Division { get; set; } = null!;
        public virtual Season SeasonNoNavigation { get; set; } = null!;
    }
}
