using System;

namespace pipelines_dotnet_core.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        // testss

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
