// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>SAML Identity provider meta data response</summary>
    public partial class SamlidpMetaDataResp :
        Commvault.Powershell.Models.ISamlidpMetaDataResp,
        Commvault.Powershell.Models.ISamlidpMetaDataRespInternal
    {

        /// <summary>Backing field for <see cref="EntityId" /> property.</summary>
        private string _entityId;

        /// <summary>Identity provider entity</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string EntityId { get => this._entityId; set => this._entityId = value; }

        /// <summary>Backing field for <see cref="LogoutUrl" /> property.</summary>
        private string _logoutUrl;

        /// <summary>Identity Provider log-out URL</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string LogoutUrl { get => this._logoutUrl; set => this._logoutUrl = value; }

        /// <summary>Backing field for <see cref="RedirectUrl" /> property.</summary>
        private string _redirectUrl;

        /// <summary>Identity provider redirect URL</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string RedirectUrl { get => this._redirectUrl; set => this._redirectUrl = value; }

        /// <summary>Creates an new <see cref="SamlidpMetaDataResp" /> instance.</summary>
        public SamlidpMetaDataResp()
        {

        }
    }
    /// SAML Identity provider meta data response
    public partial interface ISamlidpMetaDataResp :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Identity provider entity</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identity provider entity",
        SerializedName = @"entityId",
        PossibleTypes = new [] { typeof(string) })]
        string EntityId { get; set; }
        /// <summary>Identity Provider log-out URL</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identity Provider log-out URL",
        SerializedName = @"logoutUrl",
        PossibleTypes = new [] { typeof(string) })]
        string LogoutUrl { get; set; }
        /// <summary>Identity provider redirect URL</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identity provider redirect URL",
        SerializedName = @"redirectUrl",
        PossibleTypes = new [] { typeof(string) })]
        string RedirectUrl { get; set; }

    }
    /// SAML Identity provider meta data response
    internal partial interface ISamlidpMetaDataRespInternal

    {
        /// <summary>Identity provider entity</summary>
        string EntityId { get; set; }
        /// <summary>Identity Provider log-out URL</summary>
        string LogoutUrl { get; set; }
        /// <summary>Identity provider redirect URL</summary>
        string RedirectUrl { get; set; }

    }
}