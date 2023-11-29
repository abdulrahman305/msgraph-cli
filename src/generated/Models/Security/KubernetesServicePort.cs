// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security {
    public class KubernetesServicePort : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The application protocol for this port.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppProtocol { get; set; }
#nullable restore
#else
        public string AppProtocol { get; set; }
#endif
        /// <summary>The name of this port within the service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The port on each node on which this service is exposed when the type is either NodePort or LoadBalancer.</summary>
        public int? NodePort { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The port that this service exposes.</summary>
        public int? Port { get; set; }
        /// <summary>The protocol name. Possible values are: udp, tcp, sctp, unknownFutureValue.</summary>
        public ContainerPortProtocol? Protocol { get; set; }
        /// <summary>The name or number of the port to access on the pods targeted by the service. The port number must be in the range 1 to 65535. The name must be an IANASVCNAME.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetPort { get; set; }
#nullable restore
#else
        public string TargetPort { get; set; }
#endif
        /// <summary>
        /// Instantiates a new kubernetesServicePort and sets the default values.
        /// </summary>
        public KubernetesServicePort() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KubernetesServicePort CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KubernetesServicePort();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"appProtocol", n => { AppProtocol = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"nodePort", n => { NodePort = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"port", n => { Port = n.GetIntValue(); } },
                {"protocol", n => { Protocol = n.GetEnumValue<ContainerPortProtocol>(); } },
                {"targetPort", n => { TargetPort = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("appProtocol", AppProtocol);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("nodePort", NodePort);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("port", Port);
            writer.WriteEnumValue<ContainerPortProtocol>("protocol", Protocol);
            writer.WriteStringValue("targetPort", TargetPort);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
