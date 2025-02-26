// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// To allow the derived plans that use this plan as the base plan to override the settings, property allowPlanOverride must
    /// be true, and then select one of the options for Storage pool, RPO , Folders to backup, and Retention.
    /// </summary>
    public partial class LaptopPlanOverrideSettings :
        Commvault.Powershell.Models.ILaptopPlanOverrideSettings,
        Commvault.Powershell.Models.ILaptopPlanOverrideSettingsInternal
    {

        /// <summary>Backing field for <see cref="BackupContent" /> property.</summary>
        private string _backupContent;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string BackupContent { get => this._backupContent; set => this._backupContent = value; }

        /// <summary>Backing field for <see cref="Retention" /> property.</summary>
        private string _retention;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Retention { get => this._retention; set => this._retention = value; }

        /// <summary>Backing field for <see cref="Rpo" /> property.</summary>
        private string _rpo;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Rpo { get => this._rpo; set => this._rpo = value; }

        /// <summary>Backing field for <see cref="StoragePool" /> property.</summary>
        private string _storagePool;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string StoragePool { get => this._storagePool; set => this._storagePool = value; }

        /// <summary>Creates an new <see cref="LaptopPlanOverrideSettings" /> instance.</summary>
        public LaptopPlanOverrideSettings()
        {

        }
    }
    /// To allow the derived plans that use this plan as the base plan to override the settings, property allowPlanOverride must
    /// be true, and then select one of the options for Storage pool, RPO , Folders to backup, and Retention.
    public partial interface ILaptopPlanOverrideSettings :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"backupContent",
        PossibleTypes = new [] { typeof(string) })]
        string BackupContent { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"retention",
        PossibleTypes = new [] { typeof(string) })]
        string Retention { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"RPO",
        PossibleTypes = new [] { typeof(string) })]
        string Rpo { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"storagePool",
        PossibleTypes = new [] { typeof(string) })]
        string StoragePool { get; set; }

    }
    /// To allow the derived plans that use this plan as the base plan to override the settings, property allowPlanOverride must
    /// be true, and then select one of the options for Storage pool, RPO , Folders to backup, and Retention.
    internal partial interface ILaptopPlanOverrideSettingsInternal

    {
        string BackupContent { get; set; }

        string Retention { get; set; }

        string Rpo { get; set; }

        string StoragePool { get; set; }

    }
}