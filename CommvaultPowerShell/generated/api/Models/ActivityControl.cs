// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class ActivityControl :
        Commvault.Powershell.Models.IActivityControl,
        Commvault.Powershell.Models.IActivityControlInternal
    {

        /// <summary>Backing field for <see cref="DataAging" /> property.</summary>
        private bool? _dataAging;

        /// <summary>Data Aging is enabled or not</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? DataAging { get => this._dataAging; set => this._dataAging = value; }

        /// <summary>Backing field for <see cref="DataRestore" /> property.</summary>
        private bool? _dataRestore;

        /// <summary>Data Restore is enabled or not</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? DataRestore { get => this._dataRestore; set => this._dataRestore = value; }

        /// <summary>Backing field for <see cref="Databackup" /> property.</summary>
        private bool? _databackup;

        /// <summary>Data Backup is enabled or not</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? Databackup { get => this._databackup; set => this._databackup = value; }

        /// <summary>Creates an new <see cref="ActivityControl" /> instance.</summary>
        public ActivityControl()
        {

        }
    }
    public partial interface IActivityControl :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Data Aging is enabled or not</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Data Aging is enabled or not",
        SerializedName = @"dataAging",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DataAging { get; set; }
        /// <summary>Data Restore is enabled or not</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Data Restore is enabled or not",
        SerializedName = @"dataRestore",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DataRestore { get; set; }
        /// <summary>Data Backup is enabled or not</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Data Backup is enabled or not",
        SerializedName = @"databackup",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Databackup { get; set; }

    }
    internal partial interface IActivityControlInternal

    {
        /// <summary>Data Aging is enabled or not</summary>
        bool? DataAging { get; set; }
        /// <summary>Data Restore is enabled or not</summary>
        bool? DataRestore { get; set; }
        /// <summary>Data Backup is enabled or not</summary>
        bool? Databackup { get; set; }

    }
}