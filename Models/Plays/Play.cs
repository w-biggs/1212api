using System;
using System.Collections.Generic;

namespace _1212api
{
    public enum PlayType {
        Run,
        Pass,
        Punt,
        FieldGoal,
        Kneel,
        Spike,
        Pat,
        TwoPoint,
        KickoffNormal,
        KickoffSquib,
        KickoffOnside,
        DelayOfGame,
    }
    
    public enum Result {
        Gain,
        Turnover,
        Touchdown,
        TurnoverTouchdown,
        Incomplete,
        Touchback,
        FieldGoal,
        Miss,
        Pat,
        TwoPoint,
        Kickoff,
        Punt,
        Kick,
        Spike,
        Kneel,
        Safety,
        Error,
        TurnoverPat,
        EndHalf,
        DelayOfGame
    }

    public enum Timeout {
        Offense,
        Defense,
        None
    }
    
    public partial class Play
    {
        public string ThreadId { get; set; } = null!;
        public int PlayNo { get; set; }
        public bool HomeOffense { get; set; }
        public string CommentId { get; set; } = null!;
        public int OffCoachId { get; set; }
        public int DefCoachId { get; set; }
        public PlayType PlayType { get; set; }
        public Result Result { get; set; }
        public int YardsGained { get; set; }
        public int Down { get; set; }
        public int Distance { get; set; }
        public int YardLine { get; set; }
        public int Quarter { get; set; }
        public int Clock { get; set; }
        public int PlayLength { get; set; }
        public int OffNumber { get; set; }
        public int DefNumber { get; set; }
        public DateTime OffNumberTime { get; set; }
        public DateTime DefNumberTime { get; set; }
        public Timeout Timeout { get; set; }

        public virtual Coach DefCoach { get; set; } = null!;
        public virtual Coach OffCoach { get; set; } = null!;
        public virtual GameThread Thread { get; set; } = null!;
    }
}
