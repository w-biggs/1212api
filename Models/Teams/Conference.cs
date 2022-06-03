using System;
using System.Collections.Generic;

namespace _1212api
{
    public partial class Conference
    {
        public Conference()
        {
            ConfDivHistories = new HashSet<ConfDivHistory>();
            Divisions = new HashSet<Division>();
        }

        public int Id { get; set; }
        public string ConfName { get; set; } = null!;
        public string ShortName { get; set; } = null!;
        public int LevelId { get; set; }

        public virtual Level Level { get; set; } = null!;
        public virtual ICollection<ConfDivHistory> ConfDivHistories { get; set; }
        public virtual ICollection<Division> Divisions { get; set; }
    }
}
