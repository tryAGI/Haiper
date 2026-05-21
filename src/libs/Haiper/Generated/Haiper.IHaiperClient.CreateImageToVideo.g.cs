#nullable enable

namespace Haiper
{
    public partial interface IHaiperClient
    {
        /// <summary>
        /// Animate an image with Haiper 2.x.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Haiper.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Haiper.NewCreation> CreateImageToVideoAsync(

            global::Haiper.ImageToVideoRequest request,
            global::Haiper.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Animate an image with Haiper 2.x.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Haiper.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Haiper.AutoSDKHttpResponse<global::Haiper.NewCreation>> CreateImageToVideoAsResponseAsync(

            global::Haiper.ImageToVideoRequest request,
            global::Haiper.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Animate an image with Haiper 2.x.
        /// </summary>
        /// <param name="isPublic"></param>
        /// <param name="isEnablePromptEnhancer"></param>
        /// <param name="prompt"></param>
        /// <param name="negativePrompt"></param>
        /// <param name="genMode"></param>
        /// <param name="config"></param>
        /// <param name="settings"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Haiper.NewCreation> CreateImageToVideoAsync(
            string prompt,
            global::Haiper.ImageToVideoConfig config,
            bool? isPublic = default,
            bool? isEnablePromptEnhancer = default,
            string? negativePrompt = default,
            global::Haiper.ImageToVideoRequestGenMode? genMode = default,
            global::Haiper.VideoSettings? settings = default,
            global::Haiper.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}