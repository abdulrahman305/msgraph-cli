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
namespace ApiSdk.Solutions.BookingBusinesses.Item.CalendarView.Count
{
    /// <summary>
    /// Provides operations to count the resources in the collection.
    /// </summary>
    public class CountRequestBuilder : BaseCliRequestBuilder
    {
        /// <summary>
        /// Get the number of the resource
        /// </summary>
        /// <returns>A <see cref="Command"/></returns>
        public Command BuildGetCommand()
        {
            var command = new Command("get");
            command.Description = "Get the number of the resource";
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
            var searchOption = new Option<string>("--search", description: "Search items by search phrases") {
            };
            searchOption.IsRequired = false;
            command.AddOption(searchOption);
            var filterOption = new Option<string>("--filter", description: "Filter items by property values") {
            };
            filterOption.IsRequired = false;
            command.AddOption(filterOption);
            command.SetHandler(async (invocationContext) => {
                var bookingBusinessId = invocationContext.ParseResult.GetValueForOption(bookingBusinessIdOption);
                var start = invocationContext.ParseResult.GetValueForOption(startOption);
                var end = invocationContext.ParseResult.GetValueForOption(endOption);
                var search = invocationContext.ParseResult.GetValueForOption(searchOption);
                var filter = invocationContext.ParseResult.GetValueForOption(filterOption);
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    if (!string.IsNullOrEmpty(start)) q.QueryParameters.Start = start;
                    if (!string.IsNullOrEmpty(end)) q.QueryParameters.End = end;
                    if (!string.IsNullOrEmpty(search)) q.QueryParameters.Search = search;
                    if (!string.IsNullOrEmpty(filter)) q.QueryParameters.Filter = filter;
                });
                if (bookingBusinessId is not null) requestInfo.PathParameters.Add("bookingBusiness%2Did", bookingBusinessId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                var formatter = outputFormatterFactory.GetFormatter(FormatterType.TEXT);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="CountRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CountRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/solutions/bookingBusinesses/{bookingBusiness%2Did}/calendarView/$count?end={end}&start={start}{&%24filter,%24search}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="CountRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CountRequestBuilder(string rawUrl) : base("{+baseurl}/solutions/bookingBusinesses/{bookingBusiness%2Did}/calendarView/$count?end={end}&start={start}{&%24filter,%24search}", rawUrl)
        {
        }
        /// <summary>
        /// Get the number of the resource
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CountRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CountRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "text/plain;q=0.9");
            return requestInfo;
        }
        /// <summary>
        /// Get the number of the resource
        /// </summary>
        public class CountRequestBuilderGetQueryParameters 
        {
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
        }
    }
}
