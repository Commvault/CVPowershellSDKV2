// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>EntitySettingsResponse</summary>
    public partial class EntitySettingsResponse :
        Commvault.Powershell.Models.IEntitySettingsResponse,
        Commvault.Powershell.Models.IEntitySettingsResponseInternal
    {

        /// <summary>Backing field for <see cref="EntitySettings" /> property.</summary>
        private System.Collections.Generic.List<Commvault.Powershell.Models.IEntitySettingsListItem> _entitySettings;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.IEntitySettingsListItem> EntitySettings { get => this._entitySettings; set => this._entitySettings = value; }

        /// <summary>Creates an new <see cref="EntitySettingsResponse" /> instance.</summary>
        public EntitySettingsResponse()
        {

        }
    }
    /// EntitySettingsResponse
    public partial interface IEntitySettingsResponse :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"entitySettings",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IEntitySettingsListItem) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.IEntitySettingsListItem> EntitySettings { get; set; }

    }
    /// EntitySettingsResponse
    internal partial interface IEntitySettingsResponseInternal

    {
        System.Collections.Generic.List<Commvault.Powershell.Models.IEntitySettingsListItem> EntitySettings { get; set; }

    }
}