namespace BlazorSoundboard.Data.Models
{
    public class TileInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl => $"/img/{Name.ToLowerInvariant()}.png";
        public string AudioUrl => $"/audio/{Name.ToLowerInvariant()}.mp3";
    }
}