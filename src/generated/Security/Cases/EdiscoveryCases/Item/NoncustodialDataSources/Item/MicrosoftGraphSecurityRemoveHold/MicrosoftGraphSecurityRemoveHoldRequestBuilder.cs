// <auto-generated/>
using ApiSdk.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.Item.MicrosoftGraphSecurityRemoveHold
{
    /// <summary>
    /// Provides operations to call the removeHold method.
    /// </summary>
    public class MicrosoftGraphSecurityRemoveHoldRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Start the process of removing hold from eDiscovery non-custodial data sources. After the operation is created, you can get the status by retrieving the Location parameter from the response headers. The location provides a URL that returns an eDiscoveryHoldOperation object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/security-ediscoverynoncustodialdatasource-removehold?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "Start the process of removing hold from eDiscovery non-custodial data sources. After the operation is created, you can get the status by retrieving the Location parameter from the response headers. The location provides a URL that returns an eDiscoveryHoldOperation object.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/security-ediscoverynoncustodialdatasource-removehold?view=graph-rest-1.0";
            var ediscoveryCaseIdOption = new Option<string>("--ediscovery-case-id", description: "The unique identifier of ediscoveryCase") {
            };
            ediscoveryCaseIdOption.IsRequired = true;
            command.AddOption(ediscoveryCaseIdOption);
            var ediscoveryNoncustodialDataSourceIdOption = new Option<string>("--ediscovery-noncustodial-data-source-id", description: "The unique identifier of ediscoveryNoncustodialDataSource") {
            };
            ediscoveryNoncustodialDataSourceIdOption.IsRequired = true;
            command.AddOption(ediscoveryNoncustodialDataSourceIdOption);
            command.SetHandler(async (invocationContext) => {
                var ediscoveryCaseId = invocationContext.ParseResult.GetValueForOption(ediscoveryCaseIdOption);
                var ediscoveryNoncustodialDataSourceId = invocationContext.ParseResult.GetValueForOption(ediscoveryNoncustodialDataSourceIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (ediscoveryCaseId is not null) requestInfo.PathParameters.Add("ediscoveryCase%2Did", ediscoveryCaseId);
                if (ediscoveryNoncustodialDataSourceId is not null) requestInfo.PathParameters.Add("ediscoveryNoncustodialDataSource%2Did", ediscoveryNoncustodialDataSourceId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="MicrosoftGraphSecurityRemoveHoldRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MicrosoftGraphSecurityRemoveHoldRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/security/cases/ediscoveryCases/{ediscoveryCase%2Did}/noncustodialDataSources/{ediscoveryNoncustodialDataSource%2Did}/microsoft.graph.security.removeHold", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="MicrosoftGraphSecurityRemoveHoldRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MicrosoftGraphSecurityRemoveHoldRequestBuilder(string rawUrl) : base("{+baseurl}/security/cases/ediscoveryCases/{ediscoveryCase%2Did}/noncustodialDataSources/{ediscoveryNoncustodialDataSource%2Did}/microsoft.graph.security.removeHold", rawUrl)
        {
        }
        /// <summary>
        /// Start the process of removing hold from eDiscovery non-custodial data sources. After the operation is created, you can get the status by retrieving the Location parameter from the response headers. The location provides a URL that returns an eDiscoveryHoldOperation object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
