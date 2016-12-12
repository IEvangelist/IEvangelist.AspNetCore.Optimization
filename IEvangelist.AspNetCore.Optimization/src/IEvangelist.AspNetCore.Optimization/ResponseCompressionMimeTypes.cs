using System.Collections.Generic;
using System.Linq;

using static Microsoft.AspNetCore.ResponseCompression.ResponseCompressionDefaults;

namespace IEvangelist.AspNetCore.Optimization
{
    public static class ResponseCompressionMimeTypes
    {
        public static IEnumerable<string> Defaults
            => MimeTypes.Concat(new[]
                                {
                                    "image/svg+xml",
                                    "application/font-woff2"
                                });
    }
}