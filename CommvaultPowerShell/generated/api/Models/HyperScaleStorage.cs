// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>HyperScaleStorage</summary>
    public partial class HyperScaleStorage :
        Commvault.Powershell.Models.IHyperScaleStorage,
        Commvault.Powershell.Models.IHyperScaleStorageInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of HyperScale Storage</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Nodes" /> property.</summary>
        private Commvault.Powershell.Models.IIdName[] _nodes;

        /// <summary>List of Nodes (MediaAgents) of the HyperScale Storage</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdName[] Nodes { get => this._nodes; set => this._nodes = value; }

        /// <summary>Creates an new <see cref="HyperScaleStorage" /> instance.</summary>
        public HyperScaleStorage()
        {

        }
    }
    /// HyperScaleStorage
    public partial interface IHyperScaleStorage :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Name of HyperScale Storage</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of HyperScale Storage",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>List of Nodes (MediaAgents) of the HyperScale Storage</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"List of Nodes (MediaAgents) of the HyperScale Storage",
        SerializedName = @"nodes",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] Nodes { get; set; }

    }
    /// HyperScaleStorage
    internal partial interface IHyperScaleStorageInternal

    {
        /// <summary>Name of HyperScale Storage</summary>
        string Name { get; set; }
        /// <summary>List of Nodes (MediaAgents) of the HyperScale Storage</summary>
        Commvault.Powershell.Models.IIdName[] Nodes { get; set; }

    }
}