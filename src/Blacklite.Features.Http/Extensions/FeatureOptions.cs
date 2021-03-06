using Blacklite.Features.Editors;
using Microsoft.AspNet.FileProviders;
using System;
using System.IO;
using System.Reflection;

namespace Blacklite.Features.Http.Extensions
{
    public class FeatureOptions
    {
        public FeatureOptions(string basePath)
        {
            FileProvider = new EmbeddedFileProvider(typeof(FeatureOptions).GetTypeInfo().Assembly, "Blacklite.Features.Http");
                _layout = new Lazy<string>(() =>
            {
                using (var stream = FileProvider.GetFileInfo("compiler/resources/layout.html").CreateReadStream())
                using (var streamReader = new StreamReader(stream))
                {
                    return streamReader.ReadToEnd().Replace("~", $"{basePath}/compiler/resources");
                }
            });
        }

        public IFeatureEditorFactory Factory { get; set; }
        public IFileProvider FileProvider { get; set; }
        public string Path { get; set; } = "/";

        private readonly Lazy<string> _layout;
        private string _realizedLayout;
        public string Layout
        {
            get { return _realizedLayout ?? _layout.Value; }
            set { _realizedLayout = value; }
        }

        public string Title { get; set; } = "Features";
    }
}
