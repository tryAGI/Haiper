#nullable enable

namespace Haiper
{
    public partial interface IHaiperClient
    {
        /// <summary>
        /// Create a Haiper 2.x text-to-video generation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Haiper.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Haiper.NewCreation> CreateTextToVideoAsync(

            global::Haiper.TextToVideoRequest request,
            global::Haiper.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Haiper 2.x text-to-video generation.
        /// </summary>
        /// <param name="isPublic">
        /// Whether the generation is public on Haiper.
        /// </param>
        /// <param name="isEnablePromptEnhancer">
        /// Whether Haiper should enhance the prompt.
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="negativePrompt"></param>
        /// <param name="genMode"></param>
        /// <param name="settings"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Haiper.NewCreation> CreateTextToVideoAsync(
            string prompt,
            bool? isPublic = default,
            bool? isEnablePromptEnhancer = default,
            string? negativePrompt = default,
            global::Haiper.TextToVideoRequestGenMode? genMode = default,
            global::Haiper.VideoSettings? settings = default,
            global::Haiper.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}