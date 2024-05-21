// <auto-generated/>
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.DeviceAppManagement.MobileApps.Item.GraphManagedAndroidLobApp.ContentVersions.Item.Files.Item.Commit
{
    #pragma warning disable CS1591
    public class CommitPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The fileEncryptionInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.FileEncryptionInfo? FileEncryptionInfo { get; set; }
#nullable restore
#else
        public ApiSdk.Models.FileEncryptionInfo FileEncryptionInfo { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="CommitPostRequestBody"/> and sets the default values.
        /// </summary>
        public CommitPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CommitPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CommitPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CommitPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "fileEncryptionInfo", n => { FileEncryptionInfo = n.GetObjectValue<ApiSdk.Models.FileEncryptionInfo>(ApiSdk.Models.FileEncryptionInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.FileEncryptionInfo>("fileEncryptionInfo", FileEncryptionInfo);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
