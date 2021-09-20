
namespace MovieTutorial.Default.Entities
{
   
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Default"), TableName("[mov].[Movie]")]
    [DisplayName("Movies"), InstanceName("Movie")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        [DisplayName("Movie Id"), Identity]
        public Int32? MovieId
        {
            get { return Fields.MovieId[this]; }
            set { Fields.MovieId[this] = value; }
        }

        [DisplayName("Title"), Size(200), NotNull, QuickSearch]
        public String Title
        {
            get { return Fields.Title[this]; }
            set { Fields.Title[this] = value; }
        }

        [DisplayName("Description"), Size(1000), QuickSearch]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Storyline"), QuickSearch]
        public String Storyline
        {
            get { return Fields.Storyline[this]; }
            set { Fields.Storyline[this] = value; }
        }

        [DisplayName("Year"), QuickSearch(SearchType.Equals, numericOnly: 1)]
        public Int32? Year
        {
            get { return Fields.Year[this]; }
            set { Fields.Year[this] = value; }
        }

        [DisplayName("Release Date")]
        public DateTime? ReleaseDate
        {
            get { return Fields.ReleaseDate[this]; }
            set { Fields.ReleaseDate[this] = value; }
        }

        [DisplayName("Runtime (mins)")]
        public Int32? Runtime
        {
            get { return Fields.Runtime[this]; }
            set { Fields.Runtime[this] = value; }
        }


        [DisplayName("Kind"), NotNull, DefaultValue(MovieKind.Film)]
        public MovieKind? Kind
        {
            get => (MovieKind?)Fields.Kind[this];
            set => Fields.Kind[this] = (Int32?)value;
        }

        ////[DisplayName("Genre"), ForeignKey("[mov].Genre", "GenreId"), LeftJoin("g")]
        ////[LookupEditor(typeof(GenreRow), InplaceAdd = true)]

        //public Int32? GenreId
        //{
        //    get => Fields.GenreId[this];
        //    set => Fields.GenreId[this] = value;
        //}

        //[DisplayName("Genre"), Expression("g.Name")]
        //public String GenreName
        //{
        //    get => Fields.GenreName[this];
        //    set => Fields.GenreName[this] = value;
        //}

        [MasterDetailRelation(foreignKey: "MovieId", IncludeColumns = "PersonFullname")]

        [DisplayName("Cast List"), NotMapped]
        public List<MovieCastRow> CastList
        {
            get => Fields.CastList[this];
            set => Fields.CastList[this] = value;
        }




        [DisplayName("Genres")]
        [LookupEditor(typeof(GenreRow), Multiple = true), NotMapped]
        [LinkingSetRelation(typeof(MovieGenresRow), "MovieId", "GenreId")]
        public List<Int32> GenreList
        {
            get => Fields.GenreList[this];
            set => Fields.GenreList[this] = value;
        }

        [DisplayName("Primary Image"), Size(100),
         ImageUploadEditor(FilenameFormat = "Movie/PrimaryImage/~")]
        public string PrimaryImage
        {
            get => Fields.PrimaryImage[this];
            set =>Fields.PrimaryImage[this] = value;
        }

        [DisplayName("Gallery Images"),
         MultipleImageUploadEditor(FilenameFormat = "Movie/GalleryImages/~")]
        public string GalleryImages
        {
            get => Fields.GalleryImages[this];
            set => Fields.GalleryImages[this] = value;
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.MovieId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Title; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MovieRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MovieId;
            public StringField Title;
            public StringField Description;
            public StringField Storyline;
            public Int32Field Year;
            public DateTimeField ReleaseDate;
            public Int32Field Runtime;
            public Int32Field Kind;
            //public Int32Field GenreId;
            //public StringField GenreName;

            public ListField<Int32> GenreList;
            public RowListField<MovieCastRow> CastList;
            public StringField PrimaryImage;
            public StringField GalleryImages;


        }
    }
}
