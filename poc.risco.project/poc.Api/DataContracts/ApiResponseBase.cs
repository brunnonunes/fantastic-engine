using System.Collections.Generic;
using System.Net;

namespace poc.Api.DataContracts {
    public abstract class ApiResponseBase {

        public bool Success { get; set; }

        public List<ApiReport> OperationReport { get; set; } = new List<ApiReport>();
    }
}
