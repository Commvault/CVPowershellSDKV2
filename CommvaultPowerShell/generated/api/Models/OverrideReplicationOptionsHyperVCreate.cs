// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// Replication options for HyperV. Provide both the name and the guid of the source VM.
    /// </summary>
    public partial class OverrideReplicationOptionsHyperVCreate :
        Commvault.Powershell.Models.IOverrideReplicationOptionsHyperVCreate,
        Commvault.Powershell.Models.IOverrideReplicationOptionsHyperVCreateInternal
    {

        /// <summary>Internal Acessors for SourceVM</summary>
        Commvault.Powershell.Models.INameGuid Commvault.Powershell.Models.IOverrideReplicationOptionsHyperVCreateInternal.SourceVM { get => (this._sourceVM = this._sourceVM ?? new Commvault.Powershell.Models.NameGuid()); set { {_sourceVM = value;} } }

        /// <summary>Backing field for <see cref="NetworkName" /> property.</summary>
        private string _networkName;

        /// <summary>The name of the network of destination VM</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string NetworkName { get => this._networkName; set => this._networkName = value; }

        /// <summary>Backing field for <see cref="RegisterVMWithFailoverCluster" /> property.</summary>
        private bool? _registerVMWithFailoverCluster;

        /// <summary>
        /// Register replicated virtual machines to the failover cluster for the destination client.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? RegisterVMWithFailoverCluster { get => this._registerVMWithFailoverCluster; set => this._registerVMWithFailoverCluster = value; }

        /// <summary>Backing field for <see cref="SourceVM" /> property.</summary>
        private Commvault.Powershell.Models.INameGuid _sourceVM;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.INameGuid SourceVM { get => (this._sourceVM = this._sourceVM ?? new Commvault.Powershell.Models.NameGuid()); set => this._sourceVM = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SourceVMGuid { get => ((Commvault.Powershell.Models.INameGuidInternal)SourceVM).Guid; set => ((Commvault.Powershell.Models.INameGuidInternal)SourceVM).Guid = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SourceVMName { get => ((Commvault.Powershell.Models.INameGuidInternal)SourceVM).Name; set => ((Commvault.Powershell.Models.INameGuidInternal)SourceVM).Name = value ?? null; }

        /// <summary>Backing field for <see cref="VMDisplayName" /> property.</summary>
        private string _vMDisplayName;

        /// <summary>Display name for the destination VM</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string VMDisplayName { get => this._vMDisplayName; set => this._vMDisplayName = value; }

        /// <summary>Creates an new <see cref="OverrideReplicationOptionsHyperVCreate" /> instance.</summary>
        public OverrideReplicationOptionsHyperVCreate()
        {

        }
    }
    /// Replication options for HyperV. Provide both the name and the guid of the source VM.
    public partial interface IOverrideReplicationOptionsHyperVCreate :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>The name of the network of destination VM</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the network of destination VM",
        SerializedName = @"networkName",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkName { get; set; }
        /// <summary>
        /// Register replicated virtual machines to the failover cluster for the destination client.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Register replicated virtual machines to the failover cluster for the destination client.",
        SerializedName = @"registerVMWithFailoverCluster",
        PossibleTypes = new [] { typeof(bool) })]
        bool? RegisterVMWithFailoverCluster { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"GUID",
        PossibleTypes = new [] { typeof(string) })]
        string SourceVMGuid { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SourceVMName { get; set; }
        /// <summary>Display name for the destination VM</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Display name for the destination VM",
        SerializedName = @"vmDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string VMDisplayName { get; set; }

    }
    /// Replication options for HyperV. Provide both the name and the guid of the source VM.
    internal partial interface IOverrideReplicationOptionsHyperVCreateInternal

    {
        /// <summary>The name of the network of destination VM</summary>
        string NetworkName { get; set; }
        /// <summary>
        /// Register replicated virtual machines to the failover cluster for the destination client.
        /// </summary>
        bool? RegisterVMWithFailoverCluster { get; set; }

        Commvault.Powershell.Models.INameGuid SourceVM { get; set; }

        string SourceVMGuid { get; set; }

        string SourceVMName { get; set; }
        /// <summary>Display name for the destination VM</summary>
        string VMDisplayName { get; set; }

    }
}