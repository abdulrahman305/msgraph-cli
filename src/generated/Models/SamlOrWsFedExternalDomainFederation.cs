// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class SamlOrWsFedExternalDomainFederation : SamlOrWsFedProvider, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Collection of domain names of the external organizations that the tenant is federating with. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ExternalDomainName>? Domains { get; set; }
#nullable restore
#else
        public List<ExternalDomainName> Domains { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="SamlOrWsFedExternalDomainFederation"/> and sets the default values.
        /// </summary>
        public SamlOrWsFedExternalDomainFederation() : base()
        {
            OdataType = "#microsoft.graph.samlOrWsFedExternalDomainFederation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SamlOrWsFedExternalDomainFederation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SamlOrWsFedExternalDomainFederation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SamlOrWsFedExternalDomainFederation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "domains", n => { Domains = n.GetCollectionOfObjectValues<ExternalDomainName>(ExternalDomainName.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<ExternalDomainName>("domains", Domains);
        }
    }
}
