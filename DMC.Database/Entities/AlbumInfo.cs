using ServiceStack.DataAnnotations;

namespace DMC.Database.Entities
{
    public abstract class AlbumInfo
    {
        [StringLength(DbSchema.LabelLength)]
        public string AlbumName { get; set; }

        [StringLength(DbSchema.LabelLength)]
        public string AlbumArtist { get; set; }

        [StringLength(DbSchema.LabelLength)]
        public string Composer { get; set; }

        [StringLength(DbSchema.CommentsLength)]
        public string Comments { get; set; }

        [StringLength(DbSchema.GenreLength)]
        public string Genre { get; set; }

        [StringLength(DbSchema.YearLength)]
        public string Year { get; set; }
    }
}
