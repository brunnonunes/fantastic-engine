using System;
using System.Net;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using poc.Core.ConfigurationSettings;
using poc.Core.Connectors.Gim.DataContracts;
using RestSharp;
using RestClient = RestSharp.RestClient;

namespace poc.Core.Connectors.Gim {

    public sealed class GimConnector {

        //private GimSettings _gimSettings { get; set; }

        //public GimConnector(IOptions<GimSettings> gimSettings) { this._gimSettings = gimSettings.Value; }

        public GimAuthenticateResponse Authenticate(GimAuthenticateRequest request) {

            GimAuthenticateResponse response = new GimAuthenticateResponse();

            try {

                RestClient restClient = new RestClient("https://gim.stone.com.br"); // TODO: passar para o appsettings.

                //RestClient restClient = new RestClient(_gimSettings.ProductionDomain); 

                var restRequest = new RestRequest("/api/authorization/authenticate", Method.POST); // TODO

                string contentAsJson = JsonConvert.SerializeObject(request);

                restRequest.AddParameter("application/json; charset=utf-8", contentAsJson, ParameterType.RequestBody);

                restRequest.RequestFormat = DataFormat.Json;

                IRestResponse restResponse = restClient.Execute(restRequest);

                response = JsonConvert.DeserializeObject<GimAuthenticateResponse>(restResponse.Content);
            }
            catch (Exception e) {
                response.OperationReport.Add(new GimReport { Field = e.Source, Message = e.Message });
                response.StatusCode = (int)HttpStatusCode.InternalServerError;
                return response;
            }

            return response;
        }
    }
}
