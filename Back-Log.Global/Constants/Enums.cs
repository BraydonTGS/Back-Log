using System.ComponentModel;

namespace Back_Log.Global.Constants
{
    public static class Enums
    {
        public enum VideoGameGenre
        {
            Action,
            Adventure,
            RPG,
            JRPG,
            Shooter,
            Simulation,
            Strategy,
            Sports,
            Puzzle,
            Horror,
            Mystery,
            Fighting,
            Racing,
            Platformer,
            Sandbox,
            Survival,
            MMO,
            Music,
            Educational,
            Casual,
            Other
        }

        public enum ESRBRating
        {
            [Description("Early Childhood")]
            EC,

            [Description("Everyone")]
            E,

            [Description("Everyone 10+")]
            E10Plus,

            [Description("Teen")]
            T,

            [Description("Mature")]
            M,

            [Description("Adults Only")]
            AO,

            [Description("Rating Pending")]
            RP
        }
    }
}
