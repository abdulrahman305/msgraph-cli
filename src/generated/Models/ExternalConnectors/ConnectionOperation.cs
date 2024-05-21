// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.ExternalConnectors
{
    #pragma warning disable CS1591
    public class ConnectionOperation : ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>If status is failed, provides more information about the error that caused the failure.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.PublicError? Error { get; set; }
#nullable restore
#else
        public ApiSdk.Models.PublicError Error { get; set; }
#endif
        /// <summary>Indicates the status of the asynchronous operation. Possible values are: unspecified, inprogress, completed, failed, unknownFutureValue.</summary>
        public ConnectionOperationStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ConnectionOperation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ConnectionOperation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConnectionOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "error", n => { Error = n.GetObjectValue<ApiSdk.Models.PublicError>(ApiSdk.Models.PublicError.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetEnumValue<ConnectionOperationStatus>(); } },
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
            writer.WriteObjectValue<ApiSdk.Models.PublicError>("error", Error);
            writer.WriteEnumValue<ConnectionOperationStatus>("status", Status);
        }
    }
}
