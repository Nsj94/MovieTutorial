
namespace MovieTutorial.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Person")]
    [BasedOnRow(typeof(Entities.PersonRow), CheckNames = true)]
    public class PersonForm
    {
        public String FirstName { get; set; }
        public String Lastname { get; set; }

        public String PrimaryImage { get; set; }
        public String GalleryImages { get; set; }

        public DateTime BirthDate { get; set; }
        public String BirthPlace { get; set; }
        public Int32 Gender { get; set; }
        public Int32 Height { get; set; }
    }
}