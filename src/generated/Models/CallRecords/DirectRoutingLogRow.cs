// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.CallRecords
{
    #pragma warning disable CS1591
    public class DirectRoutingLogRow : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number of the user or bot who received the call. E.164 format, but might include other data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CalleeNumber { get; set; }
#nullable restore
#else
        public string CalleeNumber { get; set; }
#endif
        /// <summary>In addition to the SIP codes, Microsoft has subcodes that indicate the specific issue.</summary>
        public int? CallEndSubReason { get; set; }
        /// <summary>Number of the user or bot who made the call. E.164 format, but might include other data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallerNumber { get; set; }
#nullable restore
#else
        public string CallerNumber { get; set; }
#endif
        /// <summary>Call type and direction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallType { get; set; }
#nullable restore
#else
        public string CallType { get; set; }
#endif
        /// <summary>Identifier for the call that you can use when calling Microsoft Support. GUID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CorrelationId { get; set; }
#nullable restore
#else
        public string CorrelationId { get; set; }
#endif
        /// <summary>Duration of the call in seconds.</summary>
        public int? Duration { get; set; }
        /// <summary>Only exists for successful (fully established) calls. Time when call ended.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>Only exists for failed (not fully established) calls.</summary>
        public DateTimeOffset? FailureDateTime { get; set; }
        /// <summary>The final response code with which the call ended. For more information, see RFC 3261.</summary>
        public int? FinalSipCode { get; set; }
        /// <summary>Description of the SIP code and Microsoft subcode.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FinalSipCodePhrase { get; set; }
#nullable restore
#else
        public string FinalSipCodePhrase { get; set; }
#endif
        /// <summary>Unique call identifier. GUID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The date and time when the initial invite was sent.</summary>
        public DateTimeOffset? InviteDateTime { get; set; }
        /// <summary>Indicates whether the trunk was enabled for media bypass.</summary>
        public bool? MediaBypassEnabled { get; set; }
        /// <summary>The datacenter used for media path in a nonbypass call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MediaPathLocation { get; set; }
#nullable restore
#else
        public string MediaPathLocation { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The datacenter used for signaling for both bypass and nonbypass calls.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignalingLocation { get; set; }
#nullable restore
#else
        public string SignalingLocation { get; set; }
#endif
        /// <summary>Call start time.For failed and unanswered calls, this value can be equal to the invite or failure time.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>Success or attempt.</summary>
        public bool? SuccessfulCall { get; set; }
        /// <summary>Fully qualified domain name of the session border controller.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TrunkFullyQualifiedDomainName { get; set; }
#nullable restore
#else
        public string TrunkFullyQualifiedDomainName { get; set; }
#endif
        /// <summary>Display name of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserDisplayName { get; set; }
#nullable restore
#else
        public string UserDisplayName { get; set; }
#endif
        /// <summary>Calling user&apos;s ID in Microsoft Graph. This and other user information is null/empty for bot call types. GUID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>UserPrincipalName (sign-in name) in Microsoft Entra ID. This value is usually the same as the user&apos;s SIP Address, and can be the same as the user&apos;s email address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName { get; set; }
#nullable restore
#else
        public string UserPrincipalName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DirectRoutingLogRow"/> and sets the default values.
        /// </summary>
        public DirectRoutingLogRow()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DirectRoutingLogRow"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DirectRoutingLogRow CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DirectRoutingLogRow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "callEndSubReason", n => { CallEndSubReason = n.GetIntValue(); } },
                { "callType", n => { CallType = n.GetStringValue(); } },
                { "calleeNumber", n => { CalleeNumber = n.GetStringValue(); } },
                { "callerNumber", n => { CallerNumber = n.GetStringValue(); } },
                { "correlationId", n => { CorrelationId = n.GetStringValue(); } },
                { "duration", n => { Duration = n.GetIntValue(); } },
                { "endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                { "failureDateTime", n => { FailureDateTime = n.GetDateTimeOffsetValue(); } },
                { "finalSipCode", n => { FinalSipCode = n.GetIntValue(); } },
                { "finalSipCodePhrase", n => { FinalSipCodePhrase = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "inviteDateTime", n => { InviteDateTime = n.GetDateTimeOffsetValue(); } },
                { "mediaBypassEnabled", n => { MediaBypassEnabled = n.GetBoolValue(); } },
                { "mediaPathLocation", n => { MediaPathLocation = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "signalingLocation", n => { SignalingLocation = n.GetStringValue(); } },
                { "startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                { "successfulCall", n => { SuccessfulCall = n.GetBoolValue(); } },
                { "trunkFullyQualifiedDomainName", n => { TrunkFullyQualifiedDomainName = n.GetStringValue(); } },
                { "userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
                { "userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("calleeNumber", CalleeNumber);
            writer.WriteIntValue("callEndSubReason", CallEndSubReason);
            writer.WriteStringValue("callerNumber", CallerNumber);
            writer.WriteStringValue("callType", CallType);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteIntValue("duration", Duration);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteDateTimeOffsetValue("failureDateTime", FailureDateTime);
            writer.WriteIntValue("finalSipCode", FinalSipCode);
            writer.WriteStringValue("finalSipCodePhrase", FinalSipCodePhrase);
            writer.WriteStringValue("id", Id);
            writer.WriteDateTimeOffsetValue("inviteDateTime", InviteDateTime);
            writer.WriteBoolValue("mediaBypassEnabled", MediaBypassEnabled);
            writer.WriteStringValue("mediaPathLocation", MediaPathLocation);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("signalingLocation", SignalingLocation);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteBoolValue("successfulCall", SuccessfulCall);
            writer.WriteStringValue("trunkFullyQualifiedDomainName", TrunkFullyQualifiedDomainName);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
