// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.9.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>StoragePool</summary>
    public partial class StoragePool :
        Commvault.Powershell.Models.IStoragePool,
        Commvault.Powershell.Models.IStoragePoolInternal
    {

        /// <summary>Internal Acessors for Region</summary>
        Commvault.Powershell.Models.IIdNameDisplayName Commvault.Powershell.Models.IStoragePoolInternal.Region { get => (this._region = this._region ?? new Commvault.Powershell.Models.IdNameDisplayName()); set { {_region = value;} } }

        /// <summary>Backing field for <see cref="DeviceType" /> property.</summary>
        private string _deviceType;

        /// <summary>Device type of the storage.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DeviceType { get => this._deviceType; set => this._deviceType = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private long? _id;

        /// <summary>Id of Storage Pool</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="IsArchiveStorage" /> property.</summary>
        private bool? _isArchiveStorage;

        /// <summary>Flag indicating whether the storage tier is archive.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? IsArchiveStorage { get => this._isArchiveStorage; set => this._isArchiveStorage = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of Storage Pool</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Region" /> property.</summary>
        private Commvault.Powershell.Models.IIdNameDisplayName _region;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdNameDisplayName Region { get => (this._region = this._region ?? new Commvault.Powershell.Models.IdNameDisplayName()); set => this._region = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string RegionDisplayName { get => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Region).DisplayName; set => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Region).DisplayName = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? RegionId { get => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Region).Id; set => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Region).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string RegionName { get => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Region).Name; set => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Region).Name = value ?? null; }

        /// <summary>Backing field for <see cref="RetentionPeriodDays" /> property.</summary>
        private long? _retentionPeriodDays;

        /// <summary>Retention period of pool in days</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? RetentionPeriodDays { get => this._retentionPeriodDays; set => this._retentionPeriodDays = value; }

        /// <summary>Backing field for <see cref="StorageClass" /> property.</summary>
        private string _storageClass;

        /// <summary>Storage container information of the storage.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string StorageClass { get => this._storageClass; set => this._storageClass = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Type of Storage Pool</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="WormStoragePoolFlag" /> property.</summary>
        private long? _wormStoragePoolFlag;

        /// <summary>
        /// Bit flag indicating WORM configuration of storage pool. 0 means no lock, 1 means compliance lock, 2 means worm storage
        /// lock, 4 means Object worm lock and 8 means bucket worm lock.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? WormStoragePoolFlag { get => this._wormStoragePoolFlag; set => this._wormStoragePoolFlag = value; }

        /// <summary>Creates an new <see cref="StoragePool" /> instance.</summary>
        public StoragePool()
        {

        }
    }
    /// StoragePool
    public partial interface IStoragePool :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Device type of the storage.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Device type of the storage.",
        SerializedName = @"deviceType",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceType { get; set; }
        /// <summary>Id of Storage Pool</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of Storage Pool",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? Id { get; set; }
        /// <summary>Flag indicating whether the storage tier is archive.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag indicating whether the storage tier is archive.",
        SerializedName = @"isArchiveStorage",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsArchiveStorage { get; set; }
        /// <summary>Name of Storage Pool</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of Storage Pool",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string RegionDisplayName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? RegionId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string RegionName { get; set; }
        /// <summary>Retention period of pool in days</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Retention period of pool in days",
        SerializedName = @"retentionPeriodDays",
        PossibleTypes = new [] { typeof(long) })]
        long? RetentionPeriodDays { get; set; }
        /// <summary>Storage container information of the storage.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Storage container information of the storage.",
        SerializedName = @"storageClass",
        PossibleTypes = new [] { typeof(string) })]
        string StorageClass { get; set; }
        /// <summary>Type of Storage Pool</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of Storage Pool",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }
        /// <summary>
        /// Bit flag indicating WORM configuration of storage pool. 0 means no lock, 1 means compliance lock, 2 means worm storage
        /// lock, 4 means Object worm lock and 8 means bucket worm lock.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Bit flag indicating WORM configuration of storage pool. 0 means no lock, 1 means compliance lock, 2 means worm storage lock, 4 means Object worm lock and 8 means bucket worm lock.",
        SerializedName = @"wormStoragePoolFlag",
        PossibleTypes = new [] { typeof(long) })]
        long? WormStoragePoolFlag { get; set; }

    }
    /// StoragePool
    internal partial interface IStoragePoolInternal

    {
        /// <summary>Device type of the storage.</summary>
        string DeviceType { get; set; }
        /// <summary>Id of Storage Pool</summary>
        long? Id { get; set; }
        /// <summary>Flag indicating whether the storage tier is archive.</summary>
        bool? IsArchiveStorage { get; set; }
        /// <summary>Name of Storage Pool</summary>
        string Name { get; set; }

        Commvault.Powershell.Models.IIdNameDisplayName Region { get; set; }

        string RegionDisplayName { get; set; }

        long? RegionId { get; set; }

        string RegionName { get; set; }
        /// <summary>Retention period of pool in days</summary>
        long? RetentionPeriodDays { get; set; }
        /// <summary>Storage container information of the storage.</summary>
        string StorageClass { get; set; }
        /// <summary>Type of Storage Pool</summary>
        string Type { get; set; }
        /// <summary>
        /// Bit flag indicating WORM configuration of storage pool. 0 means no lock, 1 means compliance lock, 2 means worm storage
        /// lock, 4 means Object worm lock and 8 means bucket worm lock.
        /// </summary>
        long? WormStoragePoolFlag { get; set; }

    }
}