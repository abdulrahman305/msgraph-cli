// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class ParseExpressionResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Error details, if expression evaluation resulted in an error.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PublicError? Error { get; set; }
#nullable restore
#else
        public PublicError Error { get; set; }
#endif
        /// <summary>A collection of values produced by the evaluation of the expression.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EvaluationResult { get; set; }
#nullable restore
#else
        public List<string> EvaluationResult { get; set; }
#endif
        /// <summary>true if the evaluation was successful.</summary>
        public bool? EvaluationSucceeded { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>An attributeMappingSource object representing the parsed expression.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AttributeMappingSource? ParsedExpression { get; set; }
#nullable restore
#else
        public AttributeMappingSource ParsedExpression { get; set; }
#endif
        /// <summary>true if the expression was parsed successfully.</summary>
        public bool? ParsingSucceeded { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="ParseExpressionResponse"/> and sets the default values.
        /// </summary>
        public ParseExpressionResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ParseExpressionResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ParseExpressionResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ParseExpressionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "error", n => { Error = n.GetObjectValue<PublicError>(PublicError.CreateFromDiscriminatorValue); } },
                { "evaluationResult", n => { EvaluationResult = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "evaluationSucceeded", n => { EvaluationSucceeded = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "parsedExpression", n => { ParsedExpression = n.GetObjectValue<AttributeMappingSource>(AttributeMappingSource.CreateFromDiscriminatorValue); } },
                { "parsingSucceeded", n => { ParsingSucceeded = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PublicError>("error", Error);
            writer.WriteCollectionOfPrimitiveValues<string>("evaluationResult", EvaluationResult);
            writer.WriteBoolValue("evaluationSucceeded", EvaluationSucceeded);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<AttributeMappingSource>("parsedExpression", ParsedExpression);
            writer.WriteBoolValue("parsingSucceeded", ParsingSucceeded);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
