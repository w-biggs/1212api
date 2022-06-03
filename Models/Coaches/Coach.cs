using System;
using System.Collections.Generic;

namespace _1212api
{
    public partial class Coach
    {
        public Coach()
        {
            CoachMetricsGames = new HashSet<CoachMetricsGame>();
            PlayDefCoaches = new HashSet<Play>();
            PlayOffCoaches = new HashSet<Play>();
        }

        public int Id { get; set; }
        public string PrimaryUsername { get; set; } = null!;
        public string[]? Usernames { get; set; }

        public virtual ICollection<CoachMetricsGame> CoachMetricsGames { get; set; }
        public virtual ICollection<Play> PlayDefCoaches { get; set; }
        public virtual ICollection<Play> PlayOffCoaches { get; set; }
    }
}
