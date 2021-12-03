using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ApiSdk.DeviceManagement.TermsAndConditions.Item.AcceptanceStatuses.Item.TermsAndConditions.@Ref {
    /// <summary>Builds and executes requests for operations under \deviceManagement\termsAndConditions\{termsAndConditions-id}\acceptanceStatuses\{termsAndConditionsAcceptanceStatus-id}\termsAndConditions\$ref</summary>
    public class RefRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Navigation link to the terms and conditions that are assigned.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            // Create options for all the parameters
            command.AddOption(new Option<string>("--termsandconditions-id", description: "key: id of termsAndConditions"));
            command.AddOption(new Option<string>("--termsandconditionsacceptancestatus-id", description: "key: id of termsAndConditionsAcceptanceStatus"));
            command.Handler = CommandHandler.Create<string, string>(async (termsAndConditionsId, termsAndConditionsAcceptanceStatusId) => {
                var requestInfo = CreateDeleteRequestInformation();
                if (!String.IsNullOrEmpty(termsAndConditionsId)) requestInfo.PathParameters.Add("termsAndConditions_id", termsAndConditionsId);
                if (!String.IsNullOrEmpty(termsAndConditionsAcceptanceStatusId)) requestInfo.PathParameters.Add("termsAndConditionsAcceptanceStatus_id", termsAndConditionsAcceptanceStatusId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Navigation link to the terms and conditions that are assigned.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            // Create options for all the parameters
            command.AddOption(new Option<string>("--termsandconditions-id", description: "key: id of termsAndConditions"));
            command.AddOption(new Option<string>("--termsandconditionsacceptancestatus-id", description: "key: id of termsAndConditionsAcceptanceStatus"));
            command.Handler = CommandHandler.Create<string, string>(async (termsAndConditionsId, termsAndConditionsAcceptanceStatusId) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(termsAndConditionsId)) requestInfo.PathParameters.Add("termsAndConditions_id", termsAndConditionsId);
                if (!String.IsNullOrEmpty(termsAndConditionsAcceptanceStatusId)) requestInfo.PathParameters.Add("termsAndConditionsAcceptanceStatus_id", termsAndConditionsAcceptanceStatusId);
                var result = await RequestAdapter.SendPrimitiveAsync<string>(requestInfo);
                // Print request output. What if the request has no return?
                using var serializer = RequestAdapter.SerializationWriterFactory.GetSerializationWriter("application/json");
                serializer.WriteStringValue(null, result);
                using var content = serializer.GetSerializedContent();
                using var reader = new StreamReader(content);
                var strContent = await reader.ReadToEndAsync();
                Console.Write(strContent + "\n");
            });
            return command;
        }
        /// <summary>
        /// Navigation link to the terms and conditions that are assigned.
        /// </summary>
        public Command BuildPutCommand() {
            var command = new Command("put");
            // Create options for all the parameters
            command.AddOption(new Option<string>("--termsandconditions-id", description: "key: id of termsAndConditions"));
            command.AddOption(new Option<string>("--termsandconditionsacceptancestatus-id", description: "key: id of termsAndConditionsAcceptanceStatus"));
            command.AddOption(new Option<string>("--body"));
            command.Handler = CommandHandler.Create<string, string, string>(async (termsAndConditionsId, termsAndConditionsAcceptanceStatusId, body) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.DeviceManagement.TermsAndConditions.Item.AcceptanceStatuses.Item.TermsAndConditions.@Ref.@Ref>();
                var requestInfo = CreatePutRequestInformation(model);
                if (!String.IsNullOrEmpty(termsAndConditionsId)) requestInfo.PathParameters.Add("termsAndConditions_id", termsAndConditionsId);
                if (!String.IsNullOrEmpty(termsAndConditionsAcceptanceStatusId)) requestInfo.PathParameters.Add("termsAndConditionsAcceptanceStatus_id", termsAndConditionsAcceptanceStatusId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new RefRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public RefRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/termsAndConditions/{termsAndConditions_id}/acceptanceStatuses/{termsAndConditionsAcceptanceStatus_id}/termsAndConditions/$ref";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Navigation link to the terms and conditions that are assigned.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Navigation link to the terms and conditions that are assigned.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Navigation link to the terms and conditions that are assigned.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePutRequestInformation(ApiSdk.DeviceManagement.TermsAndConditions.Item.AcceptanceStatuses.Item.TermsAndConditions.@Ref.@Ref body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.PUT,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Navigation link to the terms and conditions that are assigned.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Navigation link to the terms and conditions that are assigned.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<string> GetAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(h, o);
            return await RequestAdapter.SendPrimitiveAsync<string>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Navigation link to the terms and conditions that are assigned.
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PutAsync(ApiSdk.DeviceManagement.TermsAndConditions.Item.AcceptanceStatuses.Item.TermsAndConditions.@Ref.@Ref model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePutRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
    }
}
