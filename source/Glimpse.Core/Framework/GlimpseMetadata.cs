using System.Collections.Generic;

namespace Glimpse.Core.Framework
{
    public class GlimpseMetadata
    {
        public GlimpseMetadata()
        {
            Plugins = new Dictionary<string, PluginMetadata>();

            // TODO: once the resources below are implemented, this constructor should just instantiate variable.
            Resources = new Dictionary<string, string>
                        {
                            { "paging", "NEED TO IMPLMENT RESOURCE Pager" }, // TODO: Implement resource
                            { "tab", "NEED TO IMPLMENT RESOURCE test-popup.html" }, // TODO: Implement resource
                        };
        }

        public string Version { get; set; }
        
        public IDictionary<string, PluginMetadata> Plugins { get; set; }
        
        public IDictionary<string, string> Resources { get; set; }
    }
}