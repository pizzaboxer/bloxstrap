namespace LumenRX.Models.APIs.Roblox
{
    internal class ThumbnailBatchResponse
    {
        [JsonPropertyName("data")]
        public ThumbnailResponse[] Data { get; set; } = Array.Empty<ThumbnailResponse>();
    }
}
