// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class Payload : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The branch of a payload. Possible values are: unknown, other, americanExpress, capitalOne, dhl, docuSign, dropbox, facebook, firstAmerican, microsoft, netflix, scotiabank, sendGrid, stewartTitle, tesco, wellsFargo, syrinxCloud, adobe, teams, zoom, unknownFutureValue.</summary>
        public PayloadBrand? Brand { get; set; }
        /// <summary>The complexity of a payload. Possible values are: unknown, low, medium, high, unknownFutureValue.</summary>
        public PayloadComplexity? Complexity { get; set; }
        /// <summary>Identity of the user who created the attack simulation and training campaign payload.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailIdentity? CreatedBy { get; set; }
#nullable restore
#else
        public EmailIdentity CreatedBy { get; set; }
#endif
        /// <summary>Date and time when the attack simulation and training campaign payload. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Description of the attack simulation and training campaign payload.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Additional details about the payload.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PayloadDetail? Detail { get; set; }
#nullable restore
#else
        public PayloadDetail Detail { get; set; }
#endif
        /// <summary>Display name of the attack simulation and training campaign payload. Supports $filter and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Industry of a payload. Possible values are: unknown, other, banking, businessServices, consumerServices, education, energy, construction, consulting, financialServices, government, hospitality, insurance, legal, courierServices, IT, healthcare, manufacturing, retail, telecom, realEstate, unknownFutureValue.</summary>
        public PayloadIndustry? Industry { get; set; }
        /// <summary>Indicates whether the attack simulation and training campaign payload was created from an automation flow. Supports $filter and $orderby.</summary>
        public bool? IsAutomated { get; set; }
        /// <summary>Indicates whether the payload is controversial.</summary>
        public bool? IsControversial { get; set; }
        /// <summary>Indicates whether the payload is from any recent event.</summary>
        public bool? IsCurrentEvent { get; set; }
        /// <summary>Payload language.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Language { get; set; }
#nullable restore
#else
        public string Language { get; set; }
#endif
        /// <summary>Identity of the user who most recently modified the attack simulation and training campaign payload.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailIdentity? LastModifiedBy { get; set; }
#nullable restore
#else
        public EmailIdentity LastModifiedBy { get; set; }
#endif
        /// <summary>Date and time when the attack simulation and training campaign payload was last modified. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Free text tags for a payload.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PayloadTags { get; set; }
#nullable restore
#else
        public List<string> PayloadTags { get; set; }
#endif
        /// <summary>The payload delivery platform for a simulation. Possible values are: unknown, sms, email, teams, unknownFutureValue.</summary>
        public PayloadDeliveryPlatform? Platform { get; set; }
        /// <summary>Predicted probability for a payload to phish a targeted user.</summary>
        public double? PredictedCompromiseRate { get; set; }
        /// <summary>Attack type of the attack simulation and training campaign. Supports $filter and $orderby. Possible values are: unknown, social, cloud, endpoint, unknownFutureValue.</summary>
        public ApiSdk.Models.SimulationAttackType? SimulationAttackType { get; set; }
        /// <summary>The source property</summary>
        public SimulationContentSource? Source { get; set; }
        /// <summary>Simulation content status. Supports $filter and $orderby. Possible values are: unknown, draft, ready, archive, delete, unknownFutureValue.</summary>
        public SimulationContentStatus? Status { get; set; }
        /// <summary>The social engineering technique used in the attack simulation and training campaign. Supports $filter and $orderby. Possible values are: unknown, credentialHarvesting, attachmentMalware, driveByUrl, linkInAttachment, linkToMalwareFile, unknownFutureValue, oAuthConsentGrant. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values from this evolvable enum: oAuthConsentGrant. For more information on the types of social engineering attack techniques, see simulations.</summary>
        public SimulationAttackTechnique? Technique { get; set; }
        /// <summary>The theme of a payload. Possible values are: unknown, other, accountActivation, accountVerification, billing, cleanUpMail, controversial, documentReceived, expense, fax, financeReport, incomingMessages, invoice, itemReceived, loginAlert, mailReceived, password, payment, payroll, personalizedOffer, quarantine, remoteWork, reviewMessage, securityUpdate, serviceSuspended, signatureRequired, upgradeMailboxStorage, verifyMailbox, voicemail, advertisement, employeeEngagement, unknownFutureValue.</summary>
        public PayloadTheme? Theme { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Payload"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Payload CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Payload();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "brand", n => { Brand = n.GetEnumValue<PayloadBrand>(); } },
                { "complexity", n => { Complexity = n.GetEnumValue<PayloadComplexity>(); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<EmailIdentity>(EmailIdentity.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "detail", n => { Detail = n.GetObjectValue<PayloadDetail>(PayloadDetail.CreateFromDiscriminatorValue); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "industry", n => { Industry = n.GetEnumValue<PayloadIndustry>(); } },
                { "isAutomated", n => { IsAutomated = n.GetBoolValue(); } },
                { "isControversial", n => { IsControversial = n.GetBoolValue(); } },
                { "isCurrentEvent", n => { IsCurrentEvent = n.GetBoolValue(); } },
                { "language", n => { Language = n.GetStringValue(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<EmailIdentity>(EmailIdentity.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "payloadTags", n => { PayloadTags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "platform", n => { Platform = n.GetEnumValue<PayloadDeliveryPlatform>(); } },
                { "predictedCompromiseRate", n => { PredictedCompromiseRate = n.GetDoubleValue(); } },
                { "simulationAttackType", n => { SimulationAttackType = n.GetEnumValue<SimulationAttackType>(); } },
                { "source", n => { Source = n.GetEnumValue<SimulationContentSource>(); } },
                { "status", n => { Status = n.GetEnumValue<SimulationContentStatus>(); } },
                { "technique", n => { Technique = n.GetEnumValue<SimulationAttackTechnique>(); } },
                { "theme", n => { Theme = n.GetEnumValue<PayloadTheme>(); } },
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
            writer.WriteEnumValue<PayloadBrand>("brand", Brand);
            writer.WriteEnumValue<PayloadComplexity>("complexity", Complexity);
            writer.WriteObjectValue<EmailIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<PayloadDetail>("detail", Detail);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<PayloadIndustry>("industry", Industry);
            writer.WriteBoolValue("isAutomated", IsAutomated);
            writer.WriteBoolValue("isControversial", IsControversial);
            writer.WriteBoolValue("isCurrentEvent", IsCurrentEvent);
            writer.WriteStringValue("language", Language);
            writer.WriteObjectValue<EmailIdentity>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("payloadTags", PayloadTags);
            writer.WriteEnumValue<PayloadDeliveryPlatform>("platform", Platform);
            writer.WriteDoubleValue("predictedCompromiseRate", PredictedCompromiseRate);
            writer.WriteEnumValue<SimulationAttackType>("simulationAttackType", SimulationAttackType);
            writer.WriteEnumValue<SimulationContentSource>("source", Source);
            writer.WriteEnumValue<SimulationContentStatus>("status", Status);
            writer.WriteEnumValue<SimulationAttackTechnique>("technique", Technique);
            writer.WriteEnumValue<PayloadTheme>("theme", Theme);
        }
    }
}
