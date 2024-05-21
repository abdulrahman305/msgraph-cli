// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class Participant : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The info property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ParticipantInfo? Info { get; set; }
#nullable restore
#else
        public ParticipantInfo Info { get; set; }
#endif
        /// <summary>true if the participant is in lobby.</summary>
        public bool? IsInLobby { get; set; }
        /// <summary>true if the participant is muted (client or server muted).</summary>
        public bool? IsMuted { get; set; }
        /// <summary>The list of media streams.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MediaStream>? MediaStreams { get; set; }
#nullable restore
#else
        public List<MediaStream> MediaStreams { get; set; }
#endif
        /// <summary>A blob of data provided by the participant in the roster.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Metadata { get; set; }
#nullable restore
#else
        public string Metadata { get; set; }
#endif
        /// <summary>Information about whether the participant has recording capability.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.RecordingInfo? RecordingInfo { get; set; }
#nullable restore
#else
        public ApiSdk.Models.RecordingInfo RecordingInfo { get; set; }
#endif
        /// <summary>Indicates the reason why the participant was removed from the roster.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.RemovedState? RemovedState { get; set; }
#nullable restore
#else
        public ApiSdk.Models.RemovedState RemovedState { get; set; }
#endif
        /// <summary>Indicates the reason or reasons media content from this participant is restricted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnlineMeetingRestricted? RestrictedExperience { get; set; }
#nullable restore
#else
        public OnlineMeetingRestricted RestrictedExperience { get; set; }
#endif
        /// <summary>Indicates the roster sequence number in which the participant was last updated.</summary>
        public long? RosterSequenceNumber { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Participant"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Participant CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Participant();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "info", n => { Info = n.GetObjectValue<ParticipantInfo>(ParticipantInfo.CreateFromDiscriminatorValue); } },
                { "isInLobby", n => { IsInLobby = n.GetBoolValue(); } },
                { "isMuted", n => { IsMuted = n.GetBoolValue(); } },
                { "mediaStreams", n => { MediaStreams = n.GetCollectionOfObjectValues<MediaStream>(MediaStream.CreateFromDiscriminatorValue)?.ToList(); } },
                { "metadata", n => { Metadata = n.GetStringValue(); } },
                { "recordingInfo", n => { RecordingInfo = n.GetObjectValue<ApiSdk.Models.RecordingInfo>(ApiSdk.Models.RecordingInfo.CreateFromDiscriminatorValue); } },
                { "removedState", n => { RemovedState = n.GetObjectValue<ApiSdk.Models.RemovedState>(ApiSdk.Models.RemovedState.CreateFromDiscriminatorValue); } },
                { "restrictedExperience", n => { RestrictedExperience = n.GetObjectValue<OnlineMeetingRestricted>(OnlineMeetingRestricted.CreateFromDiscriminatorValue); } },
                { "rosterSequenceNumber", n => { RosterSequenceNumber = n.GetLongValue(); } },
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
            writer.WriteObjectValue<ParticipantInfo>("info", Info);
            writer.WriteBoolValue("isInLobby", IsInLobby);
            writer.WriteBoolValue("isMuted", IsMuted);
            writer.WriteCollectionOfObjectValues<MediaStream>("mediaStreams", MediaStreams);
            writer.WriteStringValue("metadata", Metadata);
            writer.WriteObjectValue<ApiSdk.Models.RecordingInfo>("recordingInfo", RecordingInfo);
            writer.WriteObjectValue<ApiSdk.Models.RemovedState>("removedState", RemovedState);
            writer.WriteObjectValue<OnlineMeetingRestricted>("restrictedExperience", RestrictedExperience);
            writer.WriteLongValue("rosterSequenceNumber", RosterSequenceNumber);
        }
    }
}
