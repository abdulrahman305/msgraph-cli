using ApiSdk.DeviceAppManagement.ManagedEBooks.Item.UserStateSummary.Item.DeviceStates.Item;
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
namespace ApiSdk.DeviceAppManagement.ManagedEBooks.Item.UserStateSummary.Item.DeviceStates {
    /// <summary>Builds and executes requests for operations under \deviceAppManagement\managedEBooks\{managedEBook-id}\userStateSummary\{userInstallStateSummary-id}\deviceStates</summary>
    public class DeviceStatesRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public List<Command> BuildCommand() {
            var builder = new DeviceInstallStateRequestBuilder(PathParameters, RequestAdapter);
            var commands = new List<Command> { 
                builder.BuildDeleteCommand(),
                builder.BuildGetCommand(),
                builder.BuildPatchCommand(),
            };
            return commands;
        }
        /// <summary>
        /// The install state of the eBook.
        /// </summary>
        public Command BuildCreateCommand() {
            var command = new Command("create");
            command.Description = "The install state of the eBook.";
            // Create options for all the parameters
            var managedEBookIdOption = new Option<string>("--managedebook-id", description: "key: id of managedEBook");
            managedEBookIdOption.IsRequired = true;
            command.AddOption(managedEBookIdOption);
            var userInstallStateSummaryIdOption = new Option<string>("--userinstallstatesummary-id", description: "key: id of userInstallStateSummary");
            userInstallStateSummaryIdOption.IsRequired = true;
            command.AddOption(userInstallStateSummaryIdOption);
            var bodyOption = new Option<string>("--body");
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.Handler = CommandHandler.Create<string, string, string>(async (managedEBookId, userInstallStateSummaryId, body) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<DeviceInstallState>();
                var requestInfo = CreatePostRequestInformation(model, q => {
                });
                var result = await RequestAdapter.SendAsync<DeviceInstallState>(requestInfo);
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
        /// The install state of the eBook.
        /// </summary>
        public Command BuildListCommand() {
            var command = new Command("list");
            command.Description = "The install state of the eBook.";
            // Create options for all the parameters
            var managedEBookIdOption = new Option<string>("--managedebook-id", description: "key: id of managedEBook");
            managedEBookIdOption.IsRequired = true;
            command.AddOption(managedEBookIdOption);
            var userInstallStateSummaryIdOption = new Option<string>("--userinstallstatesummary-id", description: "key: id of userInstallStateSummary");
            userInstallStateSummaryIdOption.IsRequired = true;
            command.AddOption(userInstallStateSummaryIdOption);
            var topOption = new Option<int?>("--top", description: "Show only the first n items");
            topOption.IsRequired = false;
            command.AddOption(topOption);
            var skipOption = new Option<int?>("--skip", description: "Skip the first n items");
            skipOption.IsRequired = false;
            command.AddOption(skipOption);
            var searchOption = new Option<string>("--search", description: "Search items by search phrases");
            searchOption.IsRequired = false;
            command.AddOption(searchOption);
            var filterOption = new Option<string>("--filter", description: "Filter items by property values");
            filterOption.IsRequired = false;
            command.AddOption(filterOption);
            var countOption = new Option<bool?>("--count", description: "Include count of items");
            countOption.IsRequired = false;
            command.AddOption(countOption);
            var orderbyOption = new Option<string[]>("--orderby", description: "Order items by property values");
            orderbyOption.IsRequired = false;
            orderbyOption.Arity = ArgumentArity.ZeroOrMore;
            command.AddOption(orderbyOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned");
            selectOption.IsRequired = false;
            selectOption.Arity = ArgumentArity.ZeroOrMore;
            command.AddOption(selectOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities");
            expandOption.IsRequired = false;
            expandOption.Arity = ArgumentArity.ZeroOrMore;
            command.AddOption(expandOption);
            command.Handler = CommandHandler.Create<string, string, int?, int?, string, string, bool?, string[], string[], string[]>(async (managedEBookId, userInstallStateSummaryId, top, skip, search, filter, count, orderby, select, expand) => {
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Top = top;
                    q.Skip = skip;
                    if (!String.IsNullOrEmpty(search)) q.Search = search;
                    if (!String.IsNullOrEmpty(filter)) q.Filter = filter;
                    q.Count = count;
                    q.Orderby = orderby;
                    q.Select = select;
                    q.Expand = expand;
                });
                var result = await RequestAdapter.SendAsync<DeviceStatesResponse>(requestInfo);
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
        /// Instantiates a new DeviceStatesRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceStatesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement/managedEBooks/{managedEBook_id}/userStateSummary/{userInstallStateSummary_id}/deviceStates{?top,skip,search,filter,count,orderby,select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The install state of the eBook.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The install state of the eBook.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePostRequestInformation(DeviceInstallState body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The install state of the eBook.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<DeviceStatesResponse> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<DeviceStatesResponse>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// The install state of the eBook.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<DeviceInstallState> PostAsync(DeviceInstallState model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePostRequestInformation(model, h, o);
            return await RequestAdapter.SendAsync<DeviceInstallState>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>The install state of the eBook.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Include count of items</summary>
            public bool? Count { get; set; }
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Filter items by property values</summary>
            public string Filter { get; set; }
            /// <summary>Order items by property values</summary>
            public string[] Orderby { get; set; }
            /// <summary>Search items by search phrases</summary>
            public string Search { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
            /// <summary>Skip the first n items</summary>
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            public int? Top { get; set; }
        }
    }
}
