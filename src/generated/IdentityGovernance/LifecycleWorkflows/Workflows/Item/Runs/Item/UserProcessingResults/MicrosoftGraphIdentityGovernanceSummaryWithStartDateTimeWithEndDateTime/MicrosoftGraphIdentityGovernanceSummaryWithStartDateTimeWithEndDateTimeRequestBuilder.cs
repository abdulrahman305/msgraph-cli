// <auto-generated/>
using ApiSdk.Models.IdentityGovernance;
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
namespace ApiSdk.IdentityGovernance.LifecycleWorkflows.Workflows.Item.Runs.Item.UserProcessingResults.MicrosoftGraphIdentityGovernanceSummaryWithStartDateTimeWithEndDateTime
{
    /// <summary>
    /// Provides operations to call the summary method.
    /// </summary>
    public class MicrosoftGraphIdentityGovernanceSummaryWithStartDateTimeWithEndDateTimeRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Invoke function summary
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Invoke function summary";
            var workflowIdOption = new Option<string>("--workflow-id", description: "The unique identifier of workflow") {
            };
            workflowIdOption.IsRequired = true;
            command.AddOption(workflowIdOption);
            var runIdOption = new Option<string>("--run-id", description: "The unique identifier of run") {
            };
            runIdOption.IsRequired = true;
            command.AddOption(runIdOption);
            var startDateTimeOption = new Option<string>("--start-date-time", description: "Usage: startDateTime={startDateTime}") {
            };
            startDateTimeOption.IsRequired = true;
            command.AddOption(startDateTimeOption);
            var endDateTimeOption = new Option<string>("--end-date-time", description: "Usage: endDateTime={endDateTime}") {
            };
            endDateTimeOption.IsRequired = true;
            command.AddOption(endDateTimeOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var workflowId = invocationContext.ParseResult.GetValueForOption(workflowIdOption);
                var runId = invocationContext.ParseResult.GetValueForOption(runIdOption);
                var startDateTime = invocationContext.ParseResult.GetValueForOption(startDateTimeOption);
                var endDateTime = invocationContext.ParseResult.GetValueForOption(endDateTimeOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (workflowId is not null) requestInfo.PathParameters.Add("workflow%2Did", workflowId);
                if (runId is not null) requestInfo.PathParameters.Add("run%2Did", runId);
                if (startDateTime is not null) requestInfo.PathParameters.Add("startDateTime", startDateTime);
                if (endDateTime is not null) requestInfo.PathParameters.Add("endDateTime", endDateTime);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="MicrosoftGraphIdentityGovernanceSummaryWithStartDateTimeWithEndDateTimeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MicrosoftGraphIdentityGovernanceSummaryWithStartDateTimeWithEndDateTimeRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/lifecycleWorkflows/workflows/{workflow%2Did}/runs/{run%2Did}/userProcessingResults/microsoft.graph.identityGovernance.summary(startDateTime={startDateTime},endDateTime={endDateTime})", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="MicrosoftGraphIdentityGovernanceSummaryWithStartDateTimeWithEndDateTimeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MicrosoftGraphIdentityGovernanceSummaryWithStartDateTimeWithEndDateTimeRequestBuilder(string rawUrl) : base("{+baseurl}/identityGovernance/lifecycleWorkflows/workflows/{workflow%2Did}/runs/{run%2Did}/userProcessingResults/microsoft.graph.identityGovernance.summary(startDateTime={startDateTime},endDateTime={endDateTime})", rawUrl)
        {
        }
        /// <summary>
        /// Invoke function summary
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
