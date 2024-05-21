// <auto-generated/>
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Drives.Item.Items.Item.Workbook.Functions.Norm_Inv
{
    #pragma warning disable CS1591
    public class Norm_InvPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The mean property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Mean { get; set; }
#nullable restore
#else
        public Json Mean { get; set; }
#endif
        /// <summary>The probability property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Probability { get; set; }
#nullable restore
#else
        public Json Probability { get; set; }
#endif
        /// <summary>The standardDev property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? StandardDev { get; set; }
#nullable restore
#else
        public Json StandardDev { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Norm_InvPostRequestBody"/> and sets the default values.
        /// </summary>
        public Norm_InvPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Norm_InvPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Norm_InvPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Norm_InvPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "mean", n => { Mean = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "probability", n => { Probability = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "standardDev", n => { StandardDev = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("mean", Mean);
            writer.WriteObjectValue<Json>("probability", Probability);
            writer.WriteObjectValue<Json>("standardDev", StandardDev);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
