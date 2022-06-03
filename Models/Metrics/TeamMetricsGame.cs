using System;
using System.Collections.Generic;

namespace _1212api
{
    public partial class TeamMetricsGame
    {
        public int TeamId { get; set; }
        public int GameId { get; set; }
        public double OldElo { get; set; }
        public double Elo { get; set; }
        
        public virtual GameTeam GameTeam { get; set; } = null!;
    }
}
