using Glimpse.Core.Framework;

namespace Glimpse.Core.Extensibility
{
    public class ResourceResultContext : IResourceResultContext
    {
        public ResourceResultContext(ILogger logger, IFrameworkProvider frameworkProvider, ISerializer serializer, IHtmlEncoder htmlEncoder)
        {
            Logger = logger;
            FrameworkProvider = frameworkProvider;
            Serializer = serializer;
            HtmlEncoder = htmlEncoder;
        }

        public ILogger Logger { get; set; }

        public IFrameworkProvider FrameworkProvider { get; set; }

        public ISerializer Serializer { get; set; }

        public IHtmlEncoder HtmlEncoder { get; set; }
    }
}