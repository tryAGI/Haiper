#nullable enable

namespace Haiper
{
    public partial interface IHaiperClient
    {
        /// <summary>
        /// Create a Haiper 2.x keyframe-conditioned video from multiple images.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Haiper.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Haiper.NewCreation> CreateKeyframeConditioningAsync(

            global::Haiper.KeyframeConditioningRequest request,
            global::Haiper.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Haiper 2.x keyframe-conditioned video from multiple images.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Haiper.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Haiper.AutoSDKHttpResponse<global::Haiper.NewCreation>> CreateKeyframeConditioningAsResponseAsync(

            global::Haiper.KeyframeConditioningRequest request,
            global::Haiper.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Haiper 2.x keyframe-conditioned video from multiple images.
        /// </summary>
        /// <param name="isPublic"></param>
        /// <param name="prompt"></param>
        /// <param name="negativePrompt"></param>
        /// <param name="config"></param>
        /// <param name="settings"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Haiper.NewCreation> CreateKeyframeConditioningAsync(
            string prompt,
            global::Haiper.KeyframeConditioningRequestConfig config,
            bool? isPublic = default,
            string? negativePrompt = default,
            global::Haiper.VideoSettings? settings = default,
            global::Haiper.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}