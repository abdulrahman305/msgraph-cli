// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class UnifiedRoleManagementPolicyAssignment : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The policy that&apos;s associated with a policy assignment. Supports $expand and a nested $expand of the rules and effectiveRules relationships for the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UnifiedRoleManagementPolicy? Policy { get; set; }
#nullable restore
#else
        public UnifiedRoleManagementPolicy Policy { get; set; }
#endif
        /// <summary>The id of the policy. Inherited from entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyId { get; set; }
#nullable restore
#else
        public string PolicyId { get; set; }
#endif
        /// <summary>For Microsoft Entra roles policy, it&apos;s the identifier of the role definition object where the policy applies. For PIM for groups membership and ownership, it&apos;s either member or owner. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleDefinitionId { get; set; }
#nullable restore
#else
        public string RoleDefinitionId { get; set; }
#endif
        /// <summary>The identifier of the scope where the policy is assigned.  Can be / for the tenant or a group ID. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScopeId { get; set; }
#nullable restore
#else
        public string ScopeId { get; set; }
#endif
        /// <summary>The type of the scope where the policy is assigned. One of Directory, DirectoryRole, Group. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScopeType { get; set; }
#nullable restore
#else
        public string ScopeType { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UnifiedRoleManagementPolicyAssignment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedRoleManagementPolicyAssignment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleManagementPolicyAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "policy", n => { Policy = n.GetObjectValue<UnifiedRoleManagementPolicy>(UnifiedRoleManagementPolicy.CreateFromDiscriminatorValue); } },
                { "policyId", n => { PolicyId = n.GetStringValue(); } },
                { "roleDefinitionId", n => { RoleDefinitionId = n.GetStringValue(); } },
                { "scopeId", n => { ScopeId = n.GetStringValue(); } },
                { "scopeType", n => { ScopeType = n.GetStringValue(); } },
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
            writer.WriteObjectValue<UnifiedRoleManagementPolicy>("policy", Policy);
            writer.WriteStringValue("policyId", PolicyId);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
            writer.WriteStringValue("scopeId", ScopeId);
            writer.WriteStringValue("scopeType", ScopeType);
        }
    }
}
