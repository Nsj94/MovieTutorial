
namespace MovieTutorial.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.MovieCast")]
    [BasedOnRow(typeof(Entities.MovieCastRow), CheckNames = true)]
    public class MovieCastForm
    {
    //    public Int32 MovieId { get; set; }
        public Int32 PersonId { get; set; }
        public String Character { get; set; }
    }
}