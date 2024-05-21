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
namespace ApiSdk.DeviceManagement.RemoteAssistancePartners.Item.BeginOnboarding
{
    /// <summary>
    /// Provides operations to call the beginOnboarding method.
    /// </summary>
    public class BeginOnboardingRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// A request to start onboarding.  Must be coupled with the appropriate TeamViewer account information
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-remoteassistance-remoteassistancepartner-beginonboarding?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPostCommand()
        {
            var command = new Command("post");
            command.Description = "A request to start onboarding.  Must be coupled with the appropriate TeamViewer account information\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/intune-remoteassistance-remoteassistancepartner-beginonboarding?view=graph-rest-1.0";
            var remoteAssistancePartnerIdOption = new Option<string>("--remote-assistance-partner-id", description: "The unique identifier of remoteAssistancePartner") {
            };
            remoteAssistancePartnerIdOption.IsRequired = true;
            command.AddOption(remoteAssistancePartnerIdOption);
            command.SetHandler(async (invocationContext) => {
                var remoteAssistancePartnerId = invocationContext.ParseResult.GetValueForOption(remoteAssistancePartnerIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (remoteAssistancePartnerId is not null) requestInfo.PathParameters.Add("remoteAssistancePartner%2Did", remoteAssistancePartnerId);
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
        /// Instantiates a new <see cref="BeginOnboardingRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public BeginOnboardingRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/deviceManagement/remoteAssistancePartners/{remoteAssistancePartner%2Did}/beginOnboarding", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="BeginOnboardingRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public BeginOnboardingRequestBuilder(string rawUrl) : base("{+baseurl}/deviceManagement/remoteAssistancePartners/{remoteAssistancePartner%2Did}/beginOnboarding", rawUrl)
        {
        }
        /// <summary>
        /// A request to start onboarding.  Must be coupled with the appropriate TeamViewer account information
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
