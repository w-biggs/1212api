using System;
using System.Collections.Generic;

namespace _1212api
{
    public partial class Week
    {
        public Week()
        {
            Games = new HashSet<Game>();
        }

        public int WeekNo { get; set; }
        public int SeasonNo { get; set; }
        public string? WeekName { get; set; }

        public virtual Season SeasonNoNavigation { get; set; } = null!;
        public virtual ICollection<Game> Games { get; set; }
    }
}
