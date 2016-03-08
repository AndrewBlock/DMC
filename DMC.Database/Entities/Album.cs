using ServiceStack.DataAnnotations;

namespace DMC.Database.Entities
{
    public class Album : AlbumInfo
    {
        [PrimaryKey]
        public long AlbumId { get; set; }

        public int? TotalTracks { get; set; }

        public int? DiscNumber { get; set; }

        public int? TotalDiscs { get; set; }
    }
}
