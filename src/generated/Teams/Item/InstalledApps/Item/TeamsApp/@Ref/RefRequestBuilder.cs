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
namespace ApiSdk.Teams.Item.InstalledApps.Item.TeamsApp.@Ref {
    /// <summary>Builds and executes requests for operations under \teams\{team-id}\installedApps\{teamsAppInstallation-id}\teamsApp\$ref</summary>
    public class RefRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// The app that is installed.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "The app that is installed.";
            // Create options for all the parameters
            var teamIdOption = new Option<string>("--team-id", description: "key: id of team");
            teamIdOption.IsRequired = true;
            command.AddOption(teamIdOption);
            var teamsAppInstallationIdOption = new Option<string>("--teamsappinstallation-id", description: "key: id of teamsAppInstallation");
            teamsAppInstallationIdOption.IsRequired = true;
            command.AddOption(teamsAppInstallationIdOption);
            command.Handler = CommandHandler.Create<string, string>(async (teamId, teamsAppInstallationId) => {
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// The app that is installed.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The app that is installed.";
            // Create options for all the parameters
            var teamIdOption = new Option<string>("--team-id", description: "key: id of team");
            teamIdOption.IsRequired = true;
            command.AddOption(teamIdOption);
            var teamsAppInstallationIdOption = new Option<string>("--teamsappinstallation-id", description: "key: id of teamsAppInstallation");
            teamsAppInstallationIdOption.IsRequired = true;
            command.AddOption(teamsAppInstallationIdOption);
            command.Handler = CommandHandler.Create<string, string>(async (teamId, teamsAppInstallationId) => {
                var requestInfo = CreateGetRequestInformation(q => {
                });
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
        /// The app that is installed.
        /// </summary>
        public Command BuildPutCommand() {
            var command = new Command("put");
            command.Description = "The app that is installed.";
            // Create options for all the parameters
            var teamIdOption = new Option<string>("--team-id", description: "key: id of team");
            teamIdOption.IsRequired = true;
            command.AddOption(teamIdOption);
            var teamsAppInstallationIdOption = new Option<string>("--teamsappinstallation-id", description: "key: id of teamsAppInstallation");
            teamsAppInstallationIdOption.IsRequired = true;
            command.AddOption(teamsAppInstallationIdOption);
            var bodyOption = new Option<string>("--body");
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.Handler = CommandHandler.Create<string, string, string>(async (teamId, teamsAppInstallationId, body) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Teams.Item.InstalledApps.Item.TeamsApp.@Ref.@Ref>();
                var requestInfo = CreatePutRequestInformation(model, q => {
                });
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
            UrlTemplate = "{+baseurl}/teams/{team_id}/installedApps/{teamsAppInstallation_id}/teamsApp/$ref";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The app that is installed.
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
        /// The app that is installed.
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
        /// The app that is installed.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePutRequestInformation(ApiSdk.Teams.Item.InstalledApps.Item.TeamsApp.@Ref.@Ref body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// The app that is installed.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// The app that is installed.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<string> GetAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(h, o);
            return await RequestAdapter.SendPrimitiveAsync<string>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// The app that is installed.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PutAsync(ApiSdk.Teams.Item.InstalledApps.Item.TeamsApp.@Ref.@Ref model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePutRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
    }
}
