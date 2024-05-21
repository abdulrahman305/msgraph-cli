// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class DirectoryObject1 : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Conceptual container for user and group directory objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AdministrativeUnit>? AdministrativeUnits { get; set; }
#nullable restore
#else
        public List<AdministrativeUnit> AdministrativeUnits { get; set; }
#endif
        /// <summary>Group of related custom security attribute definitions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AttributeSet>? AttributeSets { get; set; }
#nullable restore
#else
        public List<AttributeSet> AttributeSets { get; set; }
#endif
        /// <summary>Schema of a custom security attributes (key-value pairs).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomSecurityAttributeDefinition>? CustomSecurityAttributeDefinitions { get; set; }
#nullable restore
#else
        public List<CustomSecurityAttributeDefinition> CustomSecurityAttributeDefinitions { get; set; }
#endif
        /// <summary>Recently deleted items. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? DeletedItems { get; set; }
#nullable restore
#else
        public List<DirectoryObject> DeletedItems { get; set; }
#endif
        /// <summary>The credentials of the device&apos;s local administrator account backed up to Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceLocalCredentialInfo>? DeviceLocalCredentials { get; set; }
#nullable restore
#else
        public List<DeviceLocalCredentialInfo> DeviceLocalCredentials { get; set; }
#endif
        /// <summary>Configure domain federation with organizations whose identity provider (IdP) supports either the SAML or WS-Fed protocol.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentityProviderBase>? FederationConfigurations { get; set; }
#nullable restore
#else
        public List<IdentityProviderBase> FederationConfigurations { get; set; }
#endif
        /// <summary>A container for on-premises directory synchronization functionalities that are available for the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnPremisesDirectorySynchronization>? OnPremisesSynchronization { get; set; }
#nullable restore
#else
        public List<OnPremisesDirectorySynchronization> OnPremisesSynchronization { get; set; }
#endif
        /// <summary>The subscriptions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CompanySubscription>? Subscriptions { get; set; }
#nullable restore
#else
        public List<CompanySubscription> Subscriptions { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DirectoryObject1"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DirectoryObject1 CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DirectoryObject1();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "administrativeUnits", n => { AdministrativeUnits = n.GetCollectionOfObjectValues<AdministrativeUnit>(AdministrativeUnit.CreateFromDiscriminatorValue)?.ToList(); } },
                { "attributeSets", n => { AttributeSets = n.GetCollectionOfObjectValues<AttributeSet>(AttributeSet.CreateFromDiscriminatorValue)?.ToList(); } },
                { "customSecurityAttributeDefinitions", n => { CustomSecurityAttributeDefinitions = n.GetCollectionOfObjectValues<CustomSecurityAttributeDefinition>(CustomSecurityAttributeDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                { "deletedItems", n => { DeletedItems = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                { "deviceLocalCredentials", n => { DeviceLocalCredentials = n.GetCollectionOfObjectValues<DeviceLocalCredentialInfo>(DeviceLocalCredentialInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                { "federationConfigurations", n => { FederationConfigurations = n.GetCollectionOfObjectValues<IdentityProviderBase>(IdentityProviderBase.CreateFromDiscriminatorValue)?.ToList(); } },
                { "onPremisesSynchronization", n => { OnPremisesSynchronization = n.GetCollectionOfObjectValues<OnPremisesDirectorySynchronization>(OnPremisesDirectorySynchronization.CreateFromDiscriminatorValue)?.ToList(); } },
                { "subscriptions", n => { Subscriptions = n.GetCollectionOfObjectValues<CompanySubscription>(CompanySubscription.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<AdministrativeUnit>("administrativeUnits", AdministrativeUnits);
            writer.WriteCollectionOfObjectValues<AttributeSet>("attributeSets", AttributeSets);
            writer.WriteCollectionOfObjectValues<CustomSecurityAttributeDefinition>("customSecurityAttributeDefinitions", CustomSecurityAttributeDefinitions);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("deletedItems", DeletedItems);
            writer.WriteCollectionOfObjectValues<DeviceLocalCredentialInfo>("deviceLocalCredentials", DeviceLocalCredentials);
            writer.WriteCollectionOfObjectValues<IdentityProviderBase>("federationConfigurations", FederationConfigurations);
            writer.WriteCollectionOfObjectValues<OnPremisesDirectorySynchronization>("onPremisesSynchronization", OnPremisesSynchronization);
            writer.WriteCollectionOfObjectValues<CompanySubscription>("subscriptions", Subscriptions);
        }
    }
}
