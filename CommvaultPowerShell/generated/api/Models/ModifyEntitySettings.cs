// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>ModifyEntitySettings</summary>
    public partial class ModifyEntitySettings :
        Commvault.Powershell.Models.IModifyEntitySettings,
        Commvault.Powershell.Models.IModifyEntitySettingsInternal
    {

        /// <summary>Backing field for <see cref="EntitySettings" /> property.</summary>
        private System.Collections.Generic.List<Commvault.Powershell.Models.IModifyEntitySettingsItem> _entitySettings;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.IModifyEntitySettingsItem> EntitySettings { get => this._entitySettings; set => this._entitySettings = value; }

        /// <summary>Creates an new <see cref="ModifyEntitySettings" /> instance.</summary>
        public ModifyEntitySettings()
        {

        }
    }
    /// ModifyEntitySettings
    public partial interface IModifyEntitySettings :
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
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IModifyEntitySettingsItem) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.IModifyEntitySettingsItem> EntitySettings { get; set; }

    }
    /// ModifyEntitySettings
    internal partial interface IModifyEntitySettingsInternal

    {
        System.Collections.Generic.List<Commvault.Powershell.Models.IModifyEntitySettingsItem> EntitySettings { get; set; }

    }
}