using System;
using System.Collections.Generic;

namespace _1212api
{
    public partial class GameTeam
    {
        public int GameId { get; set; }
        public int TeamId { get; set; }
        public bool IsHome { get; set; }
        public int[]? QuarterScores { get; set; }

        public virtual Game Game { get; set; } = null!;
        public virtual Team Team { get; set; } = null!;
        public virtual GameTeamStats GameTeamStats { get; set; } = null!;
        public virtual GameThreadTeam GameThreadTeam { get; set; } = null!;
        
        public virtual ICollection<CoachMetricsGame> CoachMetricsGames { get; set; } = null!;
        public virtual ICollection<TeamMetricsGame> TeamMetricsGames { get; set; } = null!;
    }
}
