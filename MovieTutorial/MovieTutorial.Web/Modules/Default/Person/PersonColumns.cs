
namespace MovieTutorial.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Person")]
    [BasedOnRow(typeof(Entities.PersonRow), CheckNames = true)]
    public class PersonColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 PersonId { get; set; }
        [EditLink]
     //   public String FirstName { get; set; }
       // public String Lastname { get; set; }
        
        public String Fullname { get; set; }
        
        public DateTime BirthDate { get; set; }
        public String BirthPlace { get; set; }
        public Int32 Gender { get; set; }
        public Int32 Height { get; set; }
    }
}