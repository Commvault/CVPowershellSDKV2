// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class DiskStorageGeneralInfo :
        Commvault.Powershell.Models.IDiskStorageGeneralInfo,
        Commvault.Powershell.Models.IDiskStorageGeneralInfoInternal
    {

        /// <summary>Backing field for <see cref="Capacity" /> property.</summary>
        private long? _capacity;

        /// <summary>specifies the capacity of the storage pool</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? Capacity { get => this._capacity; set => this._capacity = value; }

        /// <summary>Backing field for <see cref="DedupeSavingsPercent" /> property.</summary>
        private long? _dedupeSavingsPercent;

        /// <summary>
        /// specifies the savings that occurred due to deduplication. Only available for dedupe storage pools.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? DedupeSavingsPercent { get => this._dedupeSavingsPercent; set => this._dedupeSavingsPercent = value; }

        /// <summary>Backing field for <see cref="FreeSpace" /> property.</summary>
        private long? _freeSpace;

        /// <summary>specifies the available space on the storage pool</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? FreeSpace { get => this._freeSpace; set => this._freeSpace = value; }

        /// <summary>Backing field for <see cref="SizeOnDisk" /> property.</summary>
        private long? _sizeOnDisk;

        /// <summary>
        /// Size on disk refers to the actual amount of space being taken by the storage pool on the disk.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? SizeOnDisk { get => this._sizeOnDisk; set => this._sizeOnDisk = value; }

        /// <summary>Creates an new <see cref="DiskStorageGeneralInfo" /> instance.</summary>
        public DiskStorageGeneralInfo()
        {

        }
    }
    public partial interface IDiskStorageGeneralInfo :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>specifies the capacity of the storage pool</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"specifies the capacity of the storage pool",
        SerializedName = @"capacity",
        PossibleTypes = new [] { typeof(long) })]
        long? Capacity { get; set; }
        /// <summary>
        /// specifies the savings that occurred due to deduplication. Only available for dedupe storage pools.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"specifies the savings that occurred due to deduplication. Only available for dedupe storage pools.",
        SerializedName = @"dedupeSavingsPercent",
        PossibleTypes = new [] { typeof(long) })]
        long? DedupeSavingsPercent { get; set; }
        /// <summary>specifies the available space on the storage pool</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"specifies the available space on the storage pool",
        SerializedName = @"freeSpace",
        PossibleTypes = new [] { typeof(long) })]
        long? FreeSpace { get; set; }
        /// <summary>
        /// Size on disk refers to the actual amount of space being taken by the storage pool on the disk.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Size on disk refers to the actual amount of space being taken by the storage pool on the disk.",
        SerializedName = @"sizeOnDisk",
        PossibleTypes = new [] { typeof(long) })]
        long? SizeOnDisk { get; set; }

    }
    internal partial interface IDiskStorageGeneralInfoInternal

    {
        /// <summary>specifies the capacity of the storage pool</summary>
        long? Capacity { get; set; }
        /// <summary>
        /// specifies the savings that occurred due to deduplication. Only available for dedupe storage pools.
        /// </summary>
        long? DedupeSavingsPercent { get; set; }
        /// <summary>specifies the available space on the storage pool</summary>
        long? FreeSpace { get; set; }
        /// <summary>
        /// Size on disk refers to the actual amount of space being taken by the storage pool on the disk.
        /// </summary>
        long? SizeOnDisk { get; set; }

    }
}