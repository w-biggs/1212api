using System;
using System.Collections.Generic;

namespace _1212api
{
    public partial class GameThread
    {
        public GameThread()
        {
            GameThreadTeams = new HashSet<GameThreadTeam>();
            Plays = new HashSet<Play>();
        }

        public string Id { get; set; } = null!;
        public int GameId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsLive { get; set; }

        public virtual Game Game { get; set; } = null!;
        public virtual ICollection<GameThreadTeam> GameThreadTeams { get; set; }
        public virtual ICollection<Play> Plays { get; set; }
    }
}
