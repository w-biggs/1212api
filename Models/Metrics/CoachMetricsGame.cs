using System;
using System.Collections.Generic;

namespace _1212api
{
    public partial class CoachMetricsGame
    {
        public int TeamId { get; set; }
        public int GameId { get; set; }
        public int CoachId { get; set; }
        public double OldElo { get; set; }
        public double Elo { get; set; }

        public virtual Coach Coach { get; set; } = null!;
        public virtual GameTeam GameTeam { get; set; } = null!;
    }
}
