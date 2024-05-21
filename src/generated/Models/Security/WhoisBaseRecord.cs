// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security
{
    #pragma warning disable CS1591
    public class WhoisBaseRecord : ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The contact information for the abuse contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WhoisContact? Abuse { get; set; }
#nullable restore
#else
        public WhoisContact Abuse { get; set; }
#endif
        /// <summary>The contact information for the admin contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WhoisContact? Admin { get; set; }
#nullable restore
#else
        public WhoisContact Admin { get; set; }
#endif
        /// <summary>The contact information for the billing contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WhoisContact? Billing { get; set; }
#nullable restore
#else
        public WhoisContact Billing { get; set; }
#endif
        /// <summary>The domain status for this WHOIS object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DomainStatus { get; set; }
#nullable restore
#else
        public string DomainStatus { get; set; }
#endif
        /// <summary>The date and time when this WHOIS record expires with the registrar. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>The first seen date and time of this WHOIS record. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? FirstSeenDateTime { get; set; }
        /// <summary>The host property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Security.Host? Host { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Security.Host Host { get; set; }
#endif
        /// <summary>The last seen date and time of this WHOIS record. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastSeenDateTime { get; set; }
        /// <summary>The date and time when this WHOIS record was last modified. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastUpdateDateTime { get; set; }
        /// <summary>The nameservers for this WHOIS object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WhoisNameserver>? Nameservers { get; set; }
#nullable restore
#else
        public List<WhoisNameserver> Nameservers { get; set; }
#endif
        /// <summary>The contact information for the noc contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WhoisContact? Noc { get; set; }
#nullable restore
#else
        public WhoisContact Noc { get; set; }
#endif
        /// <summary>The raw WHOIS details for this WHOIS object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RawWhoisText { get; set; }
#nullable restore
#else
        public string RawWhoisText { get; set; }
#endif
        /// <summary>The contact information for the registrant contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WhoisContact? Registrant { get; set; }
#nullable restore
#else
        public WhoisContact Registrant { get; set; }
#endif
        /// <summary>The contact information for the registrar contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WhoisContact? Registrar { get; set; }
#nullable restore
#else
        public WhoisContact Registrar { get; set; }
#endif
        /// <summary>The date and time when this WHOIS record was registered with a registrar. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? RegistrationDateTime { get; set; }
        /// <summary>The contact information for the technical contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WhoisContact? Technical { get; set; }
#nullable restore
#else
        public WhoisContact Technical { get; set; }
#endif
        /// <summary>The WHOIS server that provides the details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WhoisServer { get; set; }
#nullable restore
#else
        public string WhoisServer { get; set; }
#endif
        /// <summary>The contact information for the zone contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WhoisContact? Zone { get; set; }
#nullable restore
#else
        public WhoisContact Zone { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WhoisBaseRecord"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WhoisBaseRecord CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.security.whoisHistoryRecord" => new WhoisHistoryRecord(),
                "#microsoft.graph.security.whoisRecord" => new WhoisRecord(),
                _ => new WhoisBaseRecord(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "abuse", n => { Abuse = n.GetObjectValue<WhoisContact>(WhoisContact.CreateFromDiscriminatorValue); } },
                { "admin", n => { Admin = n.GetObjectValue<WhoisContact>(WhoisContact.CreateFromDiscriminatorValue); } },
                { "billing", n => { Billing = n.GetObjectValue<WhoisContact>(WhoisContact.CreateFromDiscriminatorValue); } },
                { "domainStatus", n => { DomainStatus = n.GetStringValue(); } },
                { "expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                { "firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                { "host", n => { Host = n.GetObjectValue<ApiSdk.Models.Security.Host>(ApiSdk.Models.Security.Host.CreateFromDiscriminatorValue); } },
                { "lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastUpdateDateTime", n => { LastUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                { "nameservers", n => { Nameservers = n.GetCollectionOfObjectValues<WhoisNameserver>(WhoisNameserver.CreateFromDiscriminatorValue)?.ToList(); } },
                { "noc", n => { Noc = n.GetObjectValue<WhoisContact>(WhoisContact.CreateFromDiscriminatorValue); } },
                { "rawWhoisText", n => { RawWhoisText = n.GetStringValue(); } },
                { "registrant", n => { Registrant = n.GetObjectValue<WhoisContact>(WhoisContact.CreateFromDiscriminatorValue); } },
                { "registrar", n => { Registrar = n.GetObjectValue<WhoisContact>(WhoisContact.CreateFromDiscriminatorValue); } },
                { "registrationDateTime", n => { RegistrationDateTime = n.GetDateTimeOffsetValue(); } },
                { "technical", n => { Technical = n.GetObjectValue<WhoisContact>(WhoisContact.CreateFromDiscriminatorValue); } },
                { "whoisServer", n => { WhoisServer = n.GetStringValue(); } },
                { "zone", n => { Zone = n.GetObjectValue<WhoisContact>(WhoisContact.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WhoisContact>("abuse", Abuse);
            writer.WriteObjectValue<WhoisContact>("admin", Admin);
            writer.WriteObjectValue<WhoisContact>("billing", Billing);
            writer.WriteStringValue("domainStatus", DomainStatus);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteObjectValue<ApiSdk.Models.Security.Host>("host", Host);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteDateTimeOffsetValue("lastUpdateDateTime", LastUpdateDateTime);
            writer.WriteCollectionOfObjectValues<WhoisNameserver>("nameservers", Nameservers);
            writer.WriteObjectValue<WhoisContact>("noc", Noc);
            writer.WriteStringValue("rawWhoisText", RawWhoisText);
            writer.WriteObjectValue<WhoisContact>("registrant", Registrant);
            writer.WriteObjectValue<WhoisContact>("registrar", Registrar);
            writer.WriteDateTimeOffsetValue("registrationDateTime", RegistrationDateTime);
            writer.WriteObjectValue<WhoisContact>("technical", Technical);
            writer.WriteStringValue("whoisServer", WhoisServer);
            writer.WriteObjectValue<WhoisContact>("zone", Zone);
        }
    }
}
