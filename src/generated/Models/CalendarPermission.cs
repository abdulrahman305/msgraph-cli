// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class CalendarPermission : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead, read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CalendarRoleType?>? AllowedRoles { get; set; }
#nullable restore
#else
        public List<CalendarRoleType?> AllowedRoles { get; set; }
#endif
        /// <summary>Represents a share recipient or delegate who has access to the calendar. For the &apos;My Organization&apos; share recipient, the address property is null. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.EmailAddress? EmailAddress { get; set; }
#nullable restore
#else
        public ApiSdk.Models.EmailAddress EmailAddress { get; set; }
#endif
        /// <summary>True if the user in context (recipient or delegate) is inside the same organization as the calendar owner.</summary>
        public bool? IsInsideOrganization { get; set; }
        /// <summary>True if the user can be removed from the list of recipients or delegates for the specified calendar, false otherwise. The &apos;My organization&apos; user determines the permissions other people within your organization have to the given calendar. You can&apos;t remove &apos;My organization&apos; as a share recipient to a calendar.</summary>
        public bool? IsRemovable { get; set; }
        /// <summary>Current permission level of the calendar share recipient or delegate.</summary>
        public CalendarRoleType? Role { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CalendarPermission"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CalendarPermission CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CalendarPermission();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowedRoles", n => { AllowedRoles = n.GetCollectionOfEnumValues<CalendarRoleType>()?.ToList(); } },
                { "emailAddress", n => { EmailAddress = n.GetObjectValue<ApiSdk.Models.EmailAddress>(ApiSdk.Models.EmailAddress.CreateFromDiscriminatorValue); } },
                { "isInsideOrganization", n => { IsInsideOrganization = n.GetBoolValue(); } },
                { "isRemovable", n => { IsRemovable = n.GetBoolValue(); } },
                { "role", n => { Role = n.GetEnumValue<CalendarRoleType>(); } },
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
            writer.WriteCollectionOfEnumValues<CalendarRoleType>("allowedRoles", AllowedRoles);
            writer.WriteObjectValue<ApiSdk.Models.EmailAddress>("emailAddress", EmailAddress);
            writer.WriteBoolValue("isInsideOrganization", IsInsideOrganization);
            writer.WriteBoolValue("isRemovable", IsRemovable);
            writer.WriteEnumValue<CalendarRoleType>("role", Role);
        }
    }
}
