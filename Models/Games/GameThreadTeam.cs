using System;
using System.Collections.Generic;

namespace _1212api
{
    public enum OffenseScheme
    {
        Flexbone,
        Pistol,
        Pro,
        Spread,
        Air,
        Unknown
    }
    public enum DefenseScheme
    {
        _52,
        _44,
        _43,
        _34,
        _33,
        Unknown
    }
    public partial class GameThreadTeam
    {
        public int GameId { get; set; }
        public int TeamId { get; set; }
        public string ThreadId { get; set; } = null!;
        public OffenseScheme OffenseScheme { get; set; }
        public DefenseScheme DefenseScheme { get; set; }

        public virtual GameTeam GameTeam { get; set; } = null!;
        public virtual GameThread Thread { get; set; } = null!;
    }
}
