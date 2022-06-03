using System;
using System.Collections.Generic;

namespace _1212api
{
    public partial class Level
    {
        public Level()
        {
            Conferences = new HashSet<Conference>();
        }

        public int Id { get; set; }
        public string LevelName { get; set; } = null!;
        public string Abbreviation { get; set; } = null!;

        public virtual ICollection<Conference> Conferences { get; set; }
    }
}
