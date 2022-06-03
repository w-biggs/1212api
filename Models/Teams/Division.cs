using System;
using System.Collections.Generic;

namespace _1212api
{
    public partial class Division
    {
        public Division()
        {
            ConfDivHistories = new HashSet<ConfDivHistory>();
            TeamDivHistories = new HashSet<TeamDivHistory>();
            Teams = new HashSet<Team>();
        }

        public int Id { get; set; }
        public string DivName { get; set; } = null!;
        public int ConferenceId { get; set; }

        public virtual Conference Conference { get; set; } = null!;
        public virtual ICollection<ConfDivHistory> ConfDivHistories { get; set; }
        public virtual ICollection<TeamDivHistory> TeamDivHistories { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
