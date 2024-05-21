// <auto-generated/>
using ApiSdk.Education.Classes.Item.Modules.Item.Pin;
using ApiSdk.Education.Classes.Item.Modules.Item.Publish;
using ApiSdk.Education.Classes.Item.Modules.Item.Resources;
using ApiSdk.Education.Classes.Item.Modules.Item.SetUpResourcesFolder;
using ApiSdk.Education.Classes.Item.Modules.Item.Unpin;
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
namespace ApiSdk.Education.Classes.Item.Modules.Item
{
    /// <summary>
    /// Provides operations to manage the modules property of the microsoft.graph.educationClass entity.
    /// </summary>
    public class EducationModuleItemRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Delete an existing module in a class. Only teachers within a class can delete modules.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/educationmodule-delete?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildDeleteCommand()
        {
            var command = new Command("delete");
            command.Description = "Delete an existing module in a class. Only teachers within a class can delete modules.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/educationmodule-delete?view=graph-rest-1.0";
            var educationClassIdOption = new Option<string>("--education-class-id", description: "The unique identifier of educationClass") {
            };
            educationClassIdOption.IsRequired = true;
            command.AddOption(educationClassIdOption);
            var educationModuleIdOption = new Option<string>("--education-module-id", description: "The unique identifier of educationModule") {
            };
            educationModuleIdOption.IsRequired = true;
            command.AddOption(educationModuleIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var educationClassId = invocationContext.ParseResult.GetValueForOption(educationClassIdOption);
                var educationModuleId = invocationContext.ParseResult.GetValueForOption(educationModuleIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (educationClassId is not null) requestInfo.PathParameters.Add("educationClass%2Did", educationClassId);
                if (educationModuleId is not null) requestInfo.PathParameters.Add("educationModule%2Did", educationModuleId);
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
        /// Get the properties and relationships of a module. Only teachers, students, and applications with application permissions can perform this operation. Students can only see published modules; teachers and applications with application permissions can see all modules in a class.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/educationmodule-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Get the properties and relationships of a module. Only teachers, students, and applications with application permissions can perform this operation. Students can only see published modules; teachers and applications with application permissions can see all modules in a class.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/educationmodule-get?view=graph-rest-1.0";
            var educationClassIdOption = new Option<string>("--education-class-id", description: "The unique identifier of educationClass") {
            };
            educationClassIdOption.IsRequired = true;
            command.AddOption(educationClassIdOption);
            var educationModuleIdOption = new Option<string>("--education-module-id", description: "The unique identifier of educationModule") {
            };
            educationModuleIdOption.IsRequired = true;
            command.AddOption(educationModuleIdOption);
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
                var educationClassId = invocationContext.ParseResult.GetValueForOption(educationClassIdOption);
                var educationModuleId = invocationContext.ParseResult.GetValueForOption(educationModuleIdOption);
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
                if (educationClassId is not null) requestInfo.PathParameters.Add("educationClass%2Did", educationClassId);
                if (educationModuleId is not null) requestInfo.PathParameters.Add("educationModule%2Did", educationModuleId);
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
        /// Update an educationModule object in a class. Only teachers in the class can perform this operation. You can&apos;t use a PATCH request to change the status of a module. Use the publish action to change the module status.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/educationmodule-update?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPatchCommand()
        {
            var command = new Command("patch");
            command.Description = "Update an educationModule object in a class. Only teachers in the class can perform this operation. You can't use a PATCH request to change the status of a module. Use the publish action to change the module status.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/educationmodule-update?view=graph-rest-1.0";
            var educationClassIdOption = new Option<string>("--education-class-id", description: "The unique identifier of educationClass") {
            };
            educationClassIdOption.IsRequired = true;
            command.AddOption(educationClassIdOption);
            var educationModuleIdOption = new Option<string>("--education-module-id", description: "The unique identifier of educationModule") {
            };
            educationModuleIdOption.IsRequired = true;
            command.AddOption(educationModuleIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var educationClassId = invocationContext.ParseResult.GetValueForOption(educationClassIdOption);
                var educationModuleId = invocationContext.ParseResult.GetValueForOption(educationModuleIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<EducationModule>(EducationModule.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (educationClassId is not null) requestInfo.PathParameters.Add("educationClass%2Did", educationClassId);
                if (educationModuleId is not null) requestInfo.PathParameters.Add("educationModule%2Did", educationModuleId);
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
        /// Provides operations to call the pin method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPinNavCommand()
        {
            var command = new Command("pin");
            command.Description = "Provides operations to call the pin method.";
            var builder = new PinRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the publish method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildPublishNavCommand()
        {
            var command = new Command("publish");
            command.Description = "Provides operations to call the publish method.";
            var builder = new PublishRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the resources property of the microsoft.graph.educationModule entity.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildResourcesNavCommand()
        {
            var command = new Command("resources");
            command.Description = "Provides operations to manage the resources property of the microsoft.graph.educationModule entity.";
            var builder = new ResourcesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the setUpResourcesFolder method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildSetUpResourcesFolderNavCommand()
        {
            var command = new Command("set-up-resources-folder");
            command.Description = "Provides operations to call the setUpResourcesFolder method.";
            var builder = new SetUpResourcesFolderRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the unpin method.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildUnpinNavCommand()
        {
            var command = new Command("unpin");
            command.Description = "Provides operations to call the unpin method.";
            var builder = new UnpinRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="EducationModuleItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public EducationModuleItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/education/classes/{educationClass%2Did}/modules/{educationModule%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="EducationModuleItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public EducationModuleItemRequestBuilder(string rawUrl) : base("{+baseurl}/education/classes/{educationClass%2Did}/modules/{educationModule%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete an existing module in a class. Only teachers within a class can delete modules.
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
        /// Get the properties and relationships of a module. Only teachers, students, and applications with application permissions can perform this operation. Students can only see published modules; teachers and applications with application permissions can see all modules in a class.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<EducationModuleItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<EducationModuleItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update an educationModule object in a class. Only teachers in the class can perform this operation. You can&apos;t use a PATCH request to change the status of a module. Use the publish action to change the module status.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(EducationModule body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(EducationModule body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Get the properties and relationships of a module. Only teachers, students, and applications with application permissions can perform this operation. Students can only see published modules; teachers and applications with application permissions can see all modules in a class.
        /// </summary>
        public class EducationModuleItemRequestBuilderGetQueryParameters 
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
