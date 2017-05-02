using Orchard.UI.Resources;

namespace TheBootstrap4Machine {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();
            manifest.DefineStyle("TheBootstrap4Machine").SetUrl("styles.min.css", "styles.css");
        }
    }
}
