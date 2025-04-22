using System;

namespace pipelines_dotnet_core.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        // test test

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
