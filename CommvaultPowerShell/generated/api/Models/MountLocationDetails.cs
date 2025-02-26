// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Mount location details</summary>
    public partial class MountLocationDetails :
        Commvault.Powershell.Models.IMountLocationDetails,
        Commvault.Powershell.Models.IMountLocationDetailsInternal
    {

        /// <summary>Internal Acessors for MountPath</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IMountLocationDetailsInternal.MountPath { get => (this._mountPath = this._mountPath ?? new Commvault.Powershell.Models.IdName()); set { {_mountPath = value;} } }

        /// <summary>Backing field for <see cref="DataServerType" /> property.</summary>
        private string _dataServerType;

        /// <summary>Type of device access server type.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DataServerType { get => this._dataServerType; set => this._dataServerType = value; }

        /// <summary>Backing field for <see cref="DeviceId" /> property.</summary>
        private long? _deviceId;

        /// <summary>Unique device identifier.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? DeviceId { get => this._deviceId; set => this._deviceId = value; }

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>Describe whether mount path is enabled or not.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="MountPath" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _mountPath;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName MountPath { get => (this._mountPath = this._mountPath ?? new Commvault.Powershell.Models.IdName()); set => this._mountPath = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? MountPathId { get => ((Commvault.Powershell.Models.IIdNameInternal)MountPath).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)MountPath).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string MountPathName { get => ((Commvault.Powershell.Models.IIdNameInternal)MountPath).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)MountPath).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Status of the mount path.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="MountLocationDetails" /> instance.</summary>
        public MountLocationDetails()
        {

        }
    }
    /// Mount location details
    public partial interface IMountLocationDetails :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Type of device access server type.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of device access server type.",
        SerializedName = @"dataServerType",
        PossibleTypes = new [] { typeof(string) })]
        string DataServerType { get; set; }
        /// <summary>Unique device identifier.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Unique device identifier.",
        SerializedName = @"deviceId",
        PossibleTypes = new [] { typeof(long) })]
        long? DeviceId { get; set; }
        /// <summary>Describe whether mount path is enabled or not.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Describe whether mount path is enabled or not.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? MountPathId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string MountPathName { get; set; }
        /// <summary>Status of the mount path.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Status of the mount path.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }

    }
    /// Mount location details
    internal partial interface IMountLocationDetailsInternal

    {
        /// <summary>Type of device access server type.</summary>
        string DataServerType { get; set; }
        /// <summary>Unique device identifier.</summary>
        long? DeviceId { get; set; }
        /// <summary>Describe whether mount path is enabled or not.</summary>
        bool? Enabled { get; set; }

        Commvault.Powershell.Models.IIdName MountPath { get; set; }

        long? MountPathId { get; set; }

        string MountPathName { get; set; }
        /// <summary>Status of the mount path.</summary>
        string Status { get; set; }

    }
}