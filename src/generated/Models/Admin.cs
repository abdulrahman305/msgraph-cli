// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class Admin : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A container for Microsoft Edge resources. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Edge? Edge { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Edge Edge { get; set; }
#endif
        /// <summary>A container for the Microsoft 365 apps admin functionality.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AdminMicrosoft365Apps? Microsoft365Apps { get; set; }
#nullable restore
#else
        public AdminMicrosoft365Apps Microsoft365Apps { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Represents a setting to control people-related admin settings in the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PeopleAdminSettings? People { get; set; }
#nullable restore
#else
        public PeopleAdminSettings People { get; set; }
#endif
        /// <summary>A container for service communications resources. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ServiceAnnouncement? ServiceAnnouncement { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ServiceAnnouncement ServiceAnnouncement { get; set; }
#endif
        /// <summary>The sharepoint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Sharepoint? Sharepoint { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Sharepoint Sharepoint { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Admin"/> and sets the default values.
        /// </summary>
        public Admin()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Admin"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Admin CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Admin();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "edge", n => { Edge = n.GetObjectValue<ApiSdk.Models.Edge>(ApiSdk.Models.Edge.CreateFromDiscriminatorValue); } },
                { "microsoft365Apps", n => { Microsoft365Apps = n.GetObjectValue<AdminMicrosoft365Apps>(AdminMicrosoft365Apps.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "people", n => { People = n.GetObjectValue<PeopleAdminSettings>(PeopleAdminSettings.CreateFromDiscriminatorValue); } },
                { "serviceAnnouncement", n => { ServiceAnnouncement = n.GetObjectValue<ApiSdk.Models.ServiceAnnouncement>(ApiSdk.Models.ServiceAnnouncement.CreateFromDiscriminatorValue); } },
                { "sharepoint", n => { Sharepoint = n.GetObjectValue<ApiSdk.Models.Sharepoint>(ApiSdk.Models.Sharepoint.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Edge>("edge", Edge);
            writer.WriteObjectValue<AdminMicrosoft365Apps>("microsoft365Apps", Microsoft365Apps);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<PeopleAdminSettings>("people", People);
            writer.WriteObjectValue<ApiSdk.Models.ServiceAnnouncement>("serviceAnnouncement", ServiceAnnouncement);
            writer.WriteObjectValue<ApiSdk.Models.Sharepoint>("sharepoint", Sharepoint);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
