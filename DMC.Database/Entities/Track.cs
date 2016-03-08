using ServiceStack.DataAnnotations;

namespace DMC.Database.Entities
{
    public class Track : AlbumInfo
    {
        [PrimaryKey]
        public long TrackId { get; set; }

        [ForeignKey(typeof(Album), ForeignKeyName = "AlbumId")]
        public long AlbumId { get; set; }

        [StringLength(DbSchema.LabelLength)]
        public string TrackName { get; set; }

        public int? TrackNumber { get; set; }

        public TrackFormat TrackFormat { get; set; }

        [StringLength(DbSchema.PathLength)]
        public string FilePath { get; set; }
    }
}
