// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class Contract : DirectoryObject, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Type of contract. Possible values are:  SyndicationPartner, BreadthPartner, ResellerPartner. See more in the table below.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContractType { get; set; }
#nullable restore
#else
        public string ContractType { get; set; }
#endif
        /// <summary>The unique identifier for the customer tenant referenced by this partnership. Corresponds to the id property of the customer tenant&apos;s organization resource.</summary>
        public Guid? CustomerId { get; set; }
        /// <summary>A copy of the customer tenant&apos;s default domain name. The copy is made when the partnership with the customer is established. It isn&apos;t automatically updated if the customer tenant&apos;s default domain name changes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultDomainName { get; set; }
#nullable restore
#else
        public string DefaultDomainName { get; set; }
#endif
        /// <summary>A copy of the customer tenant&apos;s display name. The copy is made when the partnership with the customer is established. It is not automatically updated if the customer tenant&apos;s display name changes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Contract"/> and sets the default values.
        /// </summary>
        public Contract() : base()
        {
            OdataType = "#microsoft.graph.contract";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Contract"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Contract CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Contract();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "contractType", n => { ContractType = n.GetStringValue(); } },
                { "customerId", n => { CustomerId = n.GetGuidValue(); } },
                { "defaultDomainName", n => { DefaultDomainName = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
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
            writer.WriteStringValue("contractType", ContractType);
            writer.WriteGuidValue("customerId", CustomerId);
            writer.WriteStringValue("defaultDomainName", DefaultDomainName);
            writer.WriteStringValue("displayName", DisplayName);
        }
    }
}
