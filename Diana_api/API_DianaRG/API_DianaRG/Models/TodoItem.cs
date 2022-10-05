namespace API_DianaRG.Models
{
    public class TodoItem
    {
        public long Id { get; set; }

        public string SongName { get; set; } = "";
        public string AlbumName { get; set; } = "";
        public string ArtistName { get; set; } = "";
        public string uri_Album { get; set; } = "";
    }
}

