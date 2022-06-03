using System;
using System.Collections.Generic;

namespace _1212api
{
    public partial class GameTeamStats
    {
        public int GameId { get; set; }
        public int TeamId { get; set; }
        public int PassYds { get; set; }
        public int RushYds { get; set; }
        public int Interceptions { get; set; }
        public int Fumbles { get; set; }
        public int FgAttempts { get; set; }
        public int FgMakes { get; set; }
        public int TimeOfPossession { get; set; }

        public virtual GameTeam GameTeam { get; set; } = null!;
    }
}
