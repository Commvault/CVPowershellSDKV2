// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class StorageResourcePoolMap :
        Commvault.Powershell.Models.IStorageResourcePoolMap,
        Commvault.Powershell.Models.IStorageResourcePoolMapInternal
    {

        /// <summary>Internal Acessors for Storage</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IStorageResourcePoolMapInternal.Storage { get => (this._storage = this._storage ?? new Commvault.Powershell.Models.IdName()); set { {_storage = value;} } }

        /// <summary>Backing field for <see cref="Resources" /> property.</summary>
        private System.Collections.Generic.List<Commvault.Powershell.Models.IResourcePoolInfo> _resources;

        /// <summary>List of resources mapped to the storage</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.IResourcePoolInfo> Resources { get => this._resources; set => this._resources = value; }

        /// <summary>Backing field for <see cref="Storage" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _storage;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Storage { get => (this._storage = this._storage ?? new Commvault.Powershell.Models.IdName()); set => this._storage = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? StorageId { get => ((Commvault.Powershell.Models.IIdNameInternal)Storage).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Storage).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string StorageName { get => ((Commvault.Powershell.Models.IIdNameInternal)Storage).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Storage).Name = value ?? null; }

        /// <summary>Creates an new <see cref="StorageResourcePoolMap" /> instance.</summary>
        public StorageResourcePoolMap()
        {

        }
    }
    public partial interface IStorageResourcePoolMap :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>List of resources mapped to the storage</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of resources mapped to the storage",
        SerializedName = @"resources",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IResourcePoolInfo) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.IResourcePoolInfo> Resources { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? StorageId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string StorageName { get; set; }

    }
    internal partial interface IStorageResourcePoolMapInternal

    {
        /// <summary>List of resources mapped to the storage</summary>
        System.Collections.Generic.List<Commvault.Powershell.Models.IResourcePoolInfo> Resources { get; set; }

        Commvault.Powershell.Models.IIdName Storage { get; set; }

        long? StorageId { get; set; }

        string StorageName { get; set; }

    }
}