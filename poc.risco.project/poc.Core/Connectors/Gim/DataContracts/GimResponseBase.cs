using System.Collections.Generic;

namespace poc.Core.Connectors.Gim.DataContracts {

    public abstract class GimResponseBase {

        public bool Success { get; set; }

        public List<GimReport> OperationReport { get; set; } = new List<GimReport>();

        public int InternalExecutionTime { get; set; }

        public int ExternalExecutionTime { get; set; }

        public int TotalExecutionTime { get; set; }

        public int StatusCode { get; set; }
    }
}
