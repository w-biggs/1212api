using System;
using System.Collections.Generic;

namespace _1212api
{
    public partial class Team
    {
        public Team()
        {
            GameTeams = new HashSet<GameTeam>();
            TeamDivHistories = new HashSet<TeamDivHistory>();
            TeamMetricsSeasons = new HashSet<TeamMetricsSeason>();
        }

        public int Id { get; set; }
        public string School { get; set; } = null!;
        public string? ShortSchool { get; set; }
        public string Abbreviation { get; set; } = null!;
        public string Color { get; set; } = null!;
        public int? DivisionId { get; set; }

        public virtual Division? Division { get; set; }
        public virtual ICollection<GameTeam> GameTeams { get; set; }
        public virtual ICollection<TeamDivHistory> TeamDivHistories { get; set; }
        public virtual ICollection<TeamMetricsSeason> TeamMetricsSeasons { get; set; }
    }
}
