using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRange.OffsetRangeWithRowOffsetWithColumnOffset {
    /// <summary>Builds and executes requests for operations under \me\insights\shared\{sharedInsight-id}\lastSharedMethod\microsoft.graph.workbookRange\microsoft.graph.offsetRange(rowOffset={rowOffset},columnOffset={columnOffset})</summary>
    public class OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Invoke function offsetRange
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Invoke function offsetRange";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--sharedinsight-id", description: "key: id of sharedInsight"));
            command.AddOption(new Option<int?>("--rowoffset", description: "Usage: rowOffset={rowOffset}"));
            command.AddOption(new Option<int?>("--columnoffset", description: "Usage: columnOffset={columnOffset}"));
            command.Handler = CommandHandler.Create<string, int?, int?>(async (sharedInsightId, rowOffset, columnOffset) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(sharedInsightId)) requestInfo.PathParameters.Add("sharedInsight_id", sharedInsightId);
                requestInfo.PathParameters.Add("rowOffset", rowOffset);
                requestInfo.PathParameters.Add("columnOffset", columnOffset);
                var result = await RequestAdapter.SendAsync<OffsetRangeWithRowOffsetWithColumnOffsetResponse>(requestInfo);
                // Print request output. What if the request has no return?
                using var serializer = RequestAdapter.SerializationWriterFactory.GetSerializationWriter("application/json");
                serializer.WriteObjectValue(null, result);
                using var content = serializer.GetSerializedContent();
                using var reader = new StreamReader(content);
                var strContent = await reader.ReadToEndAsync();
                Console.Write(strContent + "\n");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder and sets the default values.
        /// <param name="columnOffset">Usage: columnOffset={columnOffset}</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="rowOffset">Usage: rowOffset={rowOffset}</param>
        /// </summary>
        public OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, int? rowOffset = default, int? columnOffset = default) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/insights/shared/{sharedInsight_id}/lastSharedMethod/microsoft.graph.workbookRange/microsoft.graph.offsetRange(rowOffset={rowOffset},columnOffset={columnOffset})";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            urlTplParams.Add("rowOffset", rowOffset);
            urlTplParams.Add("columnOffset", columnOffset);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke function offsetRange
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
        /// Invoke function offsetRange
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<OffsetRangeWithRowOffsetWithColumnOffsetResponse> GetAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(h, o);
            return await RequestAdapter.SendAsync<OffsetRangeWithRowOffsetWithColumnOffsetResponse>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>Union type wrapper for classes workbookRange</summary>
        public class OffsetRangeWithRowOffsetWithColumnOffsetResponse : IParsable {
            /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
            public IDictionary<string, object> AdditionalData { get; set; }
            /// <summary>Union type representation for type workbookRange</summary>
            public ApiSdk.Models.Microsoft.Graph.WorkbookRange WorkbookRange { get; set; }
            /// <summary>
            /// Instantiates a new offsetRangeWithRowOffsetWithColumnOffsetResponse and sets the default values.
            /// </summary>
            public OffsetRangeWithRowOffsetWithColumnOffsetResponse() {
                AdditionalData = new Dictionary<string, object>();
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
                return new Dictionary<string, Action<T, IParseNode>> {
                    {"workbookRange", (o,n) => { (o as OffsetRangeWithRowOffsetWithColumnOffsetResponse).WorkbookRange = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookRange>(); } },
                };
            }
            /// <summary>
            /// Serializes information the current object
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            /// </summary>
            public void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.WorkbookRange>("workbookRange", WorkbookRange);
                writer.WriteAdditionalData(AdditionalData);
            }
        }
    }
}
