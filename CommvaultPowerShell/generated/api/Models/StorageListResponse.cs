// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class StorageListResponse :
        Commvault.Powershell.Models.IStorageListResponse,
        Commvault.Powershell.Models.IStorageListResponseInternal
    {

        /// <summary>Backing field for <see cref="DiskStorage" /> property.</summary>
        private Commvault.Powershell.Models.IStorageListSummary[] _diskStorage;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IStorageListSummary[] DiskStorage { get => this._diskStorage; set => this._diskStorage = value; }

        /// <summary>Creates an new <see cref="StorageListResponse" /> instance.</summary>
        public StorageListResponse()
        {

        }
    }
    public partial interface IStorageListResponse :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"diskStorage",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IStorageListSummary) })]
        Commvault.Powershell.Models.IStorageListSummary[] DiskStorage { get; set; }

    }
    internal partial interface IStorageListResponseInternal

    {
        Commvault.Powershell.Models.IStorageListSummary[] DiskStorage { get; set; }

    }
}