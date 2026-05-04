#nullable enable

namespace Haiper
{
    public partial interface IHaiperClient
    {
        /// <summary>
        /// Create a watermark-free URL for a video creation.
        /// </summary>
        /// <param name="creationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Haiper.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Haiper.WatermarkFreeUrl> CreateWatermarkFreeUrlAsync(
            string creationId,
            global::Haiper.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}