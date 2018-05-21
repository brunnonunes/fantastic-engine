using System.Collections.Generic;

namespace poc.Core.ServiceContracts {

    public abstract class ResponseBase {

        public bool Success { get; set; }

        public int StatusCode { get; set; }

        public List<Report> OperationReport { get; set; } = new List<Report>();
    }
}
