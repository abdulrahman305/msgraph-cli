// <auto-generated/>
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using ApiSdk.Solutions.BookingBusinesses.Item.CalendarView.Count;
using ApiSdk.Solutions.BookingBusinesses.Item.CalendarView.Item;
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
namespace ApiSdk.Solutions.BookingBusinesses.Item.CalendarView
{
    /// <summary>
    /// Provides operations to manage the calendarView property of the microsoft.graph.bookingBusiness entity.
    /// </summary>
    public class CalendarViewRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Provides operations to manage the calendarView property of the microsoft.graph.bookingBusiness entity.
        /// </summary>
        /// <returns>A Tuple&lt;List&lt;Command&gt;, List&lt;Command&gt;&gt;</returns>
        public Tuple<List<Command>, List<Command>> BuildCommand()
        {
            var executables = new List<Command>();
            var commands = new List<Command>();
            var builder = new BookingAppointmentItemRequestBuilder(PathParameters);
            commands.Add(builder.BuildCancelNavCommand());
            executables.Add(builder.BuildDeleteCommand());
            executables.Add(builder.BuildGetCommand());
            executables.Add(builder.BuildPatchCommand());
            return new(executables, commands);
        }
        /// <summary>
        /// Provides operations to count the resources in the collection.
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCountNavCommand()
        {
            var command = new Command("count");
            command.Description = "Provides operations to count the resources in the collection.";
            var builder = new CountRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Create new navigation property to calendarView for solutions
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildCreateCommand()
        {
            var command = new Command("create");
            command.Description = "Create new navigation property to calendarView for solutions";
            var bookingBusinessIdOption = new Option<string>("--booking-business-id", description: "The unique identifier of bookingBusiness") {
            };
            bookingBusinessIdOption.IsRequired = true;
            command.AddOption(bookingBusinessIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var bookingBusinessId = invocationContext.ParseResult.GetValueForOption(bookingBusinessIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<BookingAppointment>(BookingAppointment.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (bookingBusinessId is not null) requestInfo.PathParameters.Add("bookingBusiness%2Did", bookingBusinessId);
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
        /// Get the collection of bookingAppointment objects for a bookingBusiness that occurs in the specified date range.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/bookingbusiness-list-calendarview?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildListCommand()
        {
            var command = new Command("list");
            command.Description = "Get the collection of bookingAppointment objects for a bookingBusiness that occurs in the specified date range.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/bookingbusiness-list-calendarview?view=graph-rest-1.0";
            var bookingBusinessIdOption = new Option<string>("--booking-business-id", description: "The unique identifier of bookingBusiness") {
            };
            bookingBusinessIdOption.IsRequired = true;
            command.AddOption(bookingBusinessIdOption);
            var startOption = new Option<string>("--start", description: "The start date and time of the time range, represented in ISO 8601 format. For example, 2019-11-08T19:00:00-08:00") {
            };
            startOption.IsRequired = true;
            command.AddOption(startOption);
            var endOption = new Option<string>("--end", description: "The end date and time of the time range, represented in ISO 8601 format. For example, 2019-11-08T20:00:00-08:00") {
            };
            endOption.IsRequired = true;
            command.AddOption(endOption);
            var topOption = new Option<int?>("--top", description: "Show only the first n items") {
            };
            topOption.IsRequired = false;
            command.AddOption(topOption);
            var skipOption = new Option<int?>("--skip", description: "Skip the first n items") {
            };
            skipOption.IsRequired = false;
            command.AddOption(skipOption);
            var searchOption = new Option<string>("--search", description: "Search items by search phrases") {
            };
            searchOption.IsRequired = false;
            command.AddOption(searchOption);
            var filterOption = new Option<string>("--filter", description: "Filter items by property values") {
            };
            filterOption.IsRequired = false;
            command.AddOption(filterOption);
            var countOption = new Option<bool?>("--count", description: "Include count of items") {
            };
            countOption.IsRequired = false;
            command.AddOption(countOption);
            var orderbyOption = new Option<string[]>("--orderby", description: "Order items by property values") {
                Arity = ArgumentArity.ZeroOrMore
            };
            orderbyOption.IsRequired = false;
            command.AddOption(orderbyOption);
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
            var allOption = new Option<bool>("--all");
            command.AddOption(allOption);
            command.SetHandler(async (invocationContext) => {
                var bookingBusinessId = invocationContext.ParseResult.GetValueForOption(bookingBusinessIdOption);
                var start = invocationContext.ParseResult.GetValueForOption(startOption);
                var end = invocationContext.ParseResult.GetValueForOption(endOption);
                var top = invocationContext.ParseResult.GetValueForOption(topOption);
                var skip = invocationContext.ParseResult.GetValueForOption(skipOption);
                var search = invocationContext.ParseResult.GetValueForOption(searchOption);
                var filter = invocationContext.ParseResult.GetValueForOption(filterOption);
                var count = invocationContext.ParseResult.GetValueForOption(countOption);
                var orderby = invocationContext.ParseResult.GetValueForOption(orderbyOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var all = invocationContext.ParseResult.GetValueForOption(allOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                IPagingService pagingService = invocationContext.BindingContext.GetService(typeof(IPagingService)) as IPagingService ?? throw new ArgumentNullException("pagingService");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    if (!string.IsNullOrEmpty(start)) q.QueryParameters.Start = start;
                    if (!string.IsNullOrEmpty(end)) q.QueryParameters.End = end;
                    q.QueryParameters.Top = top;
                    q.QueryParameters.Skip = skip;
                    if (!string.IsNullOrEmpty(search)) q.QueryParameters.Search = search;
                    if (!string.IsNullOrEmpty(filter)) q.QueryParameters.Filter = filter;
                    q.QueryParameters.Count = count;
                    q.QueryParameters.Orderby = orderby;
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (bookingBusinessId is not null) requestInfo.PathParameters.Add("bookingBusiness%2Did", bookingBusinessId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var pagingData = new PageLinkData(requestInfo, null, itemName: "value", nextLinkName: "@odata.nextLink");
                var pageResponse = await pagingService.GetPagedDataAsync((info, token) => reqAdapter.SendNoContentAsync(info, cancellationToken: token), pagingData, all, cancellationToken);
                var response = pageResponse?.Response;
#nullable enable
                IOutputFormatter? formatter = null;
#nullable restore
                if (pageResponse?.StatusCode >= 200 && pageResponse?.StatusCode < 300) {
                    formatter = outputFormatterFactory.GetFormatter(output);
                    response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                } else {
                    formatter = outputFormatterFactory.GetFormatter(FormatterType.TEXT);
                }
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="CalendarViewRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CalendarViewRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/solutions/bookingBusinesses/{bookingBusiness%2Did}/calendarView?end={end}&start={start}{&%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="CalendarViewRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CalendarViewRequestBuilder(string rawUrl) : base("{+baseurl}/solutions/bookingBusinesses/{bookingBusiness%2Did}/calendarView?end={end}&start={start}{&%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Get the collection of bookingAppointment objects for a bookingBusiness that occurs in the specified date range.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CalendarViewRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CalendarViewRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create new navigation property to calendarView for solutions
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(BookingAppointment body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(BookingAppointment body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/solutions/bookingBusinesses/{bookingBusiness%2Did}/calendarView", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Get the collection of bookingAppointment objects for a bookingBusiness that occurs in the specified date range.
        /// </summary>
        public class CalendarViewRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>The end date and time of the time range, represented in ISO 8601 format. For example, 2019-11-08T20:00:00-08:00</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("end")]
            public string? End { get; set; }
#nullable restore
#else
            [QueryParameter("end")]
            public string End { get; set; }
#endif
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
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
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
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>The start date and time of the time range, represented in ISO 8601 format. For example, 2019-11-08T19:00:00-08:00</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("start")]
            public string? Start { get; set; }
#nullable restore
#else
            [QueryParameter("start")]
            public string Start { get; set; }
#endif
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
    }
}
