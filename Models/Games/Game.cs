using System;
using System.Collections.Generic;

namespace _1212api
{
    public partial class Game
    {
        public Game()
        {
            GameTeams = new HashSet<GameTeam>();
            GameThreads = new HashSet<GameThread>();
        }

        public int Id { get; set; }
        public int WeekNo { get; set; }
        public int SeasonNo { get; set; }
        public bool IsNeutral { get; set; }

        public virtual Week Week { get; set; } = null!;
        public virtual ICollection<GameTeam> GameTeams { get; set; }
        public virtual ICollection<GameThread> GameThreads { get; set; }
    }
}
