using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace poc.Core.Connectors.Gim.Contracts {

    public sealed class AuthenticateResponse {

        public int TokenExpirationInMinutes { get; set; }
        public bool Status { get; set; }
        public List<Report> OperationReport { get; set; }
        public int InternalExecutionTime { get; set; }
        public int ExternalExecutionTime { get; set; }
        public int TotalExecutionTime { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
