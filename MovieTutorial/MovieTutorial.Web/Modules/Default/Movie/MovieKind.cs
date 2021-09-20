
namespace MovieTutorial.Default
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Web;
    using System.Web.Mvc;
    using System.ComponentModel;

    [EnumKey("MovieDB.MovieKind")]
    public enum MovieKind
    {
        [Description("Film")]
        Film = 1,
        [Description("TV Series")]
        TvSeries = 2,
        [Description("Mini Series")]
        MiniSeries = 3
    }
}