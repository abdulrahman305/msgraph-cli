// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models
{
    [Flags]
    #pragma warning disable CS1591
    public enum WorkforceIntegrationSupportedEntities
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "none")]
        #pragma warning disable CS1591
        None = 1,
        #pragma warning restore CS1591
        [EnumMember(Value = "shift")]
        #pragma warning disable CS1591
        Shift = 2,
        #pragma warning restore CS1591
        [EnumMember(Value = "swapRequest")]
        #pragma warning disable CS1591
        SwapRequest = 4,
        #pragma warning restore CS1591
        [EnumMember(Value = "userShiftPreferences")]
        #pragma warning disable CS1591
        UserShiftPreferences = 8,
        #pragma warning restore CS1591
        [EnumMember(Value = "openShift")]
        #pragma warning disable CS1591
        OpenShift = 16,
        #pragma warning restore CS1591
        [EnumMember(Value = "openShiftRequest")]
        #pragma warning disable CS1591
        OpenShiftRequest = 32,
        #pragma warning restore CS1591
        [EnumMember(Value = "offerShiftRequest")]
        #pragma warning disable CS1591
        OfferShiftRequest = 64,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownFutureValue")]
        #pragma warning disable CS1591
        UnknownFutureValue = 128,
        #pragma warning restore CS1591
    }
}
