// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class WebApplication : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Home page or landing page of the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HomePageUrl { get; set; }
#nullable restore
#else
        public string HomePageUrl { get; set; }
#endif
        /// <summary>Specifies whether this web application can request tokens using the OAuth 2.0 implicit flow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ImplicitGrantSettings? ImplicitGrantSettings { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ImplicitGrantSettings ImplicitGrantSettings { get; set; }
#endif
        /// <summary>Specifies the URL that is used by Microsoft&apos;s authorization service to log out a user using front-channel, back-channel or SAML logout protocols.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LogoutUrl { get; set; }
#nullable restore
#else
        public string LogoutUrl { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RedirectUris { get; set; }
#nullable restore
#else
        public List<string> RedirectUris { get; set; }
#endif
        /// <summary>The redirectUriSettings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.RedirectUriSettings>? RedirectUriSettings { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.RedirectUriSettings> RedirectUriSettings { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="WebApplication"/> and sets the default values.
        /// </summary>
        public WebApplication()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WebApplication"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WebApplication CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WebApplication();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "homePageUrl", n => { HomePageUrl = n.GetStringValue(); } },
                { "implicitGrantSettings", n => { ImplicitGrantSettings = n.GetObjectValue<ApiSdk.Models.ImplicitGrantSettings>(ApiSdk.Models.ImplicitGrantSettings.CreateFromDiscriminatorValue); } },
                { "logoutUrl", n => { LogoutUrl = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "redirectUriSettings", n => { RedirectUriSettings = n.GetCollectionOfObjectValues<ApiSdk.Models.RedirectUriSettings>(ApiSdk.Models.RedirectUriSettings.CreateFromDiscriminatorValue)?.ToList(); } },
                { "redirectUris", n => { RedirectUris = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("homePageUrl", HomePageUrl);
            writer.WriteObjectValue<ApiSdk.Models.ImplicitGrantSettings>("implicitGrantSettings", ImplicitGrantSettings);
            writer.WriteStringValue("logoutUrl", LogoutUrl);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("redirectUris", RedirectUris);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.RedirectUriSettings>("redirectUriSettings", RedirectUriSettings);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
