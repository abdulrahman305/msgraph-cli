// <auto-generated/>
using ApiSdk.IdentityGovernance.EntitlementManagement.AssignmentRequests.Item.AccessPackage;
using ApiSdk.IdentityGovernance.EntitlementManagement.AssignmentRequests.Item.Assignment;
using ApiSdk.IdentityGovernance.EntitlementManagement.AssignmentRequests.Item.Cancel;
using ApiSdk.IdentityGovernance.EntitlementManagement.AssignmentRequests.Item.Reprocess;
using ApiSdk.IdentityGovernance.EntitlementManagement.AssignmentRequests.Item.Requestor;
using ApiSdk.IdentityGovernance.EntitlementManagement.AssignmentRequests.Item.Resume;
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
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
namespace ApiSdk.IdentityGovernance.EntitlementManagement.AssignmentRequests.Item
{
    /// <summary>
    /// Provides operations to manage the assignmentRequests property of the microsoft.graph.entitlementManagement entity.
    /// </summary>
    public class AccessPackageAssignmentRequestItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the accessPackage property of the microsoft.graph.accessPackageAssignmentRequest entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAccessPackageNavCommand()
        {
            var command = new Command("access-package");
            command.Description = "Provides operations to manage the accessPackage property of the microsoft.graph.accessPackageAssignmentRequest entity.";
            var builder = new AccessPackageRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the assignment property of the microsoft.graph.accessPackageAssignmentRequest entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildAssignmentNavCommand()
        {
            var command = new Command("assignment");
            command.Description = "Provides operations to manage the assignment property of the microsoft.graph.accessPackageAssignmentRequest entity.";
            var builder = new AssignmentRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the cancel method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCancelNavCommand()
        {
            var command = new Command("cancel");
            command.Description = "Provides operations to call the cancel method.";
            var builder = new CancelRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Delete an accessPackageAssignmentRequest object. This request can be made to remove a denied or completed request.  You cannot delete an access package assignment request if it has any accessPackageAssignment objects.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accesspackageassignmentrequest-delete?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete an accessPackageAssignmentRequest object. This request can be made to remove a denied or completed request.  You cannot delete an access package assignment request if it has any accessPackageAssignment objects.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/accesspackageassignmentrequest-delete?view=graph-rest-1.0";
            var accessPackageAssignmentRequestIdOption = new Option<string>("--access-package-assignment-request-id", description: "The unique identifier of accessPackageAssignmentRequest") {
            };
            accessPackageAssignmentRequestIdOption.IsRequired = true;
            command.AddOption(accessPackageAssignmentRequestIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var accessPackageAssignmentRequestId = invocationContext.ParseResult.GetValueForOption(accessPackageAssignmentRequestIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (accessPackageAssignmentRequestId is not null) requestInfo.PathParameters.Add("accessPackageAssignmentRequest%2Did", accessPackageAssignmentRequestId);
                if (ifMatch is not null) requestInfo.Headers.Add("If-Match", ifMatch);
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
        /// In Microsoft Entra entitlement management, retrieve the properties and relationships of an  accessPackageAssignmentRequest object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accesspackageassignmentrequest-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "In Microsoft Entra entitlement management, retrieve the properties and relationships of an  accessPackageAssignmentRequest object.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/accesspackageassignmentrequest-get?view=graph-rest-1.0";
            var accessPackageAssignmentRequestIdOption = new Option<string>("--access-package-assignment-request-id", description: "The unique identifier of accessPackageAssignmentRequest") {
            };
            accessPackageAssignmentRequestIdOption.IsRequired = true;
            command.AddOption(accessPackageAssignmentRequestIdOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned") {
                Arity = ArgumentArity.ZeroOrMore
            };
            selectOption.IsRequired = false;
            command.AddOption(selectOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities") {
                Arity = ArgumentArity.ZeroOrMore
            };
            expandOption.IsRequired = false;
            command.AddOption(expandOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var accessPackageAssignmentRequestId = invocationContext.ParseResult.GetValueForOption(accessPackageAssignmentRequestIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (accessPackageAssignmentRequestId is not null) requestInfo.PathParameters.Add("accessPackageAssignmentRequest%2Did", accessPackageAssignmentRequestId);
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
        /// Update the navigation property assignmentRequests in identityGovernance
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update the navigation property assignmentRequests in identityGovernance";
            var accessPackageAssignmentRequestIdOption = new Option<string>("--access-package-assignment-request-id", description: "The unique identifier of accessPackageAssignmentRequest") {
            };
            accessPackageAssignmentRequestIdOption.IsRequired = true;
            command.AddOption(accessPackageAssignmentRequestIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var accessPackageAssignmentRequestId = invocationContext.ParseResult.GetValueForOption(accessPackageAssignmentRequestIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<AccessPackageAssignmentRequest>(AccessPackageAssignmentRequest.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (accessPackageAssignmentRequestId is not null) requestInfo.PathParameters.Add("accessPackageAssignmentRequest%2Did", accessPackageAssignmentRequestId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
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
        /// Provides operations to call the reprocess method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildReprocessNavCommand()
        {
            var command = new Command("reprocess");
            command.Description = "Provides operations to call the reprocess method.";
            var builder = new ReprocessRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the requestor property of the microsoft.graph.accessPackageAssignmentRequest entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildRequestorNavCommand()
        {
            var command = new Command("requestor");
            command.Description = "Provides operations to manage the requestor property of the microsoft.graph.accessPackageAssignmentRequest entity.";
            var builder = new RequestorRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the resume method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildResumeNavCommand()
        {
            var command = new Command("resume");
            command.Description = "Provides operations to call the resume method.";
            var builder = new ResumeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="AccessPackageAssignmentRequestItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public AccessPackageAssignmentRequestItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/entitlementManagement/assignmentRequests/{accessPackageAssignmentRequest%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="AccessPackageAssignmentRequestItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AccessPackageAssignmentRequestItemRequestBuilder(string rawUrl) : base("{+baseurl}/identityGovernance/entitlementManagement/assignmentRequests/{accessPackageAssignmentRequest%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete an accessPackageAssignmentRequest object. This request can be made to remove a denied or completed request.  You cannot delete an access package assignment request if it has any accessPackageAssignment objects.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// In Microsoft Entra entitlement management, retrieve the properties and relationships of an  accessPackageAssignmentRequest object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AccessPackageAssignmentRequestItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AccessPackageAssignmentRequestItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property assignmentRequests in identityGovernance
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(AccessPackageAssignmentRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(AccessPackageAssignmentRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// In Microsoft Entra entitlement management, retrieve the properties and relationships of an  accessPackageAssignmentRequest object.
        /// </summary>
        public class AccessPackageAssignmentRequestItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
    }
}
