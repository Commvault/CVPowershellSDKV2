// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>ListClusters</summary>
    public partial class ListClusters :
        Commvault.Powershell.Models.IListClusters,
        Commvault.Powershell.Models.IListClustersInternal
    {

        /// <summary>Backing field for <see cref="ClusterCount" /> property.</summary>
        private long? _clusterCount;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? ClusterCount { get => this._clusterCount; set => this._clusterCount = value; }

        /// <summary>Backing field for <see cref="Clusters" /> property.</summary>
        private Commvault.Powershell.Models.IClusterListResp[] _clusters;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IClusterListResp[] Clusters { get => this._clusters; set => this._clusters = value; }

        /// <summary>Creates an new <see cref="ListClusters" /> instance.</summary>
        public ListClusters()
        {

        }
    }
    /// ListClusters
    public partial interface IListClusters :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"clusterCount",
        PossibleTypes = new [] { typeof(long) })]
        long? ClusterCount { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"clusters",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IClusterListResp) })]
        Commvault.Powershell.Models.IClusterListResp[] Clusters { get; set; }

    }
    /// ListClusters
    internal partial interface IListClustersInternal

    {
        long? ClusterCount { get; set; }

        Commvault.Powershell.Models.IClusterListResp[] Clusters { get; set; }

    }
}