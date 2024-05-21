// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class AttributeMapping : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Default value to be used in case the source property was evaluated to null. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultValue { get; set; }
#nullable restore
#else
        public string DefaultValue { get; set; }
#endif
        /// <summary>For internal use only.</summary>
        public bool? ExportMissingReferences { get; set; }
        /// <summary>The flowBehavior property</summary>
        public AttributeFlowBehavior? FlowBehavior { get; set; }
        /// <summary>The flowType property</summary>
        public AttributeFlowType? FlowType { get; set; }
        /// <summary>If higher than 0, this attribute will be used to perform an initial match of the objects between source and target directories. The synchronization engine will try to find the matching object using attribute with lowest value of matching priority first. If not found, the attribute with the next matching priority will be used, and so on a until match is found or no more matching attributes are left. Only attributes that are expected to have unique values, such as email, should be used as matching attributes.</summary>
        public int? MatchingPriority { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Defines how a value should be extracted (or transformed) from the source object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AttributeMappingSource? Source { get; set; }
#nullable restore
#else
        public AttributeMappingSource Source { get; set; }
#endif
        /// <summary>Name of the attribute on the target object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetAttributeName { get; set; }
#nullable restore
#else
        public string TargetAttributeName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AttributeMapping"/> and sets the default values.
        /// </summary>
        public AttributeMapping()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AttributeMapping"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AttributeMapping CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttributeMapping();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "defaultValue", n => { DefaultValue = n.GetStringValue(); } },
                { "exportMissingReferences", n => { ExportMissingReferences = n.GetBoolValue(); } },
                { "flowBehavior", n => { FlowBehavior = n.GetEnumValue<AttributeFlowBehavior>(); } },
                { "flowType", n => { FlowType = n.GetEnumValue<AttributeFlowType>(); } },
                { "matchingPriority", n => { MatchingPriority = n.GetIntValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "source", n => { Source = n.GetObjectValue<AttributeMappingSource>(AttributeMappingSource.CreateFromDiscriminatorValue); } },
                { "targetAttributeName", n => { TargetAttributeName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("defaultValue", DefaultValue);
            writer.WriteBoolValue("exportMissingReferences", ExportMissingReferences);
            writer.WriteEnumValue<AttributeFlowBehavior>("flowBehavior", FlowBehavior);
            writer.WriteEnumValue<AttributeFlowType>("flowType", FlowType);
            writer.WriteIntValue("matchingPriority", MatchingPriority);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<AttributeMappingSource>("source", Source);
            writer.WriteStringValue("targetAttributeName", TargetAttributeName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
