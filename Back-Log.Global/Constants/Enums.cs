using System.ComponentModel;

namespace Back_Log.Global.Constants
{
    public static class Enums
    {

        public enum VideoGameGenre
        {
            [Description("Action")]
            Action,

            [Description("Adventure")]
            Adventure,

            [Description("Action-Adventure")]
            ActionAdventure,

            [Description("Role-Playing Game")]
            RPG,

            [Description("Japanese Role-Playing Game")]
            JRPG,

            [Description("Shooter")]
            Shooter,

            [Description("Simulation")]
            Simulation,

            [Description("Strategy")]
            Strategy,

            [Description("Sports")]
            Sports,

            [Description("Puzzle")]
            Puzzle,

            [Description("Horror")]
            Horror,

            [Description("Mystery")]
            Mystery,

            [Description("Fighting")]
            Fighting,

            [Description("Racing")]
            Racing,

            [Description("Platformer")]
            Platformer,

            [Description("Sandbox")]
            Sandbox,

            [Description("Survival")]
            Survival,

            [Description("Massively Multiplayer Online")]
            MMO,

            [Description("Music")]
            Music,

            [Description("Educational")]
            Educational,

            [Description("Casual")]
            Casual,

            [Description("Family")]
            Family,

            [Description("Other")]
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
