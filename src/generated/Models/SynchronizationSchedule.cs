// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class SynchronizationSchedule : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Date and time when this job expires. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? Expiration { get; set; }
        /// <summary>The interval between synchronization iterations. The value is represented in ISO 8601 format for durations. For example, PT1M represents a period of one month.</summary>
        public TimeSpan? Interval { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The state property</summary>
        public SynchronizationScheduleState? State { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="SynchronizationSchedule"/> and sets the default values.
        /// </summary>
        public SynchronizationSchedule()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SynchronizationSchedule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SynchronizationSchedule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationSchedule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "expiration", n => { Expiration = n.GetDateTimeOffsetValue(); } },
                { "interval", n => { Interval = n.GetTimeSpanValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "state", n => { State = n.GetEnumValue<SynchronizationScheduleState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("expiration", Expiration);
            writer.WriteTimeSpanValue("interval", Interval);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<SynchronizationScheduleState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
